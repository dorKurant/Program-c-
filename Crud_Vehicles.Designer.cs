namespace group28_1
{
    partial class Crud_Vehicles
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
            this.creat_Car = new System.Windows.Forms.Button();
            this.view_Vehicles = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.vehice_archive_button = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // creat_Car
            // 
            this.creat_Car.BackColor = System.Drawing.SystemColors.Control;
            this.creat_Car.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.creat_Car.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.creat_Car.Location = new System.Drawing.Point(685, 211);
            this.creat_Car.Name = "creat_Car";
            this.creat_Car.Size = new System.Drawing.Size(205, 83);
            this.creat_Car.TabIndex = 1;
            this.creat_Car.Text = "יצירת רכב חדש";
            this.creat_Car.UseVisualStyleBackColor = true;
            this.creat_Car.UseWaitCursor = true;
            this.creat_Car.Click += new System.EventHandler(this.creat_Car_Click);
            // 
            // view_Vehicles
            // 
            this.view_Vehicles.BackColor = System.Drawing.SystemColors.Control;
            this.view_Vehicles.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.view_Vehicles.Location = new System.Drawing.Point(685, 331);
            this.view_Vehicles.Name = "view_Vehicles";
            this.view_Vehicles.Size = new System.Drawing.Size(205, 83);
            this.view_Vehicles.TabIndex = 2;
            this.view_Vehicles.Text = "צפיה ברכבים קיימים";
            this.view_Vehicles.UseVisualStyleBackColor = true;
            this.view_Vehicles.UseWaitCursor = true;
            this.view_Vehicles.Click += new System.EventHandler(this.view_Vehicles_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.Control;
            this.back.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.back.Location = new System.Drawing.Point(46, 608);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(110, 38);
            this.back.TabIndex = 3;
            this.back.Text = "חזרה";
            this.back.UseVisualStyleBackColor = true;
            this.back.UseWaitCursor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.Control;
            this.exit.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.exit.Location = new System.Drawing.Point(43, 676);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(113, 38);
            this.exit.TabIndex = 4;
            this.exit.Text = "התנתקות";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.UseWaitCursor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // vehice_archive_button
            // 
            this.vehice_archive_button.BackColor = System.Drawing.SystemColors.Control;
            this.vehice_archive_button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.vehice_archive_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.vehice_archive_button.Location = new System.Drawing.Point(685, 445);
            this.vehice_archive_button.Name = "vehice_archive_button";
            this.vehice_archive_button.Size = new System.Drawing.Size(205, 83);
            this.vehice_archive_button.TabIndex = 6;
            this.vehice_archive_button.Text = "ארכיון רכבים";
            this.vehice_archive_button.UseVisualStyleBackColor = true;
            this.vehice_archive_button.UseWaitCursor = true;
            this.vehice_archive_button.Click += new System.EventHandler(this.vehice_archive_button_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(390, 75);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(180, 36);
            this.header.TabIndex = 7;
            this.header.Text = "ניהול רכבים";
            // 
            // Crud_Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::group28_1.Properties.Resources.בדיקקק;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.header);
            this.Controls.Add(this.vehice_archive_button);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.back);
            this.Controls.Add(this.view_Vehicles);
            this.Controls.Add(this.creat_Car);
            this.Name = "Crud_Vehicles";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button creat_Car;
        private System.Windows.Forms.Button view_Vehicles;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button vehice_archive_button;
        private System.Windows.Forms.Label header;
    }
}