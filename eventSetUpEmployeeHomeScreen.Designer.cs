namespace group28_1
{
    partial class eventSetUpEmployeeHomeScreen
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
            this.AssignButton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(737, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = ",ברוך הבא";
            // 
            // AssignButton
            // 
            this.AssignButton.BackColor = System.Drawing.SystemColors.Control;
            this.AssignButton.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AssignButton.Location = new System.Drawing.Point(662, 225);
            this.AssignButton.Name = "AssignButton";
            this.AssignButton.Size = new System.Drawing.Size(243, 68);
            this.AssignButton.TabIndex = 2;
            this.AssignButton.Text = "לצפייה באירועים";
            this.AssignButton.UseVisualStyleBackColor = true;
            this.AssignButton.UseWaitCursor = true;
            this.AssignButton.Click += new System.EventHandler(this.AssignButton_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.Control;
            this.exit.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.exit.Location = new System.Drawing.Point(46, 672);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(120, 42);
            this.exit.TabIndex = 3;
            this.exit.Text = "התנתקות";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.UseWaitCursor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(731, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 27);
            this.label3.TabIndex = 5;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // eventSetUpEmployeeHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::group28_1.Properties.Resources.בדיקקק;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.AssignButton);
            this.Controls.Add(this.label1);
            this.Name = "eventSetUpEmployeeHomeScreen";
            this.Text = "eventSetUpEmployee";
            this.Load += new System.EventHandler(this.eventSetUpEmployeeHomeScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AssignButton;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label3;
    }
}