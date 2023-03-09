using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;



namespace group28_1
{


    public partial class Create_New_Event : Form

    {
        //private List<Product> productsToDesign;
        private Dictionary<Product, int> productsToDesign;
        private Dictionary<Design, int> designToEvent;

        public Create_New_Event()
        {

            InitializeComponent();
            typeEvent.DataSource = Enum.GetValues(typeof(eventType));
            productType.DataSource = Enum.GetValues(typeof(productType));
            timer1.Start();
            productsToDesign = new Dictionary<Product, int>();
            designToEvent = new Dictionary<Design, int>();
            dateTimePicker1.MinDate = DateTime.Now;


        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            id.Text = getNewEventID();

        }

        private string getNewEventID()
        {
            List<Event> eve = new List<Event>();
            eve = Program.Events;
            int num = eve.Max(p => int.Parse(p.get_eventID()));
            string num1 = (num + 1).ToString();
            return num1;
        }

        private void TripleTable_TextChanged(object sender, EventArgs e)
        {
            {
                // Check if the text consists of only digits
                bool isNumber = true;
                foreach (char c in TripleTable.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        isNumber = false;
                        break;
                    }
                }

                // If the text is not a number, clear the text box
                if (!isNumber)
                {
                    TripleTable.Text = "";
                }
            }
        }

