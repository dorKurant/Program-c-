namespace group28_1
{
    partial class Add_New_Customer
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
            this.header = new System.Windows.Forms.Label();
            this.return_button = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id_Textbox = new System.Windows.Forms.TextBox();
            this.email_Textbox = new System.Windows.Forms.TextBox();
            this.phoneNumber_Textbox = new System.Windows.Forms.TextBox();
            this.firstName_Textbox = new System.Windows.Forms.TextBox();
            this.lastName_Textbox = new System.Windows.Forms.TextBox();
            this.create_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(383, 87);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(254, 36);
            this.header.TabIndex = 0;
            this.header.Text = "הוספת לקוח חדש";
            // 
            // return_button
            // 
            this.return_button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.return_button.Location = new System.Drawing.Point(42, 622);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(93, 39);
            this.return_button.TabIndex = 14;
            this.return_button.Text = "חזרה";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.exit.Location = new System.Drawing.Point(42, 676);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(93, 39);
            this.exit.TabIndex = 15;
            this.exit.Text = "התנתקות";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(733, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "מספר תעודת זהות";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(786, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "אימייל";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(762, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "מספר טלפון";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(779, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "שם פרטי";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(767, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "שם משפחה";
            // 
            // id_Textbox
            // 
            this.id_Textbox.Location = new System.Drawing.Point(519, 225);
            this.id_Textbox.Name = "id_Textbox";
            this.id_Textbox.Size = new System.Drawing.Size(181, 20);
            this.id_Textbox.TabIndex = 7;
            this.id_Textbox.TextChanged += new System.EventHandler(this.id_Textbox_TextChanged);
            // 
            // email_Textbox
            // 
            this.email_Textbox.Location = new System.Drawing.Point(519, 266);
            this.email_Textbox.Name = "email_Textbox";
            this.email_Textbox.Size = new System.Drawing.Size(181, 20);
            this.email_Textbox.TabIndex = 8;
            this.email_Textbox.TextChanged += new System.EventHandler(this.email_Textbox_TextChanged);
            // 
            // phoneNumber_Textbox
            // 
            this.phoneNumber_Textbox.Location = new System.Drawing.Point(519, 312);
            this.phoneNumber_Textbox.Name = "phoneNumber_Textbox";
            this.phoneNumber_Textbox.Size = new System.Drawing.Size(181, 20);
            this.phoneNumber_Textbox.TabIndex = 9;
            // 
            // firstName_Textbox
            // 
            this.firstName_Textbox.Location = new System.Drawing.Point(519, 359);
            this.firstName_Textbox.Name = "firstName_Textbox";
            this.firstName_Textbox.Size = new System.Drawing.Size(181, 20);
            this.firstName_Textbox.TabIndex = 10;
            // 
            // lastName_Textbox
            // 
            this.lastName_Textbox.Location = new System.Drawing.Point(519, 404);
            this.lastName_Textbox.Name = "lastName_Textbox";
            this.lastName_Textbox.Size = new System.Drawing.Size(181, 20);
            this.lastName_Textbox.TabIndex = 11;
            // 
            // create_button
            // 
            this.create_button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.create_button.Location = new System.Drawing.Point(537, 459);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(120, 41);
            this.create_button.TabIndex = 13;
            this.create_button.Text = "צור לקוח";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // Add_New_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::group28_1.Properties.Resources.בדיקקק;
            this.ClientSize = new System.Drawing.Size(984, 788);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.lastName_Textbox);
            this.Controls.Add(this.firstName_Textbox);
            this.Controls.Add(this.phoneNumber_Textbox);
            this.Controls.Add(this.email_Textbox);
            this.Controls.Add(this.id_Textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header);
            this.Name = "Add_New_Customer";
            this.Text = "Add_New_Customer";
            this.Load += new System.EventHandler(this.Add_New_Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id_Textbox;
        private System.Windows.Forms.TextBox email_Textbox;
        private System.Windows.Forms.TextBox phoneNumber_Textbox;
        private System.Windows.Forms.TextBox firstName_Textbox;
        private System.Windows.Forms.TextBox lastName_Textbox;
        private System.Windows.Forms.Button create_button;
    }
}