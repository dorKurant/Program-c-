namespace group28_1
{
    partial class ARCHIVE_VEHICLES
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
            this.vehicleNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vechicleYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.killometrageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRCHIVEVEHICLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_28DataSet1 = new group28_1.SAD_28DataSet1();
            this.aRCHIVE_VEHICLESTableAdapter = new group28_1.SAD_28DataSet1TableAdapters.ARCHIVE_VEHICLESTableAdapter();
            this.outOfArchive_click = new System.Windows.Forms.Button();
            this.vehicleNumber_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRCHIVEVEHICLESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_28DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleNumberDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.vechicleYearDataGridViewTextBoxColumn,
            this.killometrageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aRCHIVEVEHICLESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(132, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 241);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vehicleNumberDataGridViewTextBoxColumn
            // 
            this.vehicleNumberDataGridViewTextBoxColumn.DataPropertyName = "vehicleNumber";
            this.vehicleNumberDataGridViewTextBoxColumn.HeaderText = "vehicleNumber";
            this.vehicleNumberDataGridViewTextBoxColumn.Name = "vehicleNumberDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // vechicleYearDataGridViewTextBoxColumn
            // 
            this.vechicleYearDataGridViewTextBoxColumn.DataPropertyName = "vechicleYear";
            this.vechicleYearDataGridViewTextBoxColumn.HeaderText = "vechicleYear";
            this.vechicleYearDataGridViewTextBoxColumn.Name = "vechicleYearDataGridViewTextBoxColumn";
            // 
            // killometrageDataGridViewTextBoxColumn
            // 
            this.killometrageDataGridViewTextBoxColumn.DataPropertyName = "killometrage";
            this.killometrageDataGridViewTextBoxColumn.HeaderText = "killometrage";
            this.killometrageDataGridViewTextBoxColumn.Name = "killometrageDataGridViewTextBoxColumn";
            // 
            // aRCHIVEVEHICLESBindingSource
            // 
            this.aRCHIVEVEHICLESBindingSource.DataMember = "ARCHIVE_VEHICLES";
            this.aRCHIVEVEHICLESBindingSource.DataSource = this.sAD_28DataSet1;
            // 
            // sAD_28DataSet1
            // 
            this.sAD_28DataSet1.DataSetName = "SAD_28DataSet1";
            this.sAD_28DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aRCHIVE_VEHICLESTableAdapter
            // 
            this.aRCHIVE_VEHICLESTableAdapter.ClearBeforeFill = true;
            // 
            // outOfArchive_click
            // 
            this.outOfArchive_click.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.outOfArchive_click.Location = new System.Drawing.Point(684, 396);
            this.outOfArchive_click.Name = "outOfArchive_click";
            this.outOfArchive_click.Size = new System.Drawing.Size(100, 35);
            this.outOfArchive_click.TabIndex = 12;
            this.outOfArchive_click.Text = "הוצא";
            this.outOfArchive_click.UseVisualStyleBackColor = true;
            this.outOfArchive_click.Click += new System.EventHandler(this.outOfArchive_click_Click);
            // 
            // vehicleNumber_textBox
            // 
            this.vehicleNumber_textBox.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.vehicleNumber_textBox.Location = new System.Drawing.Point(684, 360);
            this.vehicleNumber_textBox.Name = "vehicleNumber_textBox";
            this.vehicleNumber_textBox.Size = new System.Drawing.Size(100, 23);
            this.vehicleNumber_textBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(806, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "מספר רכב";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(656, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "שליפה מארכיון לרכבים קיימים";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(44, 663);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 36);
            this.button2.TabIndex = 21;
            this.button2.Text = "התנתקות";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(44, 619);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "חזרה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(420, 84);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(195, 36);
            this.header.TabIndex = 22;
            this.header.Text = "ארכיון רכבים";
            // 
            // ARCHIVE_VEHICLES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::group28_1.Properties.Resources.בדיקקק;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.header);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outOfArchive_click);
            this.Controls.Add(this.vehicleNumber_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ARCHIVE_VEHICLES";
            this.Text = "ARCHIVE_VEHICLES";
            this.Load += new System.EventHandler(this.ARCHIVE_VEHICLES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRCHIVEVEHICLESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_28DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private SAD_28DataSet1 sAD_28DataSet1;
        private System.Windows.Forms.BindingSource aRCHIVEVEHICLESBindingSource;
        private SAD_28DataSet1TableAdapters.ARCHIVE_VEHICLESTableAdapter aRCHIVE_VEHICLESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vechicleYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn killometrageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button outOfArchive_click;
        private System.Windows.Forms.TextBox vehicleNumber_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label header;
    }
}