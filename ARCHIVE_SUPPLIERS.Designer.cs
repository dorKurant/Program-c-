namespace group28_1
{
    partial class ARCHIVE_SUPPLIERS
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
            this.outOfArchive_click = new System.Windows.Forms.Button();
            this.SupplierID_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRCHIVESUPPLIERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_28DataSet1 = new group28_1.SAD_28DataSet1();
            this.aRCHIVE_SUPPLIERTableAdapter = new group28_1.SAD_28DataSet1TableAdapters.ARCHIVE_SUPPLIERTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRCHIVESUPPLIERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_28DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // outOfArchive_click
            // 
            this.outOfArchive_click.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.outOfArchive_click.Location = new System.Drawing.Point(694, 415);
            this.outOfArchive_click.Name = "outOfArchive_click";
            this.outOfArchive_click.Size = new System.Drawing.Size(70, 35);
            this.outOfArchive_click.TabIndex = 16;
            this.outOfArchive_click.Text = "הוצא";
            this.outOfArchive_click.UseVisualStyleBackColor = true;
            this.outOfArchive_click.Click += new System.EventHandler(this.outOfArchive_click_Click);
            // 
            // SupplierID_textBox
            // 
            this.SupplierID_textBox.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SupplierID_textBox.Location = new System.Drawing.Point(694, 374);
            this.SupplierID_textBox.Name = "SupplierID_textBox";
            this.SupplierID_textBox.Size = new System.Drawing.Size(113, 23);
            this.SupplierID_textBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(825, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "ת\"ז ספק";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(690, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "שליפה מארכיון לספקים קיימים";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierIDDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aRCHIVESUPPLIERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(139, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 320);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // aRCHIVESUPPLIERBindingSource
            // 
            this.aRCHIVESUPPLIERBindingSource.DataMember = "ARCHIVE_SUPPLIER";
            this.aRCHIVESUPPLIERBindingSource.DataSource = this.sAD_28DataSet1;
            // 
            // sAD_28DataSet1
            // 
            this.sAD_28DataSet1.DataSetName = "SAD_28DataSet1";
            this.sAD_28DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aRCHIVE_SUPPLIERTableAdapter
            // 
            this.aRCHIVE_SUPPLIERTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(39, 605);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "חזרה";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button6.Location = new System.Drawing.Point(39, 654);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 37);
            this.button6.TabIndex = 19;
            this.button6.Text = "התנתקות";
            this.button6.UseCompatibleTextRendering = true;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(435, 93);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(206, 36);
            this.header.TabIndex = 20;
            this.header.Text = "ארכיון ספקים";
            // 
            // ARCHIVE_SUPPLIERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::group28_1.Properties.Resources.בדיקקק;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.header);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.outOfArchive_click);
            this.Controls.Add(this.SupplierID_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "ARCHIVE_SUPPLIERS";
            this.Text = "ARCHIVE_SUPPLIERS";
            this.Load += new System.EventHandler(this.ARCHIVE_SUPPLIERS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRCHIVESUPPLIERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_28DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button outOfArchive_click;
        private System.Windows.Forms.TextBox SupplierID_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SAD_28DataSet1 sAD_28DataSet1;
        private System.Windows.Forms.BindingSource aRCHIVESUPPLIERBindingSource;
        private SAD_28DataSet1TableAdapters.ARCHIVE_SUPPLIERTableAdapter aRCHIVE_SUPPLIERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label header;
    }
}