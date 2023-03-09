namespace group28_1
{
    partial class Create_New_Event
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
            this.id = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.typeEvent = new System.Windows.Forms.ComboBox();
            this.guests = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DoubleTable = new System.Windows.Forms.TextBox();
            this.TripleTable = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numberOfTableInEvent = new System.Windows.Forms.Label();
            this.calculateNumOfTablesInEvent = new System.Windows.Forms.Button();
            this.NumberOfTables = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Design_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productType = new System.Windows.Forms.ComboBox();
            this.productAmount = new System.Windows.Forms.Label();
            this.productsAmount = new System.Windows.Forms.TextBox();
            this.addProduct = new System.Windows.Forms.Button();
            this.createEvent = new System.Windows.Forms.Button();
            this.Designs = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.Label();
            this.currentPrice = new System.Windows.Forms.Label();
            this.createNewEvent = new System.Windows.Forms.Button();
            this.numbersOfEmployees = new System.Windows.Forms.Label();
            this.CalculateNumbersOfEmployees = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numberOfTableForDesign = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numOfTablesNow = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.deleteProductFromDesign = new System.Windows.Forms.Button();
            this.delete_design = new System.Windows.Forms.Button();
            this.bidScreen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Designs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(734, 128);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 13);
            this.id.TabIndex = 0;
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(830, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "תאריך האירוע";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(852, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "מס אירוע";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.type.Location = new System.Drawing.Point(856, 218);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(62, 15);
            this.type.TabIndex = 5;
            this.type.Text = "סוג אירוע";
            // 
            // typeEvent
            // 
            this.typeEvent.FormattingEnabled = true;
            this.typeEvent.Location = new System.Drawing.Point(656, 218);
            this.typeEvent.Name = "typeEvent";
            this.typeEvent.Size = new System.Drawing.Size(100, 21);
            this.typeEvent.TabIndex = 6;
            this.typeEvent.SelectedIndexChanged += new System.EventHandler(this.typeEvent_SelectedIndexChanged);
            // 
            // guests
            // 
            this.guests.Location = new System.Drawing.Point(656, 269);
            this.guests.Name = "guests";
            this.guests.Size = new System.Drawing.Size(100, 20);
            this.guests.TabIndex = 7;
            this.guests.Text = "0";
            this.guests.TextChanged += new System.EventHandler(this.guests_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(835, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "כמות אורחים";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(781, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "שולחנות אבירים זוגיים";
            // 
            // DoubleTable
            // 
            this.DoubleTable.Location = new System.Drawing.Point(656, 308);
            this.DoubleTable.Name = "DoubleTable";
            this.DoubleTable.Size = new System.Drawing.Size(100, 20);
            this.DoubleTable.TabIndex = 10;
            this.DoubleTable.Text = "0";
            this.DoubleTable.TextChanged += new System.EventHandler(this.DoubleTable_TextChanged);
            // 
            // TripleTable
            // 
            this.TripleTable.Location = new System.Drawing.Point(656, 348);
            this.TripleTable.Name = "TripleTable";
            this.TripleTable.Size = new System.Drawing.Size(100, 20);
            this.TripleTable.TabIndex = 11;
            this.TripleTable.Text = "0";
            this.TripleTable.TextChanged += new System.EventHandler(this.TripleTable_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(762, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "שולחנות אבירים משולשים";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(814, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "שולחנות לעיצוב";
            // 
            // numberOfTableInEvent
            // 
            this.numberOfTableInEvent.AutoSize = true;
            this.numberOfTableInEvent.Location = new System.Drawing.Point(696, 392);
            this.numberOfTableInEvent.Name = "numberOfTableInEvent";
            this.numberOfTableInEvent.Size = new System.Drawing.Size(0, 13);
            this.numberOfTableInEvent.TabIndex = 16;
            this.numberOfTableInEvent.Click += new System.EventHandler(this.numberOfTableInEvent_Click);
            // 
            // calculateNumOfTablesInEvent
            // 
            this.calculateNumOfTablesInEvent.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.calculateNumOfTablesInEvent.Location = new System.Drawing.Point(777, 392);
            this.calculateNumOfTablesInEvent.Name = "calculateNumOfTablesInEvent";
            this.calculateNumOfTablesInEvent.Size = new System.Drawing.Size(130, 23);
            this.calculateNumOfTablesInEvent.TabIndex = 17;
            this.calculateNumOfTablesInEvent.Text = "חשב מספר שולחנות";
            this.calculateNumOfTablesInEvent.UseVisualStyleBackColor = true;
            this.calculateNumOfTablesInEvent.Click += new System.EventHandler(this.calculateNumOfTablesInEvent_Click);
            // 
            // NumberOfTables
            // 
            this.NumberOfTables.Location = new System.Drawing.Point(656, 428);
            this.NumberOfTables.Name = "NumberOfTables";
            this.NumberOfTables.Size = new System.Drawing.Size(100, 20);
            this.NumberOfTables.TabIndex = 18;
            this.NumberOfTables.TextChanged += new System.EventHandler(this.NumberOfTables_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(370, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "בחר מוצר";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventType,
            this.Design_Amount,
            this.price});
            this.dataGridView1.Location = new System.Drawing.Point(98, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(328, 101);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // eventType
            // 
            this.eventType.HeaderText = "סוג עיצוב";
            this.eventType.Name = "eventType";
            // 
            // Design_Amount
            // 
            this.Design_Amount.HeaderText = "כמות";
            this.Design_Amount.Name = "Design_Amount";
            // 
            // price
            // 
            this.price.HeaderText = "מחיר";
            this.price.Name = "price";
            // 
            // productType
            // 
            this.productType.FormattingEnabled = true;
            this.productType.Location = new System.Drawing.Point(247, 123);
            this.productType.Name = "productType";
            this.productType.Size = new System.Drawing.Size(100, 21);
            this.productType.TabIndex = 21;
            this.productType.SelectedIndexChanged += new System.EventHandler(this.productType_SelectedIndexChanged);
            // 
            // productAmount
            // 
            this.productAmount.AutoSize = true;
            this.productAmount.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.productAmount.Location = new System.Drawing.Point(389, 156);
            this.productAmount.Name = "productAmount";
            this.productAmount.Size = new System.Drawing.Size(37, 15);
            this.productAmount.TabIndex = 22;
            this.productAmount.Text = "כמות";
            // 
            // productsAmount
            // 
            this.productsAmount.Location = new System.Drawing.Point(247, 156);
            this.productsAmount.Name = "productsAmount";
            this.productsAmount.Size = new System.Drawing.Size(100, 20);
            this.productsAmount.TabIndex = 23;
            this.productsAmount.TextChanged += new System.EventHandler(this.productsAmount_TextChanged);
            // 
            // addProduct
            // 
            this.addProduct.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addProduct.Location = new System.Drawing.Point(128, 135);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(75, 23);
            this.addProduct.TabIndex = 24;
            this.addProduct.Text = "הוסף";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // createEvent
            // 
            this.createEvent.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.createEvent.Location = new System.Drawing.Point(180, 361);
            this.createEvent.Name = "createEvent";
            this.createEvent.Size = new System.Drawing.Size(157, 23);
            this.createEvent.TabIndex = 25;
            this.createEvent.Text = "הוסף עיצוב חדש";
            this.createEvent.UseVisualStyleBackColor = true;
            this.createEvent.Click += new System.EventHandler(this.createEvent_Click);
            // 
            // Designs
            // 
            this.Designs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Designs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.count,
            this.cost,
            this.Column3});
            this.Designs.Location = new System.Drawing.Point(99, 390);
            this.Designs.Name = "Designs";
            this.Designs.Size = new System.Drawing.Size(331, 113);
            this.Designs.TabIndex = 26;
            this.Designs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Designs_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "מספר עיצוב";
            this.Column1.Name = "Column1";
            this.Column1.Width = 95;
            // 
            // count
            // 
            this.count.HeaderText = "כמות";
            this.count.Name = "count";
            this.count.Width = 50;
            // 
            // cost
            // 
            this.cost.HeaderText = "עלות";
            this.cost.Name = "cost";
            this.cost.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "רשימת עיצוב";
            this.Column3.Name = "Column3";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.totalPrice.Location = new System.Drawing.Point(361, 542);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(65, 15);
            this.totalPrice.TabIndex = 27;
            this.totalPrice.Text = "מחיר כרגע";
            // 
            // currentPrice
            // 
            this.currentPrice.AutoSize = true;
            this.currentPrice.Location = new System.Drawing.Point(310, 544);
            this.currentPrice.Name = "currentPrice";
            this.currentPrice.Size = new System.Drawing.Size(0, 13);
            this.currentPrice.TabIndex = 28;
            this.currentPrice.Click += new System.EventHandler(this.currentPrice_Click);
            // 
            // createNewEvent
            // 
            this.createNewEvent.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.createNewEvent.Location = new System.Drawing.Point(554, 589);
            this.createNewEvent.Name = "createNewEvent";
            this.createNewEvent.Size = new System.Drawing.Size(75, 23);
            this.createNewEvent.TabIndex = 29;
            this.createNewEvent.Text = "צור אירוע";
            this.createNewEvent.UseVisualStyleBackColor = true;
            this.createNewEvent.Click += new System.EventHandler(this.createNewEvent_Click);
            // 
            // numbersOfEmployees
            // 
            this.numbersOfEmployees.AutoSize = true;
            this.numbersOfEmployees.Location = new System.Drawing.Point(715, 486);
            this.numbersOfEmployees.Name = "numbersOfEmployees";
            this.numbersOfEmployees.Size = new System.Drawing.Size(0, 13);
            this.numbersOfEmployees.TabIndex = 31;
            this.numbersOfEmployees.Click += new System.EventHandler(this.numbersOfEmployees_Click);
            // 
            // CalculateNumbersOfEmployees
            // 
            this.CalculateNumbersOfEmployees.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CalculateNumbersOfEmployees.Location = new System.Drawing.Point(781, 481);
            this.CalculateNumbersOfEmployees.Name = "CalculateNumbersOfEmployees";
            this.CalculateNumbersOfEmployees.Size = new System.Drawing.Size(130, 23);
            this.CalculateNumbersOfEmployees.TabIndex = 32;
            this.CalculateNumbersOfEmployees.Text = "חשב מספר עובדים";
            this.CalculateNumbersOfEmployees.UseVisualStyleBackColor = true;
            this.CalculateNumbersOfEmployees.Click += new System.EventHandler(this.CalculateNumbersOfEmployees_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(296, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "מספר שולחנות לעיצוב";
            // 
            // numberOfTableForDesign
            // 
            this.numberOfTableForDesign.Location = new System.Drawing.Point(129, 324);
            this.numberOfTableForDesign.Name = "numberOfTableForDesign";
            this.numberOfTableForDesign.Size = new System.Drawing.Size(100, 20);
            this.numberOfTableForDesign.TabIndex = 34;
            this.numberOfTableForDesign.TextChanged += new System.EventHandler(this.numberOfTableForDesign_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(285, 572);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 15);
            this.label10.TabIndex = 35;
            this.label10.Text = "מספר שולחנות מעוצבים ";
            // 
            // numOfTablesNow
            // 
            this.numOfTablesNow.AutoSize = true;
            this.numOfTablesNow.Location = new System.Drawing.Point(212, 574);
            this.numOfTablesNow.Name = "numOfTablesNow";
            this.numOfTablesNow.Size = new System.Drawing.Size(0, 13);
            this.numOfTablesNow.TabIndex = 36;
            this.numOfTablesNow.Click += new System.EventHandler(this.numOfTablesNow_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(609, 162);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 1, 5, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 37;
            this.dateTimePicker1.Value = new System.DateTime(2023, 1, 6, 11, 52, 58, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // deleteProductFromDesign
            // 
            this.deleteProductFromDesign.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.deleteProductFromDesign.Location = new System.Drawing.Point(316, 292);
            this.deleteProductFromDesign.Name = "deleteProductFromDesign";
            this.deleteProductFromDesign.Size = new System.Drawing.Size(113, 21);
            this.deleteProductFromDesign.TabIndex = 38;
            this.deleteProductFromDesign.Text = "מחק מוצר מעיצוב";
            this.deleteProductFromDesign.UseVisualStyleBackColor = true;
            this.deleteProductFromDesign.Click += new System.EventHandler(this.deleteProductFromDesign_Click);
            // 
            // delete_design
            // 
            this.delete_design.Location = new System.Drawing.Point(351, 509);
            this.delete_design.Name = "delete_design";
            this.delete_design.Size = new System.Drawing.Size(75, 23);
            this.delete_design.TabIndex = 39;
            this.delete_design.Text = "מחק עיצוב";
            this.delete_design.UseVisualStyleBackColor = true;
            this.delete_design.Click += new System.EventHandler(this.delete_design_Click);
            // 
            // bidScreen
            // 
            this.bidScreen.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bidScreen.Location = new System.Drawing.Point(791, 589);
            this.bidScreen.Name = "bidScreen";
            this.bidScreen.Size = new System.Drawing.Size(116, 23);
            this.bidScreen.TabIndex = 40;
            this.bidScreen.Text = "עבור להצעת מחיר";
            this.bidScreen.UseVisualStyleBackColor = true;
            this.bidScreen.Click += new System.EventHandler(this.bidScreen_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button2.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(45, 682);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 36);
            this.button2.TabIndex = 42;
            this.button2.Text = "התנתקות";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(45, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 35);
            this.button1.TabIndex = 41;
            this.button1.Text = "חזרה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("David", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(436, 36);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(162, 36);
            this.header.TabIndex = 43;
            this.header.Text = "אירוע חדש";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(group28_1.Product);
            // 
            // Create_New_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::group28_1.Properties.Resources.בדיקקק;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.header);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bidScreen);
            this.Controls.Add(this.delete_design);
            this.Controls.Add(this.deleteProductFromDesign);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numOfTablesNow);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numberOfTableForDesign);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CalculateNumbersOfEmployees);
            this.Controls.Add(this.numbersOfEmployees);
            this.Controls.Add(this.createNewEvent);
            this.Controls.Add(this.currentPrice);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.Designs);
            this.Controls.Add(this.createEvent);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.productsAmount);
            this.Controls.Add(this.productAmount);
            this.Controls.Add(this.productType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NumberOfTables);
            this.Controls.Add(this.calculateNumOfTablesInEvent);
            this.Controls.Add(this.numberOfTableInEvent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TripleTable);
            this.Controls.Add(this.DoubleTable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guests);
            this.Controls.Add(this.typeEvent);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Name = "Create_New_Event";
            this.Text = "Create_New_Event";
            this.Load += new System.EventHandler(this.Create_New_Event_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Designs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.ComboBox typeEvent;
        private System.Windows.Forms.TextBox guests;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DoubleTable;
        private System.Windows.Forms.TextBox TripleTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label numberOfTableInEvent;
        private System.Windows.Forms.Button calculateNumOfTablesInEvent;
        private System.Windows.Forms.TextBox NumberOfTables;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Design_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.ComboBox productType;
        private System.Windows.Forms.Label productAmount;
        private System.Windows.Forms.TextBox productsAmount;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button createEvent;
        private System.Windows.Forms.DataGridView Designs;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label currentPrice;
        private System.Windows.Forms.Button createNewEvent;
        private System.Windows.Forms.Label numbersOfEmployees;
        private System.Windows.Forms.Button CalculateNumbersOfEmployees;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox numberOfTableForDesign;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label numOfTablesNow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button deleteProductFromDesign;
        private System.Windows.Forms.Button delete_design;
        private System.Windows.Forms.Button bidScreen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label header;
    }
}