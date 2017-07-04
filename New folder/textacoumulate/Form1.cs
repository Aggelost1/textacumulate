using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textacoumulate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string whole;
        string purified;
        string urlS;
        string startS;
        string finS;
        string seperator;
        int first;
        int end;
        int txtStrt;
        int txtFin;
        List<string> garbige = new List<string>() { "<p>", "</p>", "</span>", "</strong>" };

        private string cleanTxt(string all)
        {
           string final = all;
          final =  Regex.Replace(final, @"<(.|\n)*?>", String.Empty);
            /* foreach (string garb in garbige) {
                  final = Regex.Replace(final, @garb,"");
             }*/
          final = Regex.Replace(final, @"#[1-9][0-9][0-9][0-9]", String.Empty);
            return final;
        }
        private string txtOnly(string all)
        {
            //  try
            // {
            all = Regex.Replace(all, @"<\s*hr\s*", @"<hr");
            all = Regex.Replace(all, @"\s*hr\s*>", @"hr>");
            txtFin = all.LastIndexOf(@"<hr");
                string some1 = all.Substring(0,txtFin);

                txtStrt = some1.LastIndexOf(seperator);
                string some = some1.Substring(txtStrt);
                return some;
           // }
           // catch { MessageBox.Show("your txt is not in the expected format"); }
           // return "error";

        }
        private string getUrl(string u)
        {
           
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(u);
                myRequest.Method = "GET";
                WebResponse myResponse = myRequest.GetResponse();
                StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                string result = sr.ReadToEnd();
                sr.Close();
                myResponse.Close();

                return result;
            

        }
        private void getSave_Click(object sender, EventArgs e)
        {
            try
            {
                urlS = Url.Text;
                startS = Start.Text;
                finS = Fin.Text;
                first = Convert.ToInt32(startS);
                end = Convert.ToInt32(finS);
                seperator = Seperate.Text;
            }
            catch
            {
                MessageBox.Show("you didnt fill all boxes");
            }

            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "texttospch.txt";
            // set filters - this can be done in properties as well
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                 
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                {
                    for (int i = first; i < end + 1; i++)
                    {
                        whole = getUrl(urlS + i.ToString());
                        purified = cleanTxt(txtOnly(whole));
                        sw.WriteLine(purified);
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("</p><hr>");
        }
    }
}
