namespace textacoumulate
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Url = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.TextBox();
            this.Fin = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.getSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Seperate = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Url
            // 
            this.Url.Location = new System.Drawing.Point(170, 12);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(100, 22);
            this.Url.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(170, 40);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 22);
            this.Start.TabIndex = 1;
            // 
            // Fin
            // 
            this.Fin.Location = new System.Drawing.Point(170, 68);
            this.Fin.Name = "Fin";
            this.Fin.Size = new System.Drawing.Size(100, 22);
            this.Fin.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(64, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "url";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(64, 40);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "from (num)";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(64, 68);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "to (num)";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // getSave
            // 
            this.getSave.Location = new System.Drawing.Point(12, 96);
            this.getSave.Name = "getSave";
            this.getSave.Size = new System.Drawing.Size(75, 30);
            this.getSave.TabIndex = 6;
            this.getSave.Text = "get";
            this.getSave.UseVisualStyleBackColor = true;
            this.getSave.Click += new System.EventHandler(this.getSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "char count";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Seperate
            // 
            this.Seperate.Location = new System.Drawing.Point(12, 132);
            this.Seperate.Name = "Seperate";
            this.Seperate.Size = new System.Drawing.Size(258, 22);
            this.Seperate.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(12, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 22);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "seperator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Seperate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.getSave);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Fin);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Url);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Url;
        private System.Windows.Forms.TextBox Start;
        private System.Windows.Forms.TextBox Fin;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button getSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Seperate;
        private System.Windows.Forms.TextBox textBox2;
    }
}

