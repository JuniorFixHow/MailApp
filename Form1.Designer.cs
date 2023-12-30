namespace MailApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.messTxt = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::MailApp.Properties.Resources.icons8_close_30;
            this.button1.Location = new System.Drawing.Point(763, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 35);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(224, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "SEND";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.label1.Location = new System.Drawing.Point(57, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email:";
            // 
            // emailTxt
            // 
            this.emailTxt.BackColor = System.Drawing.Color.White;
            this.emailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTxt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTxt.Location = new System.Drawing.Point(223, 92);
            this.emailTxt.Multiline = true;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PlaceholderText = "  email@example.com";
            this.emailTxt.Size = new System.Drawing.Size(297, 32);
            this.emailTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.label2.Location = new System.Drawing.Point(57, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject:";
            // 
            // subjectTxt
            // 
            this.subjectTxt.BackColor = System.Drawing.Color.White;
            this.subjectTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subjectTxt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subjectTxt.Location = new System.Drawing.Point(223, 149);
            this.subjectTxt.Multiline = true;
            this.subjectTxt.Name = "subjectTxt";
            this.subjectTxt.PlaceholderText = "  email subject";
            this.subjectTxt.Size = new System.Drawing.Size(297, 32);
            this.subjectTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.label3.Location = new System.Drawing.Point(57, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Message:";
            // 
            // messTxt
            // 
            this.messTxt.BackColor = System.Drawing.Color.White;
            this.messTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messTxt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messTxt.Location = new System.Drawing.Point(223, 217);
            this.messTxt.Multiline = true;
            this.messTxt.Name = "messTxt";
            this.messTxt.PlaceholderText = "  type message here";
            this.messTxt.Size = new System.Drawing.Size(510, 129);
            this.messTxt.TabIndex = 4;
            this.messTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(32)))), ((int)(((byte)(111)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(368, 387);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 45);
            this.button4.TabIndex = 2;
            this.button4.Text = "CLEAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.BackColor = System.Drawing.Color.Transparent;
            this.errorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLbl.Location = new System.Drawing.Point(224, 349);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(55, 28);
            this.errorLbl.TabIndex = 5;
            this.errorLbl.Text = "Error";
            this.errorLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MailApp.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.messTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subjectTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button3;
        private Label label1;
        private TextBox emailTxt;
        private Label label2;
        private TextBox subjectTxt;
        private Label label3;
        private TextBox messTxt;
        private Button button4;
        private Label errorLbl;
    }
}