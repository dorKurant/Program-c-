namespace group28_1
{
    partial class EventDesignerScreen
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
            this.sign_ouy_button = new System.Windows.Forms.Button();
            this.create_event_button = new System.Windows.Forms.Button();
            this.customer_button = new System.Windows.Forms.Button();
            this.view_events_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.update_design = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(713, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = ",שלום מעצבת ";
            // 
            // sign_ouy_button
            // 
            this.sign_ouy_button.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sign_ouy_button.Location = new System.Drawing.Point(48, 672);
            this.sign_ouy_button.Name = "sign_ouy_button";
            this.sign_ouy_button.Size = new System.Drawing.Size(107, 32);
            this.sign_ouy_button.TabIndex = 1;
            this.sign_ouy_button.Text = "התנתקות";
            this.sign_ouy_button.UseVisualStyleBackColor = true;
            this.sign_ouy_button.Click += new System.EventHandler(this.sign_ouy_button_Click);
            // 
            // create_event_button
            // 
            this.create_event_button.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.create_event_button.Location = new System.Drawing.Point(809, 348);
            this.create_event_button.Name = "create_event_button";
            this.create_event_button.Size = new System.Drawing.Size(113, 66);
            this.create_event_button.TabIndex = 3;
            this.create_event_button.Text = "יצירת אירוע";
            this.create_event_button.UseVisualStyleBackColor = true;
            this.create_event_button.Click += new System.EventHandler(this.create_event_button_Click);
            // 
            // customer_button
            // 
            this.customer_button.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.customer_button.Location = new System.Drawing.Point(674, 348);
            this.customer_button.Name = "customer_button";
            this.customer_button.Size = new System.Drawing.Size(109, 66);
            this.customer_button.TabIndex = 4;
            this.customer_button.Text = "לקוחות";
            this.customer_button.UseVisualStyleBackColor = true;
            this.customer_button.Click += new System.EventHandler(this.customer_button_Click);
            // 
            // view_events_button
            // 
            this.view_events_button.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.view_events_button.Location = new System.Drawing.Point(538, 348);
            this.view_events_button.Name = "view_events_button";
            this.view_events_button.Size = new System.Drawing.Size(118, 66);
            this.view_events_button.TabIndex = 7;
            this.view_events_button.Text = "צפייה באירועים";
            this.view_events_button.UseVisualStyleBackColor = true;
            this.view_events_button.Click += new System.EventHandler(this.view_events_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(685, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "במה תרצי לבחור";
            // 
            // update_design
            // 
            this.update_design.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.update_design.Location = new System.Drawing.Point(809, 443);
            this.update_design.Name = "update_design";
            this.update_design.Size = new System.Drawing.Size(113, 66);
            this.update_design.TabIndex = 9;
            this.update_design.Text = "עידכון עיצובים";
            this.update_design.UseVisualStyleBackColor = true;
            this.update_design.Click += new System.EventHandler(this.update_design_Click);
            // 
            // EventDesignerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::group28_1.Properties.Resources.מסךמעצבת;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.update_design);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.view_events_button);
            this.Controls.Add(this.customer_button);
            this.Controls.Add(this.create_event_button);
            this.Controls.Add(this.sign_ouy_button);
            this.Controls.Add(this.label1);
            this.Name = "EventDesignerScreen";
            this.Text = "EventDesignerScreen";
            this.Load += new System.EventHandler(this.EventDesignerScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sign_ouy_button;
        private System.Windows.Forms.Button create_event_button;
        private System.Windows.Forms.Button customer_button;
        private System.Windows.Forms.Button view_events_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button update_design;
    }
}