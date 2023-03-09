namespace group28_1
{
    partial class Create_Supplier
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
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.supplier_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.phone = new System.Windows.Forms.TextBox();
            this.km = new System.Windows.Forms.Label();
            this.sing_Out = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(807, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "הכנס מזהה ספק";
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ID.Location = new System.Drawing.Point(635, 200);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(143, 27);
            this.ID.TabIndex = 2;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(823, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "הכנס שם ספק";
            // 
            // supplier_Name
            // 
            this.supplier_Name.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.supplier_Name.Location = new System.Drawing.Point(635, 259);
            this.supplier_Name.Multiline = true;
            this.supplier_Name.Name = "supplier_Name";
            this.supplier_Name.Size = new System.Drawing.Size(143, 27);
            this.supplier_Name.TabIndex = 4;
            this.supplier_Name.TextChanged += new System.EventHandler(this.supplier_Name_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(833, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "הכנס איימיל";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.email.Location = new System.Drawing.Point(635, 309);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(143, 27);
            this.email.TabIndex = 6;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.Control;
            this.back.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.back.Location = new System.Drawing.Point(31, 621);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(104, 39);
            this.back.TabIndex = 12;
            this.back.Text = "חזור";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.SystemColors.Control;
            this.create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.create.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.create.Location = new System.Drawing.Point(679, 407);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(99, 34);
            this.create.TabIndex = 13;
            this.create.Text = "הוסף ספק";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.phone.Location = new System.Drawing.Point(635, 359);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(143, 30);
            this.phone.TabIndex = 15;
            this.phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // km
            // 
            this.km.AutoSize = true;
            this.km.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.km.Location = new System.Drawing.Point(807, 370);
            this.km.Name = "km";
            this.km.Size = new System.Drawing.Size(132, 19);
            this.km.TabIndex = 14;
            this.km.Text = "הכנס מספר טלפון";
            // 
            // sing_Out
            // 
            this.sing_Out.BackColor = System.Drawing.SystemColors.Control;
            this.sing_Out.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sing_Out.Location = new System.Drawing.Point(31, 683);
            this.sing_Out.Name = "sing_Out";
            this.sing_Out.Size = new System.Drawing.Size(104, 39);
            this.sing_Out.TabIndex = 16;
            this.sing_Out.Text = "התנתקות";
            this.sing_Out.UseVisualStyleBackColor = true;
            this.sing_Out.Click += new System.EventHandler(this.sing_Out_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(428, 71);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(178, 36);
            this.header.TabIndex = 17;
            this.header.Text = "הוספת ספק";
            // 
            // Create_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::group28_1.Properties.Resources.בדיקקק;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.header);
            this.Controls.Add(this.sing_Out);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.km);
            this.Controls.Add(this.create);
            this.Controls.Add(this.back);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.supplier_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "Create_Supplier";
            this.Text = "Create_Supplier";
            this.Load += new System.EventHandler(this.Create_Supplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox supplier_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label km;
        private System.Windows.Forms.Button sing_Out;
        private System.Windows.Forms.Label header;
    }
}