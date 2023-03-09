namespace group28_1
{
    partial class Create_Vehicle
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
            this.vehicle_Number = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.Craete_hedline = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.vehicle_Type = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.Label();
            this.vehicle_Year = new System.Windows.Forms.TextBox();
            this.km = new System.Windows.Forms.Label();
            this.km_Vehicle = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.sing_Out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vehicle_Number
            // 
            this.vehicle_Number.AutoSize = true;
            this.vehicle_Number.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.vehicle_Number.Location = new System.Drawing.Point(818, 254);
            this.vehicle_Number.Name = "vehicle_Number";
            this.vehicle_Number.Size = new System.Drawing.Size(120, 19);
            this.vehicle_Number.TabIndex = 1;
            this.vehicle_Number.Text = "הכנס מספר רכב";
            this.vehicle_Number.Click += new System.EventHandler(this.label1_Click);
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.number.Location = new System.Drawing.Point(572, 243);
            this.number.Multiline = true;
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(175, 30);
            this.number.TabIndex = 2;
            this.number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // Craete_hedline
            // 
            this.Craete_hedline.AutoSize = true;
            this.Craete_hedline.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Craete_hedline.Location = new System.Drawing.Point(451, 60);
            this.Craete_hedline.Name = "Craete_hedline";
            this.Craete_hedline.Size = new System.Drawing.Size(145, 36);
            this.Craete_hedline.TabIndex = 3;
            this.Craete_hedline.Text = "הוסף רכב";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.type.Location = new System.Drawing.Point(833, 294);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(104, 19);
            this.type.TabIndex = 4;
            this.type.Text = "הכנס סוג רכב";
            // 
            // vehicle_Type
            // 
            this.vehicle_Type.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.vehicle_Type.FormattingEnabled = true;
            this.vehicle_Type.Location = new System.Drawing.Point(572, 294);
            this.vehicle_Type.Name = "vehicle_Type";
            this.vehicle_Type.Size = new System.Drawing.Size(175, 27);
            this.vehicle_Type.TabIndex = 5;
            this.vehicle_Type.SelectedIndexChanged += new System.EventHandler(this.vehicle_Type_SelectedIndexChanged);
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.year.Location = new System.Drawing.Point(824, 342);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(113, 19);
            this.year.TabIndex = 6;
            this.year.Text = "הכנס שנת יצור";
            // 
            // vehicle_Year
            // 
            this.vehicle_Year.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.vehicle_Year.Location = new System.Drawing.Point(572, 336);
            this.vehicle_Year.Multiline = true;
            this.vehicle_Year.Name = "vehicle_Year";
            this.vehicle_Year.Size = new System.Drawing.Size(175, 25);
            this.vehicle_Year.TabIndex = 7;
            this.vehicle_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vehicle_Year.TextChanged += new System.EventHandler(this.vehicle_Year_TextChanged);
            // 
            // km
            // 
            this.km.AutoSize = true;
            this.km.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.km.Location = new System.Drawing.Point(816, 388);
            this.km.Name = "km";
            this.km.Size = new System.Drawing.Size(119, 19);
            this.km.TabIndex = 8;
            this.km.Text = "הכנס קילומטרז";
            // 
            // km_Vehicle
            // 
            this.km_Vehicle.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.km_Vehicle.Location = new System.Drawing.Point(572, 382);
            this.km_Vehicle.Multiline = true;
            this.km_Vehicle.Name = "km_Vehicle";
            this.km_Vehicle.Size = new System.Drawing.Size(175, 25);
            this.km_Vehicle.TabIndex = 9;
            this.km_Vehicle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.km_Vehicle.TextChanged += new System.EventHandler(this.km_Vehicle_TextChanged);
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.SystemColors.Control;
            this.Create.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Create.Location = new System.Drawing.Point(600, 442);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(127, 54);
            this.Create.TabIndex = 10;
            this.Create.Text = "הוסף רכב";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.UseWaitCursor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.Control;
            this.back.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.back.Location = new System.Drawing.Point(41, 618);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(104, 39);
            this.back.TabIndex = 11;
            this.back.Text = "חזרה";
            this.back.UseVisualStyleBackColor = true;
            this.back.UseWaitCursor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // sing_Out
            // 
            this.sing_Out.BackColor = System.Drawing.SystemColors.Control;
            this.sing_Out.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sing_Out.Location = new System.Drawing.Point(41, 674);
            this.sing_Out.Name = "sing_Out";
            this.sing_Out.Size = new System.Drawing.Size(104, 39);
            this.sing_Out.TabIndex = 12;
            this.sing_Out.Text = "התנתקות";
            this.sing_Out.UseVisualStyleBackColor = true;
            this.sing_Out.UseWaitCursor = true;
            this.sing_Out.Click += new System.EventHandler(this.sing_Out_Click);
            // 
            // Create_Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::group28_1.Properties.Resources.בדיקקק;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.sing_Out);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.km_Vehicle);
            this.Controls.Add(this.km);
            this.Controls.Add(this.vehicle_Year);
            this.Controls.Add(this.year);
            this.Controls.Add(this.vehicle_Type);
            this.Controls.Add(this.type);
            this.Controls.Add(this.Craete_hedline);
            this.Controls.Add(this.number);
            this.Controls.Add(this.vehicle_Number);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Create_Vehicle";
            this.Text = "Create_Vehicle";
            this.Load += new System.EventHandler(this.Create_Vehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label vehicle_Number;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label Craete_hedline;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.ComboBox vehicle_Type;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.TextBox vehicle_Year;
        private System.Windows.Forms.Label km;
        private System.Windows.Forms.TextBox km_Vehicle;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button sing_Out;
    }
}