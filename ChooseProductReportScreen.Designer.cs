namespace group28_1
{
    partial class ChooseProductReportScreen
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
            this.chooseProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chooseStartDate = new System.Windows.Forms.DateTimePicker();
            this.createReport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(809, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "אנא בחר מוצר";
            // 
            // chooseProduct
            // 
            this.chooseProduct.FormattingEnabled = true;
            this.chooseProduct.Location = new System.Drawing.Point(532, 324);
            this.chooseProduct.Name = "chooseProduct";
            this.chooseProduct.Size = new System.Drawing.Size(121, 21);
            this.chooseProduct.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(696, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "אנא בחר תאריך תחילת דוח";
            // 
            // chooseStartDate
            // 
            this.chooseStartDate.Location = new System.Drawing.Point(430, 286);
            this.chooseStartDate.Name = "chooseStartDate";
            this.chooseStartDate.Size = new System.Drawing.Size(223, 20);
            this.chooseStartDate.TabIndex = 3;
            this.chooseStartDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // createReport
            // 
            this.createReport.BackColor = System.Drawing.SystemColors.Control;
            this.createReport.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.createReport.Location = new System.Drawing.Point(430, 402);
            this.createReport.Name = "createReport";
            this.createReport.Size = new System.Drawing.Size(111, 34);
            this.createReport.TabIndex = 5;
            this.createReport.Text = "הפק דוח מוצר";
            this.createReport.UseVisualStyleBackColor = true;
            this.createReport.UseWaitCursor = true;
            this.createReport.Click += new System.EventHandler(this.createReport_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(64, 598);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "חזרה";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(64, 658);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "התנתקות";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(403, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "הפקת דוח מוצר";
            // 
            // ChooseProductReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::group28_1.Properties.Resources.בדיקקק;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.createReport);
            this.Controls.Add(this.chooseStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chooseProduct);
            this.Controls.Add(this.label1);
            this.Name = "ChooseProductReportScreen";
            this.Text = "ChooseProductReportScreen";
            this.Load += new System.EventHandler(this.ChooseProductReportScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chooseProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker chooseStartDate;
        private System.Windows.Forms.Button createReport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}