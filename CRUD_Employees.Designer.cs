namespace group28_1
{
    partial class CRUD_Employees
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.return_button = new System.Windows.Forms.Button();
            this.archive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(702, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 88);
            this.button1.TabIndex = 1;
            this.button1.Text = "הוספת עובד חדש";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(702, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 88);
            this.button2.TabIndex = 2;
            this.button2.Text = "עדכון עובדים";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(427, 112);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(190, 36);
            this.header.TabIndex = 3;
            this.header.Text = "ניהול עובדים";
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.exit.Location = new System.Drawing.Point(50, 661);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(93, 39);
            this.exit.TabIndex = 17;
            this.exit.Text = "התנתקות";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // return_button
            // 
            this.return_button.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.return_button.Location = new System.Drawing.Point(50, 607);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(93, 39);
            this.return_button.TabIndex = 16;
            this.return_button.Text = "חזרה";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // archive
            // 
            this.archive.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.archive.Location = new System.Drawing.Point(702, 449);
            this.archive.Name = "archive";
            this.archive.Size = new System.Drawing.Size(198, 88);
            this.archive.TabIndex = 18;
            this.archive.Text = "ארכיון עובדים";
            this.archive.UseVisualStyleBackColor = true;
            this.archive.Click += new System.EventHandler(this.archive_Click);
            // 
            // CRUD_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::group28_1.Properties.Resources.בדיקקק;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.archive);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.header);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "CRUD_Employees";
            this.Text = "CRUD_Employees";
            this.Load += new System.EventHandler(this.CRUD_Employees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button archive;
    }
}