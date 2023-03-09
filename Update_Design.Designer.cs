namespace group28_1
{
    partial class Update_Design
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.designIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_28DataSet1 = new group28_1.SAD_28DataSet1();
            this.designsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.designsTableAdapter = new group28_1.SAD_28DataSet1TableAdapters.DesignsTableAdapter();
            this.dESIGNSPRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dESIGNS_PRODUCTSTableAdapter = new group28_1.SAD_28DataSet1TableAdapters.DESIGNS_PRODUCTSTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.designs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productsAmount = new System.Windows.Forms.TextBox();
            this.add_design = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bidScreen = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.numberOfTable = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.newTables = new System.Windows.Forms.TextBox();
            this.return_button = new System.Windows.Forms.Button();
            this.sing_Out = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_28DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dESIGNSPRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.designIDDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.designsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(475, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(242, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // designIDDataGridViewTextBoxColumn
            // 
            this.designIDDataGridViewTextBoxColumn.DataPropertyName = "DesignID";
            this.designIDDataGridViewTextBoxColumn.HeaderText = "DesignID";
            this.designIDDataGridViewTextBoxColumn.Name = "designIDDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // designsBindingSource1
            // 
            this.designsBindingSource1.DataMember = "Designs";
            this.designsBindingSource1.DataSource = this.sAD_28DataSet1;
            // 
            // sAD_28DataSet1
            // 
            this.sAD_28DataSet1.DataSetName = "SAD_28DataSet1";
            this.sAD_28DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // designsBindingSource
            // 
            this.designsBindingSource.DataMember = "Designs";
            this.designsBindingSource.DataSource = this.sAD_28DataSet1;
            // 
            // designsTableAdapter
            // 
            this.designsTableAdapter.ClearBeforeFill = true;
            // 
            // dESIGNSPRODUCTSBindingSource
            // 
            this.dESIGNSPRODUCTSBindingSource.DataMember = "DESIGNS_PRODUCTS";
            this.dESIGNSPRODUCTSBindingSource.DataSource = this.sAD_28DataSet1;
            // 
            // dESIGNS_PRODUCTSTableAdapter
            // 
            this.dESIGNS_PRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.designs,
            this.product,
            this.quantity});
            this.dataGridView2.Location = new System.Drawing.Point(51, 102);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(278, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // designs
            // 
            this.designs.HeaderText = "מספר עיצוב";
            this.designs.Name = "designs";
            // 
            // product
            // 
            this.product.HeaderText = "שם המוצר";
            this.product.Name = "product";
            this.product.Width = 80;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "כמות";
            this.quantity.Name = "quantity";
            // 
            // products
            // 
            this.products.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.products.Location = new System.Drawing.Point(360, 162);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(75, 23);
            this.products.TabIndex = 2;
            this.products.Text = "הצג מוצרים";
            this.products.UseVisualStyleBackColor = true;
            this.products.Click += new System.EventHandler(this.products_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(271, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "הוסף מוצר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(266, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = " הוסף כמות";
            // 
            // productType
            // 
            this.productType.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.productType.FormattingEnabled = true;
            this.productType.Location = new System.Drawing.Point(150, 304);
            this.productType.Name = "productType";
            this.productType.Size = new System.Drawing.Size(100, 24);
            this.productType.TabIndex = 5;
            this.productType.SelectedIndexChanged += new System.EventHandler(this.productType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(576, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = " :מספר שולחנות כרגע ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // productsAmount
            // 
            this.productsAmount.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.productsAmount.Location = new System.Drawing.Point(150, 340);
            this.productsAmount.Name = "productsAmount";
            this.productsAmount.Size = new System.Drawing.Size(100, 23);
            this.productsAmount.TabIndex = 8;
            this.productsAmount.TextChanged += new System.EventHandler(this.productsAmount_TextChanged);
            // 
            // add_design
            // 
            this.add_design.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.add_design.Location = new System.Drawing.Point(175, 379);
            this.add_design.Name = "add_design";
            this.add_design.Size = new System.Drawing.Size(75, 23);
            this.add_design.TabIndex = 9;
            this.add_design.Text = "הוסף מוצר";
            this.add_design.UseVisualStyleBackColor = true;
            this.add_design.Click += new System.EventHandler(this.add_design_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("David", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(298, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 35);
            this.label4.TabIndex = 10;
            this.label4.Text = "עדכון עיצוב";
            // 
            // bidScreen
            // 
            this.bidScreen.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bidScreen.Location = new System.Drawing.Point(291, 429);
            this.bidScreen.Name = "bidScreen";
            this.bidScreen.Size = new System.Drawing.Size(193, 23);
            this.bidScreen.TabIndex = 41;
            this.bidScreen.Text = "עבור להצעת מחיר";
            this.bidScreen.UseVisualStyleBackColor = true;
            this.bidScreen.Click += new System.EventHandler(this.bidScreen_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(254, 258);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(75, 23);
            this.deleteProduct.TabIndex = 42;
            this.deleteProduct.Text = "מחק מוצר";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // numberOfTable
            // 
            this.numberOfTable.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numberOfTable.Location = new System.Drawing.Point(470, 337);
            this.numberOfTable.Name = "numberOfTable";
            this.numberOfTable.Size = new System.Drawing.Size(171, 23);
            this.numberOfTable.TabIndex = 43;
            this.numberOfTable.Text = "שנה מספר שולחנות";
            this.numberOfTable.UseVisualStyleBackColor = true;
            this.numberOfTable.Click += new System.EventHandler(this.numberOfTable_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(585, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = ":מספר שולחנות חדש";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(561, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 45;
            this.label6.Text = "עיצובים";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(147, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 19);
            this.label7.TabIndex = 46;
            this.label7.Text = "מוצרים לכל עיצוב";
            // 
            // newTables
            // 
            this.newTables.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.newTables.Location = new System.Drawing.Point(475, 297);
            this.newTables.Name = "newTables";
            this.newTables.Size = new System.Drawing.Size(95, 23);
            this.newTables.TabIndex = 47;
            this.newTables.TextChanged += new System.EventHandler(this.newTables_TextChanged);
            // 
            // return_button
            // 
            this.return_button.Cursor = System.Windows.Forms.Cursors.No;
            this.return_button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.return_button.Location = new System.Drawing.Point(12, 399);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(100, 37);
            this.return_button.TabIndex = 49;
            this.return_button.Text = "חזרה";
            this.return_button.UseCompatibleTextRendering = true;
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // sing_Out
            // 
            this.sing_Out.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sing_Out.Location = new System.Drawing.Point(12, 454);
            this.sing_Out.Name = "sing_Out";
            this.sing_Out.Size = new System.Drawing.Size(100, 41);
            this.sing_Out.TabIndex = 48;
            this.sing_Out.Text = "התנתקות";
            this.sing_Out.UseVisualStyleBackColor = true;
            this.sing_Out.Click += new System.EventHandler(this.sing_Out_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = true;
            this.textBox1.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(504, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 16);
            this.textBox1.TabIndex = 50;
            // 
            // Update_Design
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::group28_1.Properties.Resources.בדיקקק;
            this.ClientSize = new System.Drawing.Size(729, 507);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.sing_Out);
            this.Controls.Add(this.newTables);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numberOfTable);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.bidScreen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.add_design);
            this.Controls.Add(this.productsAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.products);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Update_Design";
            this.Text = "Update_Design";
            this.Load += new System.EventHandler(this.Update_Design_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_28DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dESIGNSPRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SAD_28DataSet1 sAD_28DataSet1;
        private System.Windows.Forms.BindingSource designsBindingSource;
        private SAD_28DataSet1TableAdapters.DesignsTableAdapter designsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn designIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource designsBindingSource1;
        private System.Windows.Forms.BindingSource dESIGNSPRODUCTSBindingSource;
        private SAD_28DataSet1TableAdapters.DESIGNS_PRODUCTSTableAdapter dESIGNS_PRODUCTSTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button products;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox productType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productsAmount;
        private System.Windows.Forms.Button add_design;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bidScreen;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn designs;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button numberOfTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox newTables;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button sing_Out;
        private System.Windows.Forms.Label textBox1;
    }
}