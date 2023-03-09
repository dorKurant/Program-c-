namespace group28_1
{
    partial class Update_Product
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
            this.new_product_lable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Update_click = new System.Windows.Forms.Button();
            this.productType = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.logOut_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_28DataSet1 = new group28_1.SAD_28DataSet1();
            this.productTableAdapter = new group28_1.SAD_28DataSet1TableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_28DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // new_product_lable
            // 
            this.new_product_lable.AutoSize = true;
            this.new_product_lable.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.new_product_lable.Location = new System.Drawing.Point(409, 33);
            this.new_product_lable.Name = "new_product_lable";
            this.new_product_lable.Size = new System.Drawing.Size(240, 36);
            this.new_product_lable.TabIndex = 1;
            this.new_product_lable.Text = "עדכון כמות מוצר";
            this.new_product_lable.Click += new System.EventHandler(this.new_product_lable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(883, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "סוג מוצר";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(793, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "הוסף או הסר (-) מוצר";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Update_click
            // 
            this.Update_click.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Update_click.Location = new System.Drawing.Point(630, 312);
            this.Update_click.Name = "Update_click";
            this.Update_click.Size = new System.Drawing.Size(93, 25);
            this.Update_click.TabIndex = 10;
            this.Update_click.Text = "עדכן";
            this.Update_click.UseVisualStyleBackColor = true;
            this.Update_click.Click += new System.EventHandler(this.Update_click_Click);
            // 
            // productType
            // 
            this.productType.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.productType.FormattingEnabled = true;
            this.productType.Location = new System.Drawing.Point(630, 254);
            this.productType.Name = "productType";
            this.productType.Size = new System.Drawing.Size(130, 27);
            this.productType.TabIndex = 11;
            this.productType.SelectedIndexChanged += new System.EventHandler(this.productType_SelectedIndexChanged);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.quantityTextBox.Location = new System.Drawing.Point(630, 218);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(130, 26);
            this.quantityTextBox.TabIndex = 12;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BackButton.Location = new System.Drawing.Point(59, 588);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(91, 33);
            this.BackButton.TabIndex = 13;
            this.BackButton.Text = "חזרה";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.UseWaitCursor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click_1);
            // 
            // logOut_button
            // 
            this.logOut_button.BackColor = System.Drawing.Color.White;
            this.logOut_button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.logOut_button.Location = new System.Drawing.Point(59, 633);
            this.logOut_button.Name = "logOut_button";
            this.logOut_button.Size = new System.Drawing.Size(91, 33);
            this.logOut_button.TabIndex = 14;
            this.logOut_button.Text = "התנתקות";
            this.logOut_button.UseVisualStyleBackColor = true;
            this.logOut_button.UseWaitCursor = true;
            this.logOut_button.Click += new System.EventHandler(this.logOut_button_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(133, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(324, 322);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.sAD_28DataSet1;
            // 
            // sAD_28DataSet1
            // 
            this.sAD_28DataSet1.DataSetName = "SAD_28DataSet1";
            this.sAD_28DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // Update_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::group28_1.Properties.Resources.בדיקקק;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logOut_button);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.productType);
            this.Controls.Add(this.Update_click);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.new_product_lable);
            this.Name = "Update_Product";
            this.Text = "Add_New_Product";
            this.Load += new System.EventHandler(this.Add_New_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_28DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label new_product_lable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Update_click;
        private System.Windows.Forms.ComboBox productType;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button logOut_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SAD_28DataSet1 sAD_28DataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private SAD_28DataSet1TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}