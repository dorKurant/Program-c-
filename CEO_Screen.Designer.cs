namespace group28_1
{
    partial class CEO_Screen
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
            this.customer = new System.Windows.Forms.Button();
            this.employee = new System.Windows.Forms.Button();
            this.supplier = new System.Windows.Forms.Button();
            this.sing_Out = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.Button();
            this.prudoct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(729, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = ",שלום המנכל";
            // 
            // customer
            // 
            this.customer.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.customer.Location = new System.Drawing.Point(826, 215);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(125, 82);
            this.customer.TabIndex = 1;
            this.customer.Text = "לקוחות";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // employee
            // 
            this.employee.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.employee.Location = new System.Drawing.Point(826, 320);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(125, 82);
            this.employee.TabIndex = 2;
            this.employee.Text = "עובדים";
            this.employee.UseVisualStyleBackColor = true;
            this.employee.Click += new System.EventHandler(this.employee_Click);
            // 
            // supplier
            // 
            this.supplier.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.supplier.Location = new System.Drawing.Point(674, 215);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(125, 82);
            this.supplier.TabIndex = 3;
            this.supplier.Text = "ספקים";
            this.supplier.UseVisualStyleBackColor = true;
            this.supplier.Click += new System.EventHandler(this.supplier_Click);
            // 
            // sing_Out
            // 
            this.sing_Out.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sing_Out.Location = new System.Drawing.Point(36, 675);
            this.sing_Out.Name = "sing_Out";
            this.sing_Out.Size = new System.Drawing.Size(98, 47);
            this.sing_Out.TabIndex = 4;
            this.sing_Out.Text = "התנתקות";
            this.sing_Out.UseVisualStyleBackColor = true;
            this.sing_Out.Click += new System.EventHandler(this.sing_Out_Click);
            // 
            // balance
            // 
            this.balance.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.balance.Location = new System.Drawing.Point(659, 624);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(125, 82);
            this.balance.TabIndex = 9;
            this.balance.Text = "מעקב אחר מאזן פיננסי";
            this.balance.UseVisualStyleBackColor = true;
            this.balance.Click += new System.EventHandler(this.balance_Click);
            // 
            // prudoct
            // 
            this.prudoct.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.prudoct.Location = new System.Drawing.Point(808, 624);
            this.prudoct.Name = "prudoct";
            this.prudoct.Size = new System.Drawing.Size(125, 82);
            this.prudoct.TabIndex = 10;
            this.prudoct.Text = "דו\"ח עבור מוצר";
            this.prudoct.UseVisualStyleBackColor = true;
            this.prudoct.Click += new System.EventHandler(this.prudoct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(678, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "במה תרצה לבחור";
            // 
            // CEO_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::group28_1.Properties.Resources.מנכללללללל;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prudoct);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.sing_Out);
            this.Controls.Add(this.supplier);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CEO_Screen";
            this.Text = "CEO_Screen";
            this.Load += new System.EventHandler(this.CEO_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Button employee;
        private System.Windows.Forms.Button supplier;
        private System.Windows.Forms.Button sing_Out;
        private System.Windows.Forms.Button balance;
        private System.Windows.Forms.Button prudoct;
        private System.Windows.Forms.Label label2;
    }
}