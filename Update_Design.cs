using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group28_1
{
    public partial class Update_Design : Form
    {
        int rowIndex;
        public Update_Design()
        {
            InitializeComponent();
            productType.DataSource = Enum.GetValues(typeof(productType));

        }

        private void Update_Design_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_28DataSet1.DESIGNS_PRODUCTS' table. You can move, or remove it, as needed.
            this.dESIGNS_PRODUCTSTableAdapter.Fill(this.sAD_28DataSet1.DESIGNS_PRODUCTS);
            // TODO: This line of code loads data into the 'sAD_28DataSet1.Designs' table. You can move, or remove it, as needed.
            this.designsTableAdapter.Fill(this.sAD_28DataSet1.Designs);

        }

        private void products_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            int rowIndex = dataGridView1.CurrentCell.RowIndex; //row number celected
            string designName = dataGridView1[0, rowIndex].Value.ToString(); // name od the design id
            Design d = Program.Designs.FirstOrDefault(p => p.get_DesignID().ToString() == designName.ToString());
            foreach (KeyValuePair<Product, int> pair in d.product2)
            {
                Product x = pair.Key;
                //int quantity = Program.all_design_event.FirstOrDefault(p => p.get_designID().ToString() == d.get_DesignID().ToString()).get_quantity();
                //int quantity = Program.all_design_event.Where(p => p.get_designID().ToString() == d.get_DesignID().ToString() && pair.Value == someValue).FirstOrDefault().get_quantity();
                int quantity = Program.all_design_products.Where(p => p.get_designID().ToString() == d.get_DesignID().ToString() && p.get_productID().ToString() == x.get_prouductID()).FirstOrDefault().get_quantity();
                dataGridView2.Rows.Add(designName.ToString(), pair.Key.get_type(), quantity);
            }
            textBox1.Text = Program.all_design_event.FirstOrDefault(p => p.get_designID().ToString() == d.get_DesignID().ToString()).get_quantity().ToString();
            //dataGridView2.DataSource = new BindingSource(d.product2, null);


        }

        private void productType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                // Check if the text consists of only digits
                bool isNumber = true;
                foreach (char c in textBox1.Text)
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
                    textBox1.Text = "";
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bidScreen_Click(object sender, EventArgs e)
        {
            Create_Bid cb = new Create_Bid();
            cb.Show();
            this.Hide();
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = dataGridView1.Rows[rowIndex];
            if (dataGridView2.CurrentCell == null)
                MessageBox.Show("לא נבחר מוצר שרוצים למחוק", "", MessageBoxButtons.OK);
            else
            {
                rowIndex = dataGridView2.CurrentCell.RowIndex; //the row we want to delete
                string designId = dataGridView2[0, rowIndex].Value.ToString();//name of the design
                Design desToDel = Program.Designs.FirstOrDefault(Design => Design.get_DesignID().ToString() == designId.ToString());
                string nameProdDel = dataGridView2[1, rowIndex].Value.ToString();//name of the design
                Product productDel = Program.Products.FirstOrDefault(product => product.get_type().ToString() == nameProdDel.ToString());
                foreach (design_products dp in Program.all_design_products)
                {
                    if (dp.get_designID().ToString() == desToDel.get_DesignID().ToString())
                    {
                        if (dp.get_productID().ToString() == productDel.get_prouductID().ToString())
                        {
                            Program.all_design_products.Remove(dp); //remove the design_product conection
                            dp.delete_design_product();
                            break;
                        }
                    }
                }
                desToDel.product2.Remove(productDel);//delete the product from the design list 
                desToDel.set_price(desToDel.get_price() - (productDel.get_price() * (int.Parse(dataGridView2[2, rowIndex].Value.ToString())) * (int.Parse(textBox1.Text.ToString()))));//calculate the new price
                desToDel.update_design();
                foreach (Design_event de in Program.all_design_event)
                {
                    if (de.get_designID().ToString() == desToDel.get_DesignID().ToString())
                    {
                        Event EI = Program.Events.FirstOrDefault(Event => Event.get_eventID().ToString() == de.get_eventID().ToString()); //find the next event with that d
                        EI.set_grossPrice(EI.get_grossPrice() - (productDel.get_price() * (int.Parse(dataGridView2[2, rowIndex].Value.ToString())) * (int.Parse(textBox1.Text.ToString()))));
                        EI.update_Event_price();
                        Bid b1 = Program.bids.FirstOrDefault(Bid => Bid.get_eventID().ToString() == EI.get_eventID().ToString());
                        if (b1 == null)
                            MessageBox.Show("טרם ניתנה הצעת מחיר לאירוע זה", "", MessageBoxButtons.OK);
                        else
                        {
                            b1.set_initialPrice(EI.get_grossPrice());
                            b1.calculate_Bid();
                            b1.update_Bid();
                        }
                    }
                }
                dataGridView2.Rows.RemoveAt(rowIndex);//delete the row
                dataGridView2.Rows.Clear();
            }
            this.designsTableAdapter.Fill(this.sAD_28DataSet1.Designs);
        }

        private void add_design_Click(object sender, EventArgs e)
        {
            Product productAdd = Program.Products.FirstOrDefault(product => product.get_type().ToString() == productType.Text.ToString());
            if (productsAmount.Text.ToString() == "")
            {
                MessageBox.Show("הכנס כמות ממוצר זה", "המשך", MessageBoxButtons.OK);

            }
            else
            {
                int amount = int.Parse(productsAmount.Text.ToString()); //כמות נבחרה
                if (productAdd.get_quantity() < amount)
                {
                    MessageBox.Show("קיימים רק" + " " + productAdd.get_quantity() + " " + "יחידות מסוג זה ", "המשך", MessageBoxButtons.OK);

                }
                else
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex; //the row we want to delete
                    string designId = dataGridView1[0, rowIndex].Value.ToString();//name of the design
                    Design desToAdd = Program.Designs.FirstOrDefault(Design => Design.get_DesignID().ToString() == designId.ToString());
                    design_products dp;
                    if (desToAdd.product2.ContainsKey(productAdd))
                    {
                        dp = Program.all_design_products.FirstOrDefault(design_products => design_products.get_designID().ToString() == desToAdd.get_DesignID().ToString());
                        dp.set_quantity(dp.get_quantity() + amount);
                        desToAdd.product2[productAdd] = desToAdd.product2[productAdd] + amount;
                    }
                    else
                    {
                        dp = new design_products(desToAdd.get_DesignID(), productAdd.get_prouductID(), amount, true); //add new conection betwin design and product 
                        desToAdd.product2.Add(productAdd, amount);//add the product to the list of the design 

                    }
                    if (textBox1.Text.ToString() == "")
                    {
                        MessageBox.Show(" לא הוזן מספר שולחנות ", "המשך", MessageBoxButtons.OK);

                    }
                    else
                    {
                        desToAdd.set_price(desToAdd.get_price() + (productAdd.get_price() * (int.Parse(productsAmount.Text.ToString())) * (int.Parse(textBox1.Text.ToString()))));//update the price of the design 
                        desToAdd.update_design();//update the sql od the design 
                        string EventName = Program.all_design_event.FirstOrDefault(Design_event => Design_event.get_designID().ToString() == dp.get_designID().ToString()).get_eventID(); //FIND THE NAME OF THE EVENT TO CHANGE 
                        Event EventChange = Program.Events.FirstOrDefault(Event => Event.get_eventID().ToString() == EventName.ToString()); //find the event to change 
                        EventChange.set_grossPrice(EventChange.get_grossPrice() + (productAdd.get_price() * (int.Parse(productsAmount.Text.ToString())) * (int.Parse(textBox1.Text.ToString()))));//add the new price 
                        EventChange.update_Event_price();//update in the sql the price 
                        Bid bidChange = Program.bids.FirstOrDefault(Bid => Bid.get_eventID().ToString() == EventChange.get_eventID().ToString());//get the bid we need to change 
                        if (bidChange == null)
                            //if (Program.seekSupplier(long.Parse(ID.Text.ToString())) != null)
                            //{
                            MessageBox.Show("טרם ניתנה הצעת מחיר לאירוע זה", "", MessageBoxButtons.OK);
                        //}
                        else
                        {
                            bidChange.set_initialPrice(EventChange.get_grossPrice()); //change the gross price to the new 
                            bidChange.calculate_Bid(); // calculate again the total price 
                            bidChange.update_Bid();
                            dataGridView2.Rows.Add(designId, productAdd.get_type(), (productAdd.get_price() * (int.Parse(productsAmount.Text.ToString())) * (int.Parse(textBox1.Text.ToString()))));
                        }
                    }

                }
                dataGridView2.Rows.Clear();
            }
            this.designsTableAdapter.Fill(this.sAD_28DataSet1.Designs);


        }
        private void numberOfTable_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || newTables.Text.Length == 0)
            {
                MessageBox.Show(" לא ניתן להשאיר שדות ריקים", "המשך", MessageBoxButtons.OK);

            }
            else if (dataGridView1.CurrentCell == null)
                MessageBox.Show(" לא נבחר עיצוב", "המשך", MessageBoxButtons.OK);
            else
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex; //the row we want to change
                string designId = dataGridView1[0, rowIndex].Value.ToString();//name of the design
                double price = double.Parse(dataGridView1[1, rowIndex].Value.ToString());//last price
                double oldTable = double.Parse(textBox1.Text.ToString()); //the old table amount
                double newTable = double.Parse(newTables.Text.ToString()); //the new table amount 
                double newPrice;
                if (oldTable == 0)
                    newPrice = 0;
                else
                    newPrice = price * (newTable / oldTable); // the new price 
                Design desToAdd = Program.Designs.FirstOrDefault(Design => Design.get_DesignID().ToString() == designId.ToString());//the design we want to change 
                string EventName = Program.all_design_event.FirstOrDefault(Design_event => Design_event.get_designID().ToString() == desToAdd.get_DesignID().ToString()).get_eventID(); //FIND THE NAME OF THE EVENT TO CHANGE 
                Event EventChange = Program.Events.FirstOrDefault(Event => Event.get_eventID().ToString() == EventName.ToString()); //find the event to change 
                EventChange.designs[desToAdd] = int.Parse(newTable.ToString()); //change the number in c#
                EventChange.set_grossPrice(EventChange.get_grossPrice() + (newPrice - price));//update the new price 
                EventChange.update_Event_price();//update in sql the new price 
                Design_event de = Program.all_design_event.Where(d => d.get_designID().ToString() == desToAdd.get_DesignID().ToString() && d.get_eventID().ToString() == EventChange.get_eventID()).FirstOrDefault();
                de.set_quantity(int.Parse(newTable.ToString()));//change the quantity in the conaction table
                de.update_design_event();//update the number in the SQL 
                Bid bidChange = Program.bids.FirstOrDefault(Bid => Bid.get_eventID().ToString() == EventChange.get_eventID().ToString());//get the bid we need to change 
                if (bidChange == null)
                    //if (Program.seekSupplier(long.Parse(ID.Text.ToString())) != null)
                    //{
                    MessageBox.Show("טרם ניתנה הצעת מחיר לאירוע זה", "", MessageBoxButtons.OK);
                //}
                else
                {
                    bidChange.set_initialPrice(EventChange.get_grossPrice()); //change the gross price to the new 
                    bidChange.calculate_Bid(); // calculate again the total price 
                    bidChange.update_Bid();

                }
            }
            textBox1.Text = newTables.Text;
            newTables.Text = "0";
            this.designsTableAdapter.Fill(this.sAD_28DataSet1.Designs);
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

        private void newTables_TextChanged(object sender, EventArgs e)
        {
            {
                // Check if the text consists of only digits
                bool isNumber = true;
                foreach (char c in newTables.Text)
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
                    newTables.Text = "";

                }
            }
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            EventDesignerScreen ed = new EventDesignerScreen();
            ed.Show();
            this.Hide();
        }

        private void sing_Out_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();
        }
    }
}