        private void guests_TextChanged(object sender, EventArgs e)
        {

            {
                // Check if the text consists of only digits
                bool isNumber = true;
                foreach (char c in guests.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        isNumber = false;
                        break;
                    }
                }

                // If the text is not a number, clear the text box
                if (!isNumber)
                {
                    guests.Text = "";
                }
            }
        }



        private void numberOfTableInEvent_Click(object sender, EventArgs e)
        {

        }

        private void Create_New_Event_Load(object sender, EventArgs e)
        {

        }

        private void calculateNumOfTablesInEvent_Click(object sender, EventArgs e)
        {
            if (guests.Text.ToString() == "" || DoubleTable.Text.ToString() == "" || TripleTable.Text.ToString() == "")
            {
                MessageBox.Show(" לא ניתן להשאיר שדות ריקים", "המשך", MessageBoxButtons.OK);

            }
            else
            {


                numberOfTableInEvent.Text = calculateNumberOfTable();

            }
        }
        private string calculateNumberOfTable()
        {
            int guests1 = int.Parse(guests.Text.ToString());
            int Twotables = int.Parse(DoubleTable.Text.ToString());
            int Threetable = int.Parse(TripleTable.Text.ToString());
            if (guests1 < 0 || Twotables < 0 || Threetable < 0)
            {
                MessageBox.Show(" הקלד מספר תקין", "המשך", MessageBoxButtons.OK);
                return "";
            }
            else
            {

                double tableToDesign = Math.Ceiling((guests1 - (Twotables * 18) - (Threetable * 24)) / 12.0) + Twotables + Threetable;
                if (tableToDesign < 0)
                {
                    MessageBox.Show("מספר השולחנות שחושב הוא שלילי. אנא שנה/י את הנתונים", "המשך", MessageBoxButtons.OK);
                    return "";
                }

                return tableToDesign.ToString();
            }
        }

        private void DoubleTable_TextChanged(object sender, EventArgs e)
        {
            {
                // Check if the text consists of only digits
                bool isNumber = true;
                foreach (char c in DoubleTable.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        isNumber = false;
                        break;
                    }
                }

                // If the text is not a number, clear the text box
                if (!isNumber)
                {
                    DoubleTable.Text = "";
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void typeEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DesignName.DataSource = Enum.GetValues(typeof(productType));

        }

        private void productType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            if (productsAmount.Text.ToString() == "")
            {
                MessageBox.Show(" לא ניתן להשאיר שדות ריקים", "המשך", MessageBoxButtons.OK);

            }
            else
            {

                Product x = Program.Products.FirstOrDefault(product => product.get_type().ToString() == productType.Text.ToString());
                int amount = int.Parse(productsAmount.Text.ToString());
                if (x.get_quantity() < amount)
                {
                    MessageBox.Show("קיימים רק" + " " + x.get_quantity() + " " + "יחידות מסוג זה ", "המשך", MessageBoxButtons.OK);

                }
                else if (productsToDesign.Keys.Contains(x))
                {
                    MessageBox.Show("מוצר זה כבר קיים בעיצוב", "המשך", MessageBoxButtons.OK);

                }
                else if (amount == 0)
                {
                    MessageBox.Show("לא ניתן להוסיף 0 יחידות", "המשך", MessageBoxButtons.OK);

                }

                else
                {
                    this.productsToDesign.Add(x, amount);
                    int price = int.Parse(x.get_price().ToString());
                    int totalPrice = amount * price;
                    dataGridView1.Rows.Add(productType.Text, productsAmount.Text, totalPrice);
                }
            }

        }
        private void deleteProductFromDesign_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentCell==null)
                MessageBox.Show("לא נבחר מוצר שרוצים למחוק", "", MessageBoxButtons.OK);
            else
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex; //the row we want to delete
                string nameTepDel = dataGridView1[0, rowIndex].Value.ToString();
                productType tepeDel = (productType)Enum.Parse(typeof(productType), nameTepDel);
                Product productDel = Program.Products.FirstOrDefault(product => product.get_type().ToString() == tepeDel.ToString());
                productsToDesign.Remove(productDel);
                dataGridView1.Rows.RemoveAt(rowIndex);//delete the row
            }
        }

        private void productsAmount_TextChanged(object sender, EventArgs e)
        {
            {
                // Check if the text consists of only digits
                bool isNumber = true;
                foreach (char c in productsAmount.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        isNumber = false;
                        break;
                    }
                }

                // If the text is not a number, clear the text box
                if (!isNumber)
                {
                    productsAmount.Text = "";
                }
            }
        }


        private void createEvent_Click(object sender, EventArgs e)
        {
            if (numberOfTableForDesign.Text.ToString() == "")
            {
                MessageBox.Show(" לא ניתן להשאיר שדות ריקים", "המשך", MessageBoxButtons.OK);

            }
            else
            {
                bool haveProblem = false; //we check that every time if we have all we need to continue
                                          //List<Event> eve = new List<Event>();
                                          //eve = Program.Events;
                                          //int num = eve.Max(p => int.Parse(p.get_eventID()));
                long newDesignID = Program.Designs.Max(p => p.get_DesignID());
                newDesignID++;
                //double sum = productsToDesign.Sum(p => p.get_price());
                int numberOfTable = int.Parse(numberOfTableForDesign.Text.ToString()); //how meny from every product
                double sum = productsToDesign.Sum((p => int.Parse(p.Key.get_price().ToString()) * p.Value)) * numberOfTable; //calculate the total value
                string names = string.Join(",", productsToDesign.Select(p => p.Key.get_type())); //create a name for the design 
                foreach (DataGridViewRow row in dataGridView1.Rows) //over all the row in the gridview and check if we have enuf product to specific table count
                {
                    if (row.Cells["eventType"].Value != null)
                    {
                        Product x = Program.Products.FirstOrDefault(p => p.get_type().ToString() == row.Cells["eventType"].Value.ToString());
                        int count = int.Parse(row.Cells["Design_Amount"].Value.ToString());
                        if (count * numberOfTable > x.get_quantity())
                        {
                            MessageBox.Show(x.get_type().ToString() + " " + "קיימים רק" + " " + x.get_quantity() + " " + "יחידות מסוג  ", "המשך", MessageBoxButtons.OK);
                            haveProblem = true;
                            this.productsToDesign.Remove(x); //remove the product from the list
                            dataGridView1.Rows.Remove(row);
                            break;
                        }
                    }
                }
                if (!haveProblem)//just if we dont have problem
                {
                    Design y = new Design(newDesignID, sum, true); //create new design 
                    y.add_list(productsToDesign); //add the spesific product to the list of whats design includ 
                    Designs.Rows.Add(newDesignID, numberOfTable, sum, names); //pint all the infurmation on the scrin 
                    designToEvent.Add(y, numberOfTable);
                    dataGridView1.Rows.Clear(); //clear the pruducts to design grid for the next design 
                    productsToDesign.Clear();// clear the list of product to design 
                    currentPrice.Text = sumTotalPrice().ToString();
                    numOfTablesNow.Text = sumTotalTable().ToString();//sum all the tables 
                }
            }
        }
        private void delete_design_Click(object sender, EventArgs e)
        {
            if (Designs.CurrentCell == null)
                MessageBox.Show("לא נבחר עיצוב שרוצים למחוק", "", MessageBoxButtons.OK);
            else
            {
                int rowIndex = Designs.CurrentCell.RowIndex; //the row we want to delete
                string nameDesDel = Designs[0, rowIndex].Value.ToString();
                long tepeDel = long.Parse(nameDesDel.ToString());
                currentPrice.Text = (int.Parse(currentPrice.Text.ToString()) - int.Parse(Designs[2, rowIndex].Value.ToString())).ToString();
                numOfTablesNow.Text = ((int.Parse(numOfTablesNow.Text.ToString())) - int.Parse(Designs[1, rowIndex].Value.ToString())).ToString();
                Design designDel = Program.Designs.FirstOrDefault(Design => Design.get_DesignID().ToString() == tepeDel.ToString());
                designToEvent.Remove(designDel);
                Designs.Rows.RemoveAt(rowIndex);//delete the row
                designDel.remove_Design();
                Designs.Rows.Clear();
            }
        }
        private double sumTotalTable()
        {
            double total = 0;
            foreach (DataGridViewRow row in Designs.Rows)
            {
                total += Convert.ToDouble(row.Cells["count"].Value);
            }
            return total;

        }
        private double sumTotalPrice()
        {
            double total = 0;
            foreach (DataGridViewRow row in Designs.Rows)
            {
                total += Convert.ToDouble(row.Cells["cost"].Value);
            }
            return total;
        }



        private void Designs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void currentPrice_Click(object sender, EventArgs e)
        {

        }

        private void NumberOfTables_TextChanged(object sender, EventArgs e)
        {
            {
                // Check if the text consists of only digits
                bool isNumber = true;
                foreach (char c in NumberOfTables.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        isNumber = false;
                        break;
                    }
                }

                // If the text is not a number, clear the text box
                if (!isNumber)
                {
                    NumberOfTables.Text = "";
                }
            }
        }

        private void numbersOfEmployees_Click(object sender, EventArgs e)
        {

        }

        private void CalculateNumbersOfEmployees_Click(object sender, EventArgs e)
        {
            if (NumberOfTables.Text.ToString() == "")
            {
                MessageBox.Show(" לא ניתן להשאיר שדות ריקים", "המשך", MessageBoxButtons.OK);

            }
            else
            {
                double numOfEmployees = Math.Round(double.Parse(NumberOfTables.Text.ToString()) / 10);
                numbersOfEmployees.Text = numOfEmployees.ToString();
            }
        }

        private void numberOfTableForDesign_TextChanged(object sender, EventArgs e)
        {
            {
                // Check if the text consists of only digits
                bool isNumber = true;
                foreach (char c in numberOfTableForDesign.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        isNumber = false;
                        break;
                    }
                }

                // If the text is not a number, clear the text box
                if (!isNumber)
                {
                    numberOfTableForDesign.Text = "";
                }
            }
        }

        private void createNewEvent_Click(object sender, EventArgs e)
        {
            if (id.Text.Length!=0 && numOfTablesNow.Text.Length!=0 && dateTimePicker1.Value != null && typeEvent.Text.Length!=0 && currentPrice.Text.Length!=0)
            {
                string eventID1 = id.Text.ToString();
                int numberOfEmployees = int.Parse(numOfTablesNow.Text.ToString());
                DateTime date1 = dateTimePicker1.Value;
                //DateTime date1 = DateTime.Parse(date.Text.ToString());
                eventType type = (eventType)typeEvent.SelectedItem;
                double grossprice = double.Parse(currentPrice.Text.ToString());
                Event a = new Event(eventID1, date1, numberOfEmployees, type, grossprice, true);
                a.add_list(designToEvent);
                Designs.Rows.Clear();
                dataGridView1.Rows.Clear();
                productsAmount.Clear();
                numberOfTableForDesign.Clear();
                NumberOfTables.Clear();
                TripleTable.Clear();
                DoubleTable.Clear();
                guests.Clear();
            }
            else
                MessageBox.Show(" לא ניתן להשאיר שדות ריקים", "המשך", MessageBoxButtons.OK);
        }
        private void date_TextChanged(object sender, EventArgs e)
        {

        }

        private void numOfTablesNow_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bidScreen_Click(object sender, EventArgs e)
        {
            Create_Bid cb = new Create_Bid();
            cb.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventDesignerScreen ed = new EventDesignerScreen();
            ed.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();
        }
    }
}