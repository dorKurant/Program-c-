using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.IO;
using System.Drawing.Imaging;
using System.Net.Mail;
using System.Net;

namespace group28_1
{
    public partial class Create_Bid : Form
    {
        double rate = 0;
        Boolean approv;
        public Create_Bid()
        {
            InitializeComponent();
            DateTime currentTime = DateTime.Now;
            date.Text = currentTime.ToString("dd-MM-yyyy");
            customerName.Hide();
            customerEmail.Hide();
            customerPhone.Hide();
            eventType.Hide();
            eventDate.Hide();
            priceLabel.Hide();
            totalPrice.Hide();
            newBid.Hide();
            discount.Hide();
            discount_seven.Hide();
            discount_ten.Hide();
            button1.Hide();
            update_Status.Hide();
        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void Create_Bid_Load(object sender, EventArgs e)
        {

        }
        private void customerID_Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!check_CustomerID())
                    return;
            }
        }
        private void customerID_Textbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void eventID_TextChanged(object sender, EventArgs e)
        {

        }
        private void eventID_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!check_designID())
                    return;
            }
        }
        private void sing_Out_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();
        }
        private void back_Click(object sender, EventArgs e)
        {
            EventDesignerScreen eds = new EventDesignerScreen();
            eds.Show();
            this.Hide();
        }
        private void create_Click(object sender, EventArgs e)//calculate the price of the bid
        {
            if (!check_CustomerID())
                return;
            if (!check_designID())
                return;
            Event v = Program.seek_event(eventID.Text);
            design_Price();
            Bid b = new Bid(bidID.Text, DateTime.Parse(date.Text), v.get_grossPrice(), rate, v.get_grossPrice(), false, long.Parse(customerID_Textbox.Text), eventID.Text, false);//only for calculate_bid
            double price = Math.Truncate(b.get_totalPrice());
            totalPrice.Text = price.ToString();
            button1.Show();
            discount.Show();
            discount_seven.Show();
            discount_ten.Show();
            totalPrice.Show();
            priceLabel.Show();
            newBid.Show();
            update_Status.Show();
            //Crud_Vehicles cv = new Crud_Vehicles();
            //cv.Show();
            //this.Close();
        }
        private void bidID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (bidID.Text.Length == 0)
                    MessageBox.Show("לא הזנת מזהה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void discount_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("?את בטוחה שאת רוצה לתת 5 אחוז הנחה", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                double price = double.Parse(totalPrice.Text);
                price = Math.Truncate(price * 0.9);
                totalPrice.Text = price.ToString();
            }
        }

        private void eventType_Click(object sender, EventArgs e)
        {

        }
        private void newBid_Click(object sender, EventArgs e)// add new bid to the DB
        {
            if (bidID.Text.Length == 0)
            {
                MessageBox.Show("לא הזנת מזהה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Entry_Screen es = new Entry_Screen();
                //es.Show();
                //this.Hide();
            }
            else
            {
                if (Program.seek_Bid(bidID.Text) != null)
                {
                    MessageBox.Show("הצעת מחיר זו קיימת במערכת, אנא הכנס הצעת מחיר אחרת", "", MessageBoxButtons.OK);
                }
                else
                {
                    if (approv == false)
                    {
                        DialogResult result = MessageBox.Show("?האם הצעת המחיר אושרה", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            approv = true;
                        }
                        else if (result == DialogResult.No)
                        {
                            approv = false;
                        }
                    }
                    Event v = Program.seek_event(eventID.Text);
                    Bid b1 = new Bid(bidID.Text, DateTime.Parse(date.Text), v.get_grossPrice(), rate, v.get_grossPrice(), approv, long.Parse(customerID_Textbox.Text), eventID.Text, true);//create new bid
                    Create_Bid bc = new Create_Bid();
                    bc.Show();
                    this.Hide();
                }
            }
        }
        private Boolean integerCheck() //Input ID check
        {
            int parsedValue;//help variable
            if (!int.TryParse(customerID_Textbox.Text, out parsedValue)) //check if the input is a number
            {
                MessageBox.Show("תעודת זהות לא תקינה, אנא הזן מספרים בלבד", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; //exit
            }
            return true;
        }
        private void Create_Bid_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void bidID_TextChanged(object sender, EventArgs e)
        {

        }
        private Boolean check_CustomerID()//check if the customer ID in the DB
        {
            if (!this.integerCheck()) //Input ID check
                return false;
            long id = long.Parse(customerID_Textbox.Text.ToString());
            foreach (Customer i in Program.customers)
            {
                if (id == i.get_id())
                {
                    customerName.Text = i.get_firstName() + " " + i.get_lastName();
                    customerEmail.Text = i.get_email();
                    customerPhone.Text = i.get_phoneNumber();
                    customerName.Show();
                    customerEmail.Show();
                    customerPhone.Show();
                    return true;
                }
            }
            MessageBox.Show("לקוח זה לא קיים במערכת", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        private Boolean check_designID()//check if the design ID in the DB
        {
            string id = eventID.Text;
            foreach (Design_event i in Program.all_design_event)
            {
                if (id == i.get_eventID())
                {
                    foreach (Event e in Program.Events)
                    {
                        if (id == e.get_eventID() && e.get_date() > DateTime.Now)//את זה להשים בהערה 
                        {
                            eventType.Text = e.get_type().ToString();
                            eventDate.Text = e.get_date().ToString("dd-MM-yyyy");
                            eventType.Show();
                            eventDate.Show();
                            return true;
                        }
                    }
                }
            }
            MessageBox.Show("אירוע זה לא קיים במערכת/עוד לא התקיימה פגישת עיצוב", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        private void design_Price()
        {
            foreach (Design_event de in Program.all_design_event)
            {
                if (de.get_eventID().ToString() == eventID.Text)//must
                {
                    foreach (Design d in Program.Designs)
                    {
                        if (de.get_designID() == d.get_DesignID())//must
                        {
                            dataGridView1.Rows.Add(d.get_DesignID(), d.get_price());
                        }
                    }
                }
            }
        }

        public void totalPrice_Click(object sender, EventArgs e)
        {

        }
        private void discount_seven_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("?את בטוחה שאת רוצה לתת 7.5 אחוז הנחה", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                double price = double.Parse(totalPrice.Text);
                price = Math.Truncate(price * 0.9);
                totalPrice.Text = price.ToString();


            }
        }
        private void discount_ten_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("?את בטוחה שאת רוצה לתת 10 אחוז הנחה", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                double price = double.Parse(totalPrice.Text);
                price = Math.Truncate(price * 0.9);
                totalPrice.Text = price.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bidID.Text.Length == 0)
            {
                //MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                MessageBox.Show("לא הזנת מזהה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Entry_Screen es = new Entry_Screen();
                //es.Show();
                //this.Hide();
            }
            else if (Program.seek_Bid(bidID.Text) != null)
            {
                MessageBox.Show("הצעת מחיר זו קיימת במערכת, אנא הכנס הצעת מחיר אחרת", "", MessageBoxButtons.OK);
            }
            else
            {
                string eventid = eventID.Text;
                string customerid = customerID_Textbox.Text;
                string total = totalPrice.Text;
                string bid = bidID.Text;
                Recipt R = new Recipt(eventid, customerid, total, bid);
            }
        }

        private void update_Status_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("?לעדכן סטטוס הצעת המחיר לאושר", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                approv = true;
            }
            else if (result == DialogResult.No)
            {
                approv = false;
            }
        }
    }
}