namespace group28_1
{
    partial class Trace_on_financial_balance
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.income = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bidsRevenueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_28DataSet1 = new group28_1.SAD_28DataSet1();
            this.bidsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bidsTableAdapter = new group28_1.SAD_28DataSet1TableAdapters.BidsTableAdapter();
            this.bids_RevenueTableAdapter = new group28_1.SAD_28DataSet1TableAdapters.Bids_RevenueTableAdapter();
            this.expendiure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.orderExpendiureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_ExpendiureTableAdapter = new group28_1.SAD_28DataSet1TableAdapters.Order_ExpendiureTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.year_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calc_buuton = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.workers_salary = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.orders = new System.Windows.Forms.Label();
            this.bids = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.sign_out_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.income)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidsRevenueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_28DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expendiure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderExpendiureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // income
            // 
            chartArea3.Name = "ChartArea1";
            this.income.ChartAreas.Add(chartArea3);
            this.income.DataSource = this.bidsRevenueBindingSource;
            legend3.Name = "Legend1";
            this.income.Legends.Add(legend3);
            this.income.Location = new System.Drawing.Point(12, 229);
            this.income.Name = "income";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "הכנסות מעיצובים";
            series3.XValueMember = "Year";
            series3.YValueMembers = "Income";
            this.income.Series.Add(series3);
            this.income.Size = new System.Drawing.Size(439, 384);
            this.income.TabIndex = 0;
            this.income.Text = "Revenue_chart";
            this.income.Click += new System.EventHandler(this.chart1_Click);
            // 
            // bidsRevenueBindingSource
            // 
            this.bidsRevenueBindingSource.DataMember = "Bids_Revenue";
            this.bidsRevenueBindingSource.DataSource = this.sAD_28DataSet1;
            // 
            // sAD_28DataSet1
            // 
            this.sAD_28DataSet1.DataSetName = "SAD_28DataSet1";
            this.sAD_28DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bidsBindingSource
            // 
            this.bidsBindingSource.DataMember = "Bids";
            this.bidsBindingSource.DataSource = this.sAD_28DataSet1;
            // 
            // bidsTableAdapter
            // 
            this.bidsTableAdapter.ClearBeforeFill = true;
            // 
            // bids_RevenueTableAdapter
            // 
            this.bids_RevenueTableAdapter.ClearBeforeFill = true;
            // 
            // expendiure
            // 
            chartArea4.Name = "ChartArea1";
            this.expendiure.ChartAreas.Add(chartArea4);
            this.expendiure.DataSource = this.orderExpendiureBindingSource;
            legend4.Name = "Legend1";
            this.expendiure.Legends.Add(legend4);
            this.expendiure.Location = new System.Drawing.Point(496, 229);
            this.expendiure.Name = "expendiure";
            this.expendiure.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "מחיר ששולם עבור הזמנות";
            series4.XValueMember = "Year";
            series4.YValueMembers = "Expendiure";
            this.expendiure.Series.Add(series4);
            this.expendiure.Size = new System.Drawing.Size(464, 384);
            this.expendiure.SuppressExceptions = true;
            this.expendiure.TabIndex = 1;
            this.expendiure.Text = "chart2";
            this.expendiure.Click += new System.EventHandler(this.expendiure_Click);
            // 
            // orderExpendiureBindingSource
            // 
            this.orderExpendiureBindingSource.DataMember = "Order_Expendiure";
            this.orderExpendiureBindingSource.DataSource = this.sAD_28DataSet1;
            // 
            // order_ExpendiureTableAdapter
            // 
            this.order_ExpendiureTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(408, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "דוח פיננסי שנתי";
            // 
            // year_textbox
            // 
            this.year_textbox.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.year_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.year_textbox.Location = new System.Drawing.Point(752, 97);
            this.year_textbox.Name = "year_textbox";
            this.year_textbox.Size = new System.Drawing.Size(120, 26);
            this.year_textbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(878, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = ":הזן שנה";
            // 
            // calc_buuton
            // 
            this.calc_buuton.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.calc_buuton.Location = new System.Drawing.Point(635, 97);
            this.calc_buuton.Name = "calc_buuton";
            this.calc_buuton.Size = new System.Drawing.Size(86, 23);
            this.calc_buuton.TabIndex = 5;
            this.calc_buuton.Text = "חשב מאזן";
            this.calc_buuton.UseVisualStyleBackColor = true;
            this.calc_buuton.Click += new System.EventHandler(this.calc_buuton_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(77, 164);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(42, 19);
            this.total.TabIndex = 6;
            this.total.Text = "total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = ":הכנסה מעיצובים";
            // 
            // workers_salary
            // 
            this.workers_salary.AutoSize = true;
            this.workers_salary.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workers_salary.Location = new System.Drawing.Point(33, 132);
            this.workers_salary.Name = "workers_salary";
            this.workers_salary.Size = new System.Drawing.Size(103, 19);
            this.workers_salary.TabIndex = 8;
            this.workers_salary.Text = "(שכר עובדים)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = ":הוצאות על הזמנות";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = ":שכר עובדים לתקופה נבחרת";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(287, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = ":סך הכל";
            // 
            // orders
            // 
            this.orders.AutoSize = true;
            this.orders.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders.Location = new System.Drawing.Point(33, 105);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(103, 19);
            this.orders.TabIndex = 12;
            this.orders.Text = "(שכר עובדים)";
            // 
            // bids
            // 
            this.bids.AutoSize = true;
            this.bids.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bids.Location = new System.Drawing.Point(33, 79);
            this.bids.Name = "bids";
            this.bids.Size = new System.Drawing.Size(103, 19);
            this.bids.TabIndex = 13;
            this.bids.Text = "(שכר עובדים)";
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.back_button.Location = new System.Drawing.Point(36, 667);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(105, 31);
            this.back_button.TabIndex = 14;
            this.back_button.Text = "חזור";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // sign_out_button
            // 
            this.sign_out_button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sign_out_button.Location = new System.Drawing.Point(36, 718);
            this.sign_out_button.Name = "sign_out_button";
            this.sign_out_button.Size = new System.Drawing.Size(105, 31);
            this.sign_out_button.TabIndex = 15;
            this.sign_out_button.Text = "התנתק";
            this.sign_out_button.UseVisualStyleBackColor = true;
            this.sign_out_button.Click += new System.EventHandler(this.sign_out_button_Click);
            // 
            // Trace_on_financial_balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::group28_1.Properties.Resources.בדיקקק;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.sign_out_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.bids);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.workers_salary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.total);
            this.Controls.Add(this.calc_buuton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.year_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expendiure);
            this.Controls.Add(this.income);
            this.Name = "Trace_on_financial_balance";
            this.Text = "Trace_on_financial_balance";
            this.Load += new System.EventHandler(this.Trace_on_financial_balance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.income)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidsRevenueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_28DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expendiure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderExpendiureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SAD_28DataSet1 sAD_28DataSet1;
        private System.Windows.Forms.BindingSource bidsBindingSource;
        private SAD_28DataSet1TableAdapters.BidsTableAdapter bidsTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart income;
        private System.Windows.Forms.BindingSource bidsRevenueBindingSource;
        private SAD_28DataSet1TableAdapters.Bids_RevenueTableAdapter bids_RevenueTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart expendiure;
        private System.Windows.Forms.BindingSource orderExpendiureBindingSource;
        private SAD_28DataSet1TableAdapters.Order_ExpendiureTableAdapter order_ExpendiureTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox year_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calc_buuton;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label workers_salary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label orders;
        private System.Windows.Forms.Label bids;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button sign_out_button;
    }
}