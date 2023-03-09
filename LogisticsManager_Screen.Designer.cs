namespace group28_1
{
    partial class LogisticsManager_Screen
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
            this.product = new System.Windows.Forms.Button();
            this.vehicle = new System.Windows.Forms.Button();
            this.sing_Out = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(639, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = ",שלום מנהל לוגיסטי";
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.product.Location = new System.Drawing.Point(793, 274);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(141, 71);
            this.product.TabIndex = 1;
            this.product.Text = "מוצרים";
            this.product.UseVisualStyleBackColor = true;
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // vehicle
            // 
            this.vehicle.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.vehicle.Location = new System.Drawing.Point(645, 274);
            this.vehicle.Name = "vehicle";
            this.vehicle.Size = new System.Drawing.Size(134, 71);
            this.vehicle.TabIndex = 2;
            this.vehicle.Text = "רכבים";
            this.vehicle.UseVisualStyleBackColor = true;
            this.vehicle.Click += new System.EventHandler(this.vehicle_Click);
            // 
            // sing_Out
            // 
            this.sing_Out.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sing_Out.Location = new System.Drawing.Point(39, 684);
            this.sing_Out.Name = "sing_Out";
            this.sing_Out.Size = new System.Drawing.Size(100, 41);
            this.sing_Out.TabIndex = 3;
            this.sing_Out.Text = "התנתקות";
            this.sing_Out.UseVisualStyleBackColor = true;
            this.sing_Out.Click += new System.EventHandler(this.sing_Out_Click);
            // 
            // report
            // 
            this.report.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.report.Location = new System.Drawing.Point(494, 274);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(134, 71);
            this.report.TabIndex = 5;
            this.report.Text = "דוח עבור מוצר";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(688, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "במה תרצה לבחור";
            // 
            // LogisticsManager_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::group28_1.Properties.Resources._144_largeגגג;
            this.ClientSize = new System.Drawing.Size(946, 761);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.report);
            this.Controls.Add(this.sing_Out);
            this.Controls.Add(this.vehicle);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogisticsManager_Screen";
            this.Text = "LogisticsManager_Screen";
            this.Load += new System.EventHandler(this.LogisticsManager_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button product;
        private System.Windows.Forms.Button vehicle;
        private System.Windows.Forms.Button sing_Out;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Label label2;
    }
}