namespace group28_1
{
    partial class Entry_Screen
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
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.entry = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.sign_out_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(298, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "הכנס שם משתמש";
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userName.Location = new System.Drawing.Point(118, 183);
            this.userName.Multiline = true;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(145, 28);
            this.userName.TabIndex = 1;
            this.userName.Tag = "qwe";
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.password.Location = new System.Drawing.Point(118, 245);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(145, 28);
            this.password.TabIndex = 2;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(337, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "הכנס סיסמא";
            // 
            // entry
            // 
            this.entry.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.entry.ForeColor = System.Drawing.Color.Black;
            this.entry.Location = new System.Drawing.Point(118, 305);
            this.entry.Name = "entry";
            this.entry.Size = new System.Drawing.Size(85, 34);
            this.entry.TabIndex = 5;
            this.entry.Text = "כניסה";
            this.entry.UseVisualStyleBackColor = true;
            this.entry.Click += new System.EventHandler(this.entry_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(118, 34);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(340, 36);
            this.header.TabIndex = 6;
            this.header.Text = "יעלת החן עיצוב אירועים";
            // 
            // sign_out_button
            // 
            this.sign_out_button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sign_out_button.Location = new System.Drawing.Point(36, 672);
            this.sign_out_button.Name = "sign_out_button";
            this.sign_out_button.Size = new System.Drawing.Size(100, 37);
            this.sign_out_button.TabIndex = 8;
            this.sign_out_button.Text = "יציאה";
            this.sign_out_button.UseCompatibleTextRendering = true;
            this.sign_out_button.UseVisualStyleBackColor = true;
            this.sign_out_button.Click += new System.EventHandler(this.sign_out_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.header);
            this.panel1.Controls.Add(this.entry);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.userName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(227, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 430);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Entry_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::group28_1.Properties.Resources.בדיקקק;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sign_out_button);
            this.Name = "Entry_Screen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Entry_Screen";
            this.Load += new System.EventHandler(this.Entry_Screen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button entry;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button sign_out_button;
        private System.Windows.Forms.Panel panel1;
    }
}