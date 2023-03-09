namespace group28_1
{
    partial class Create_Bid
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.header_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerID_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.customerEmail = new System.Windows.Forms.Label();
            this.customerPhone = new System.Windows.Forms.Label();
            this.eventID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eventType = new System.Windows.Forms.Label();
            this.eventDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.sing_Out = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.bidID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Button();
            this.totalPrice = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.newBid = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.desingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount_ten = new System.Windows.Forms.Button();
            this.discount_seven = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.update_Status = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // header_label
            // 
            this.header_label.AutoSize = true;
            this.header_label.Font = new System.Drawing.Font("David", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_label.Location = new System.Drawing.Point(353, 49);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(341, 47);
            this.header_label.TabIndex = 0;
            this.header_label.Text = "הצעת מחיר חדשה";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.BackColor = System.Drawing.Color.LightGray;
            this.date_label.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.Location = new System.Drawing.Point(882, 197);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(59, 23);
            this.date_label.TabIndex = 1;
            this.date_label.Text = ":תאריך";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.LightGray;
            this.date.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(625, 192);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(69, 23);
            this.date.TabIndex = 2;
            this.date.Text = "(תאריך)";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(839, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = ":הזן ת\"ז לקוח";
            // 
            // customerID_Textbox
            // 
            this.customerID_Textbox.Location = new System.Drawing.Point(620, 243);
            this.customerID_Textbox.Name = "customerID_Textbox";
            this.customerID_Textbox.Size = new System.Drawing.Size(148, 20);
            this.customerID_Textbox.TabIndex = 4;
            this.customerID_Textbox.TextChanged += new System.EventHandler(this.customerID_Textbox_TextChanged);
            this.customerID_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.customerID_Textbox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(855, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = ":שם הלקוח";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(898, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = ":מייל";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(886, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = ":טלפון";
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.BackColor = System.Drawing.Color.LightGray;
            this.customerName.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.Location = new System.Drawing.Point(625, 283);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(69, 23);
            this.customerName.TabIndex = 8;
            this.customerName.Text = "(תאריך)";
            // 
            // customerEmail
            // 
            this.customerEmail.AutoSize = true;
            this.customerEmail.BackColor = System.Drawing.Color.LightGray;
            this.customerEmail.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerEmail.Location = new System.Drawing.Point(625, 328);
            this.customerEmail.Name = "customerEmail";
            this.customerEmail.Size = new System.Drawing.Size(69, 23);
            this.customerEmail.TabIndex = 9;
            this.customerEmail.Text = "(תאריך)";
            // 
            // customerPhone
            // 
            this.customerPhone.AutoSize = true;
            this.customerPhone.BackColor = System.Drawing.Color.LightGray;
            this.customerPhone.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPhone.Location = new System.Drawing.Point(625, 363);
            this.customerPhone.Name = "customerPhone";
            this.customerPhone.Size = new System.Drawing.Size(69, 23);
            this.customerPhone.TabIndex = 10;
            this.customerPhone.Text = "(תאריך)";
            // 
            // eventID
            // 
            this.eventID.Location = new System.Drawing.Point(620, 408);
            this.eventID.Name = "eventID";
            this.eventID.Size = new System.Drawing.Size(148, 20);
            this.eventID.TabIndex = 12;
            this.eventID.TextChanged += new System.EventHandler(this.eventID_TextChanged);
            this.eventID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eventID_KeyDown_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(822, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = ":הזן מזהה אירוע";
            // 
            // eventType
            // 
            this.eventType.AutoSize = true;
            this.eventType.BackColor = System.Drawing.Color.LightGray;
            this.eventType.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventType.Location = new System.Drawing.Point(625, 442);
            this.eventType.Name = "eventType";
            this.eventType.Size = new System.Drawing.Size(69, 23);
            this.eventType.TabIndex = 16;
            this.eventType.Text = "(תאריך)";
            this.eventType.Click += new System.EventHandler(this.eventType_Click);
            // 
            // eventDate
            // 
            this.eventDate.AutoSize = true;
            this.eventDate.BackColor = System.Drawing.Color.LightGray;
            this.eventDate.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDate.Location = new System.Drawing.Point(625, 487);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(69, 23);
            this.eventDate.TabIndex = 15;
            this.eventDate.Text = "(תאריך)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightGray;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(830, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = ":תאריך האירוע";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightGray;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(851, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = ":סוג האירוע";
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.create.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.create.Location = new System.Drawing.Point(802, 540);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(139, 58);
            this.create.TabIndex = 17;
            this.create.Text = "חישוב הצעת המחיר";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // sing_Out
            // 
            this.sing_Out.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sing_Out.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sing_Out.Location = new System.Drawing.Point(25, 657);
            this.sing_Out.Name = "sing_Out";
            this.sing_Out.Size = new System.Drawing.Size(104, 39);
            this.sing_Out.TabIndex = 19;
            this.sing_Out.Text = "התנתקות";
            this.sing_Out.UseVisualStyleBackColor = false;
            this.sing_Out.Click += new System.EventHandler(this.sing_Out_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.back.Location = new System.Drawing.Point(160, 657);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(104, 39);
            this.back.TabIndex = 18;
            this.back.Text = "חזור";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // bidID
            // 
            this.bidID.Location = new System.Drawing.Point(620, 152);
            this.bidID.Name = "bidID";
            this.bidID.Size = new System.Drawing.Size(148, 20);
            this.bidID.TabIndex = 21;
            this.bidID.TextChanged += new System.EventHandler(this.bidID_TextChanged);
            this.bidID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bidID_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(781, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = ":הזן מזהה הצעת מחיר";
            // 
            // discount
            // 
            this.discount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.discount.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.discount.Location = new System.Drawing.Point(25, 511);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(110, 67);
            this.discount.TabIndex = 22;
            this.discount.Text = "מתן 5% הנחה";
            this.discount.UseVisualStyleBackColor = false;
            this.discount.Click += new System.EventHandler(this.discount_Click);
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(340, 442);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(69, 23);
            this.totalPrice.TabIndex = 24;
            this.totalPrice.Text = "(תאריך)";
            this.totalPrice.Click += new System.EventHandler(this.totalPrice_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(456, 442);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(85, 23);
            this.priceLabel.TabIndex = 23;
            this.priceLabel.Text = ":מחיר כולל";
            // 
            // newBid
            // 
            this.newBid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newBid.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.newBid.Location = new System.Drawing.Point(620, 540);
            this.newBid.Name = "newBid";
            this.newBid.Size = new System.Drawing.Size(139, 58);
            this.newBid.TabIndex = 25;
            this.newBid.Text = "הוספת הצעת המחיר";
            this.newBid.UseVisualStyleBackColor = false;
            this.newBid.Click += new System.EventHandler(this.newBid_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desingID,
            this.desingPrice});
            this.dataGridView1.Location = new System.Drawing.Point(285, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(268, 290);
            this.dataGridView1.TabIndex = 38;
            // 
            // desingID
            // 
            this.desingID.HeaderText = "Desing ID";
            this.desingID.Name = "desingID";
            // 
            // desingPrice
            // 
            this.desingPrice.HeaderText = "Price";
            this.desingPrice.Name = "desingPrice";
            // 
            // discount_ten
            // 
            this.discount_ten.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.discount_ten.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.discount_ten.Location = new System.Drawing.Point(25, 345);
            this.discount_ten.Name = "discount_ten";
            this.discount_ten.Size = new System.Drawing.Size(110, 63);
            this.discount_ten.TabIndex = 39;
            this.discount_ten.Text = "מתן 10% הנחה";
            this.discount_ten.UseVisualStyleBackColor = false;
            this.discount_ten.Click += new System.EventHandler(this.discount_ten_Click);
            // 
            // discount_seven
            // 
            this.discount_seven.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.discount_seven.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.discount_seven.Location = new System.Drawing.Point(25, 422);
            this.discount_seven.Name = "discount_seven";
            this.discount_seven.Size = new System.Drawing.Size(110, 63);
            this.discount_seven.TabIndex = 40;
            this.discount_seven.Text = "מתן 7.5% הנחה";
            this.discount_seven.UseVisualStyleBackColor = false;
            this.discount_seven.Click += new System.EventHandler(this.discount_seven_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 58);
            this.button1.TabIndex = 41;
            this.button1.Text = "PDF ייצוא ל";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // update_Status
            // 
            this.update_Status.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_Status.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.update_Status.Location = new System.Drawing.Point(12, 93);
            this.update_Status.Name = "update_Status";
            this.update_Status.Size = new System.Drawing.Size(139, 58);
            this.update_Status.TabIndex = 42;
            this.update_Status.Text = "עדכן סטטוס הצעת מחיר ";
            this.update_Status.UseVisualStyleBackColor = false;
            this.update_Status.Click += new System.EventHandler(this.update_Status_Click);
            // 
            // Create_Bid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::group28_1.Properties.Resources.בדיקקק;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.update_Status);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.discount_seven);
            this.Controls.Add(this.discount_ten);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.newBid);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.bidID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sing_Out);
            this.Controls.Add(this.back);
            this.Controls.Add(this.create);
            this.Controls.Add(this.eventType);
            this.Controls.Add(this.eventDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.eventID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customerPhone);
            this.Controls.Add(this.customerEmail);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerID_Textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.header_label);
            this.Name = "Create_Bid";
            this.Text = "Create_Bid";
            this.Load += new System.EventHandler(this.Create_Bid_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Create_Bid_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label header_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerID_Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label customerEmail;
        private System.Windows.Forms.Label customerPhone;
        private System.Windows.Forms.TextBox eventID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label eventType;
        private System.Windows.Forms.Label eventDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button sing_Out;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox bidID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button discount;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button newBid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn desingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn desingPrice;
        private System.Windows.Forms.Button discount_ten;
        private System.Windows.Forms.Button discount_seven;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button update_Status;
    }
}