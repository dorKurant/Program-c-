namespace group28_1
{
    partial class View_Vehicle
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
            this.sAD_28DataSet1 = new group28_1.SAD_28DataSet1();
            this.sAD28DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewallvehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_all_vehicleTableAdapter = new group28_1.SAD_28DataSet1TableAdapters.view_all_vehicleTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehicleNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vechicleYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.killometrageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiclesTableAdapter = new group28_1.SAD_28DataSet1TableAdapters.VehiclesTableAdapter();
            this.Update_Vehicle_Button = new System.Windows.Forms.Button();
            this.Delete_Vehicle_Button = new System.Windows.Forms.Button();
            this.Return_Button = new System.Windows.Forms.Button();
            this.kilometrage = new System.Windows.Forms.Label();
            this.vehicleYear = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.vehicleNumber = new System.Windows.Forms.Label();
            this.vehicleNumber_Textbox = new System.Windows.Forms.TextBox();
            this.kilometrage_Textbox = new System.Windows.Forms.TextBox();
            this.vehicleYear_Textbox = new System.Windows.Forms.TextBox();
            this.type_Combobox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_28DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD28DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewallvehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sAD_28DataSet1
            // 
            this.sAD_28DataSet1.DataSetName = "SAD_28DataSet1";
            this.sAD_28DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sAD28DataSet1BindingSource
            // 
            this.sAD28DataSet1BindingSource.DataSource = this.sAD_28DataSet1;
            this.sAD28DataSet1BindingSource.Position = 0;
            // 
            // viewallvehicleBindingSource
            // 
            this.viewallvehicleBindingSource.DataMember = "view_all_vehicle";
            this.viewallvehicleBindingSource.DataSource = this.sAD_28DataSet1;
            // 
            // view_all_vehicleTableAdapter
            // 
            this.view_all_vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleNumberDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.vechicleYearDataGridViewTextBoxColumn,
            this.killometrageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vehiclesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(162, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 306);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "Vehicles";
            this.vehiclesBindingSource.DataSource = this.sAD28DataSet1BindingSource;
            // 
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // Update_Vehicle_Button
            // 
            this.Update_Vehicle_Button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Update_Vehicle_Button.Location = new System.Drawing.Point(699, 449);
            this.Update_Vehicle_Button.Name = "Update_Vehicle_Button";
            this.Update_Vehicle_Button.Size = new System.Drawing.Size(80, 26);
            this.Update_Vehicle_Button.TabIndex = 2;
            this.Update_Vehicle_Button.Text = "עדכון";
            this.Update_Vehicle_Button.UseVisualStyleBackColor = true;
            this.Update_Vehicle_Button.Click += new System.EventHandler(this.Update_Vehicle_Button_Click);
            // 
            // Delete_Vehicle_Button
            // 
            this.Delete_Vehicle_Button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Delete_Vehicle_Button.Location = new System.Drawing.Point(530, 533);
            this.Delete_Vehicle_Button.Name = "Delete_Vehicle_Button";
            this.Delete_Vehicle_Button.Size = new System.Drawing.Size(79, 26);
            this.Delete_Vehicle_Button.TabIndex = 3;
            this.Delete_Vehicle_Button.Text = "מחיקה";
            this.Delete_Vehicle_Button.UseVisualStyleBackColor = true;
            this.Delete_Vehicle_Button.Click += new System.EventHandler(this.Delete_Vehicle_Button_Click);
            // 
            // Return_Button
            // 
            this.Return_Button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Return_Button.Location = new System.Drawing.Point(33, 598);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(87, 35);
            this.Return_Button.TabIndex = 4;
            this.Return_Button.Text = "חזור";
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // kilometrage
            // 
            this.kilometrage.AutoSize = true;
            this.kilometrage.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.kilometrage.Location = new System.Drawing.Point(838, 388);
            this.kilometrage.Name = "kilometrage";
            this.kilometrage.Size = new System.Drawing.Size(77, 19);
            this.kilometrage.TabIndex = 8;
            this.kilometrage.Text = "קילומטרג";
            // 
            // vehicleYear
            // 
            this.vehicleYear.AutoSize = true;
            this.vehicleYear.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.vehicleYear.Location = new System.Drawing.Point(838, 346);
            this.vehicleYear.Name = "vehicleYear";
            this.vehicleYear.Size = new System.Drawing.Size(78, 19);
            this.vehicleYear.TabIndex = 7;
            this.vehicleYear.Text = "שנת ייצור";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.type.Location = new System.Drawing.Point(838, 301);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(32, 19);
            this.type.TabIndex = 6;
            this.type.Text = "סוג";
            // 
            // vehicleNumber
            // 
            this.vehicleNumber.AutoSize = true;
            this.vehicleNumber.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.vehicleNumber.Location = new System.Drawing.Point(838, 265);
            this.vehicleNumber.Name = "vehicleNumber";
            this.vehicleNumber.Size = new System.Drawing.Size(79, 19);
            this.vehicleNumber.TabIndex = 5;
            this.vehicleNumber.Text = "מספר רכב";
            // 
            // vehicleNumber_Textbox
            // 
            this.vehicleNumber_Textbox.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.vehicleNumber_Textbox.Location = new System.Drawing.Point(699, 262);
            this.vehicleNumber_Textbox.Name = "vehicleNumber_Textbox";
            this.vehicleNumber_Textbox.Size = new System.Drawing.Size(112, 26);
            this.vehicleNumber_Textbox.TabIndex = 9;
            this.vehicleNumber_Textbox.TextChanged += new System.EventHandler(this.vehicleNumber_Textbox_TextChanged);
            // 
            // kilometrage_Textbox
            // 
            this.kilometrage_Textbox.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.kilometrage_Textbox.Location = new System.Drawing.Point(699, 388);
            this.kilometrage_Textbox.Name = "kilometrage_Textbox";
            this.kilometrage_Textbox.Size = new System.Drawing.Size(112, 26);
            this.kilometrage_Textbox.TabIndex = 12;
            // 
            // vehicleYear_Textbox
            // 
            this.vehicleYear_Textbox.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.vehicleYear_Textbox.Location = new System.Drawing.Point(699, 346);
            this.vehicleYear_Textbox.Name = "vehicleYear_Textbox";
            this.vehicleYear_Textbox.Size = new System.Drawing.Size(112, 26);
            this.vehicleYear_Textbox.TabIndex = 11;
            // 
            // type_Combobox
            // 
            this.type_Combobox.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.type_Combobox.FormattingEnabled = true;
            this.type_Combobox.Location = new System.Drawing.Point(699, 301);
            this.type_Combobox.Name = "type_Combobox";
            this.type_Combobox.Size = new System.Drawing.Size(112, 27);
            this.type_Combobox.TabIndex = 13;
            this.type_Combobox.SelectedIndexChanged += new System.EventHandler(this.type_Combobox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(33, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "התנתקות";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(415, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "עדכון רכבים";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // View_Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::group28_1.Properties.Resources.בדיקקק;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.type_Combobox);
            this.Controls.Add(this.kilometrage_Textbox);
            this.Controls.Add(this.vehicleYear_Textbox);
            this.Controls.Add(this.vehicleNumber_Textbox);
            this.Controls.Add(this.kilometrage);
            this.Controls.Add(this.vehicleYear);
            this.Controls.Add(this.type);
            this.Controls.Add(this.vehicleNumber);
            this.Controls.Add(this.Return_Button);
            this.Controls.Add(this.Delete_Vehicle_Button);
            this.Controls.Add(this.Update_Vehicle_Button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View_Vehicle";
            this.Text = "View_Vehicle";
            this.Load += new System.EventHandler(this.View_Vehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAD_28DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD28DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewallvehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sAD28DataSet1BindingSource;
        private SAD_28DataSet1 sAD_28DataSet1;
        private System.Windows.Forms.BindingSource viewallvehicleBindingSource;
        private SAD_28DataSet1TableAdapters.view_all_vehicleTableAdapter view_all_vehicleTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private SAD_28DataSet1TableAdapters.VehiclesTableAdapter vehiclesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vechicleYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn killometrageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Update_Vehicle_Button;
        private System.Windows.Forms.Button Delete_Vehicle_Button;
        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.Label kilometrage;
        private System.Windows.Forms.Label vehicleYear;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label vehicleNumber;
        private System.Windows.Forms.TextBox vehicleNumber_Textbox;
        private System.Windows.Forms.TextBox kilometrage_Textbox;
        private System.Windows.Forms.TextBox vehicleYear_Textbox;
        private System.Windows.Forms.ComboBox type_Combobox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}