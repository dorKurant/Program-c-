namespace group28_1
{
    partial class CRUD_Products
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
            this.add_product_click = new System.Windows.Forms.Button();
            this.view_Products_Button = new System.Windows.Forms.Button();
            this.back_Button = new System.Windows.Forms.Button();
            this.logOut_button = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_product_click
            // 
            this.add_product_click.BackColor = System.Drawing.SystemColors.Control;
            this.add_product_click.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.add_product_click.Location = new System.Drawing.Point(658, 221);
            this.add_product_click.Name = "add_product_click";
            this.add_product_click.Size = new System.Drawing.Size(243, 95);
            this.add_product_click.TabIndex = 1;
            this.add_product_click.Text = "עדכן כמות מוצר";
            this.add_product_click.UseVisualStyleBackColor = true;
            this.add_product_click.UseWaitCursor = true;
            this.add_product_click.Click += new System.EventHandler(this.add_product_click_Click);
            // 
            // view_Products_Button
            // 
            this.view_Products_Button.BackColor = System.Drawing.SystemColors.Control;
            this.view_Products_Button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.view_Products_Button.Location = new System.Drawing.Point(658, 353);
            this.view_Products_Button.Name = "view_Products_Button";
            this.view_Products_Button.Size = new System.Drawing.Size(243, 95);
            this.view_Products_Button.TabIndex = 2;
            this.view_Products_Button.Text = "צפייה במוצרים";
            this.view_Products_Button.UseVisualStyleBackColor = true;
            this.view_Products_Button.UseWaitCursor = true;
            this.view_Products_Button.Click += new System.EventHandler(this.view_Products_Button_Click);
            // 
            // back_Button
            // 
            this.back_Button.BackColor = System.Drawing.SystemColors.Control;
            this.back_Button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.back_Button.Location = new System.Drawing.Point(50, 617);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(95, 37);
            this.back_Button.TabIndex = 3;
            this.back_Button.Text = "חזרה";
            this.back_Button.UseVisualStyleBackColor = true;
            this.back_Button.UseWaitCursor = true;
            this.back_Button.Click += new System.EventHandler(this.back_Button_Click);
            // 
            // logOut_button
            // 
            this.logOut_button.BackColor = System.Drawing.SystemColors.Control;
            this.logOut_button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.logOut_button.Location = new System.Drawing.Point(50, 672);
            this.logOut_button.Name = "logOut_button";
            this.logOut_button.Size = new System.Drawing.Size(95, 37);
            this.logOut_button.TabIndex = 4;
            this.logOut_button.Text = "התנתקות";
            this.logOut_button.UseVisualStyleBackColor = true;
            this.logOut_button.UseWaitCursor = true;
            this.logOut_button.Click += new System.EventHandler(this.logOut_button_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(425, 81);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(194, 36);
            this.header.TabIndex = 6;
            this.header.Text = "ניהול מוצרים";
            // 
            // CRUD_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::group28_1.Properties.Resources.בדיקקק;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.header);
            this.Controls.Add(this.logOut_button);
            this.Controls.Add(this.back_Button);
            this.Controls.Add(this.view_Products_Button);
            this.Controls.Add(this.add_product_click);
            this.Name = "CRUD_Products";
            this.Text = "CRUD_Products";
            this.Load += new System.EventHandler(this.CRUD_Products_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add_product_click;
        private System.Windows.Forms.Button view_Products_Button;
        private System.Windows.Forms.Button back_Button;
        private System.Windows.Forms.Button logOut_button;
        private System.Windows.Forms.Label header;
    }
}