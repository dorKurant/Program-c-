namespace group28_1
{
    partial class CRUD_Customers
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
            this.create_New_Customer_button = new System.Windows.Forms.Button();
            this.view_Customers_button = new System.Windows.Forms.Button();
            this.return_button = new System.Windows.Forms.Button();
            this.sign_out_button = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.button66 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // create_New_Customer_button
            // 
            this.create_New_Customer_button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.create_New_Customer_button.Location = new System.Drawing.Point(677, 262);
            this.create_New_Customer_button.Name = "create_New_Customer_button";
            this.create_New_Customer_button.Size = new System.Drawing.Size(168, 84);
            this.create_New_Customer_button.TabIndex = 1;
            this.create_New_Customer_button.Text = "הוספת לקוח חדש";
            this.create_New_Customer_button.UseCompatibleTextRendering = true;
            this.create_New_Customer_button.UseVisualStyleBackColor = true;
            this.create_New_Customer_button.Click += new System.EventHandler(this.create_New_Customer_button_Click);
            // 
            // view_Customers_button
            // 
            this.view_Customers_button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.view_Customers_button.Location = new System.Drawing.Point(677, 380);
            this.view_Customers_button.Name = "view_Customers_button";
            this.view_Customers_button.Size = new System.Drawing.Size(168, 84);
            this.view_Customers_button.TabIndex = 2;
            this.view_Customers_button.Text = "עדכון/מחיקת לקוחות";
            this.view_Customers_button.UseCompatibleTextRendering = true;
            this.view_Customers_button.UseVisualStyleBackColor = true;
            this.view_Customers_button.Click += new System.EventHandler(this.view_Customers_button_Click);
            // 
            // return_button
            // 
            this.return_button.Cursor = System.Windows.Forms.Cursors.No;
            this.return_button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.return_button.Location = new System.Drawing.Point(53, 606);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(100, 37);
            this.return_button.TabIndex = 3;
            this.return_button.Text = "חזרה";
            this.return_button.UseCompatibleTextRendering = true;
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // sign_out_button
            // 
            this.sign_out_button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sign_out_button.Location = new System.Drawing.Point(53, 660);
            this.sign_out_button.Name = "sign_out_button";
            this.sign_out_button.Size = new System.Drawing.Size(100, 37);
            this.sign_out_button.TabIndex = 4;
            this.sign_out_button.Text = "התנתקות";
            this.sign_out_button.UseCompatibleTextRendering = true;
            this.sign_out_button.UseVisualStyleBackColor = true;
            this.sign_out_button.Click += new System.EventHandler(this.sign_out_button_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(397, 85);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(192, 36);
            this.header.TabIndex = 5;
            this.header.Text = "ניהול לקוחות";
            // 
            // button66
            // 
            this.button66.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button66.Location = new System.Drawing.Point(677, 484);
            this.button66.Name = "button66";
            this.button66.Size = new System.Drawing.Size(168, 84);
            this.button66.TabIndex = 6;
            this.button66.Text = "ארכיון לקוחות";
            this.button66.UseCompatibleTextRendering = true;
            this.button66.UseVisualStyleBackColor = true;
            this.button66.Click += new System.EventHandler(this.button66_Click);
            // 
            // CRUD_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::group28_1.Properties.Resources.בדיקקק;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.button66);
            this.Controls.Add(this.header);
            this.Controls.Add(this.sign_out_button);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.view_Customers_button);
            this.Controls.Add(this.create_New_Customer_button);
            this.Name = "CRUD_Customers";
            this.Text = "CRUD_Customers";
            this.Load += new System.EventHandler(this.CRUD_Customers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button create_New_Customer_button;
        private System.Windows.Forms.Button view_Customers_button;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button sign_out_button;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button button66;
    }
}