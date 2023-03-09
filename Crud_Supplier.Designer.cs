namespace group28_1
{
    partial class Crud_Supplier
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
            this.add_Supplier = new System.Windows.Forms.Button();
            this.view_Supplier = new System.Windows.Forms.Button();
            this.sing_Out = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.archive_suppliers_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(413, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ניהול ספקים";
            // 
            // add_Supplier
            // 
            this.add_Supplier.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.add_Supplier.Location = new System.Drawing.Point(711, 182);
            this.add_Supplier.Name = "add_Supplier";
            this.add_Supplier.Size = new System.Drawing.Size(210, 90);
            this.add_Supplier.TabIndex = 1;
            this.add_Supplier.Text = "הוספת ספק חדש";
            this.add_Supplier.UseVisualStyleBackColor = true;
            this.add_Supplier.Click += new System.EventHandler(this.add_Supplier_Click);
            // 
            // view_Supplier
            // 
            this.view_Supplier.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.view_Supplier.Location = new System.Drawing.Point(711, 306);
            this.view_Supplier.Name = "view_Supplier";
            this.view_Supplier.Size = new System.Drawing.Size(210, 90);
            this.view_Supplier.TabIndex = 2;
            this.view_Supplier.Text = "צפייה בספקים פעילים";
            this.view_Supplier.UseVisualStyleBackColor = true;
            this.view_Supplier.Click += new System.EventHandler(this.view_Supplier_Click);
            // 
            // sing_Out
            // 
            this.sing_Out.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sing_Out.Location = new System.Drawing.Point(63, 665);
            this.sing_Out.Name = "sing_Out";
            this.sing_Out.Size = new System.Drawing.Size(106, 45);
            this.sing_Out.TabIndex = 3;
            this.sing_Out.Text = "התנתקות";
            this.sing_Out.UseVisualStyleBackColor = true;
            this.sing_Out.Click += new System.EventHandler(this.sing_Out_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.back.Location = new System.Drawing.Point(63, 599);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(106, 45);
            this.back.TabIndex = 4;
            this.back.Text = "חזרה";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // archive_suppliers_button
            // 
            this.archive_suppliers_button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.archive_suppliers_button.Location = new System.Drawing.Point(711, 428);
            this.archive_suppliers_button.Name = "archive_suppliers_button";
            this.archive_suppliers_button.Size = new System.Drawing.Size(210, 90);
            this.archive_suppliers_button.TabIndex = 5;
            this.archive_suppliers_button.Text = "ארכיון ספקים";
            this.archive_suppliers_button.UseVisualStyleBackColor = true;
            this.archive_suppliers_button.Click += new System.EventHandler(this.archive_suppliers_button_Click);
            // 
            // Crud_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::group28_1.Properties.Resources.בדיקקק;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.archive_suppliers_button);
            this.Controls.Add(this.back);
            this.Controls.Add(this.sing_Out);
            this.Controls.Add(this.view_Supplier);
            this.Controls.Add(this.add_Supplier);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Crud_Supplier";
            this.Text = "Crud_Supplier";
            this.Load += new System.EventHandler(this.Crud_Supplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_Supplier;
        private System.Windows.Forms.Button view_Supplier;
        private System.Windows.Forms.Button sing_Out;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button archive_suppliers_button;
    }
}