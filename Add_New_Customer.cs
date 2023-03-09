using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group28_1
{
    public partial class Add_New_Customer : Form
    {
        public Add_New_Customer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Add_New_Customer_Load(object sender, EventArgs e)
        {

        }

        private void id_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void create_button_Click(object sender, EventArgs e)
        {
            if (!NullCheck())
                return;
            if(Program.isThereAChar(id_Textbox.Text))
            {
                MessageBox.Show("מספר תעודת זהות חייב להיות מורכב ממספרים בלבד", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                MailAddress address = new MailAddress(email_Textbox.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("כתובת אימייל בפורמט לא תקין", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string phoneNumberPattern = @"^[0-9]{3}[0-9]{3}[0-9]{4}$";
            if (Regex.IsMatch(phoneNumber_Textbox.Text, phoneNumberPattern))
            {
                // The text in the textbox is a valid phone number
            }
            else
            {
                MessageBox.Show("מספר טלפון בפורמט לא תקין", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Program.seekCustomer(long.Parse(id_Textbox.Text)) != null || Program.seek_Archive_Customer(long.Parse(id_Textbox.Text)) != null)
            {
                DialogResult result = MessageBox.Show("לקוח זה כבר קיים במערכת. האם זה לקוח חוזר?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    customerType ct = new customerType();
                    ct = (customerType)Enum.Parse(typeof(customerType), "returningCustomer");
                    Customer c = new Customer(long.Parse(id_Textbox.Text.ToString()), email_Textbox.Text, phoneNumber_Textbox.Text, firstName_Textbox.Text, lastName_Textbox.Text, ct, true);
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("הזנ/י תעודת זהות שונה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                customerType ct = new customerType();
                ct = (customerType)Enum.Parse(typeof(customerType), "newCustomer");
                Customer c = new Customer(long.Parse(id_Textbox.Text.ToString()), email_Textbox.Text, phoneNumber_Textbox.Text, firstName_Textbox.Text, lastName_Textbox.Text, ct, true);
            }
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            CRUD_Customers c = new CRUD_Customers();
            this.Hide();
            c.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();
        }

        private Boolean NullCheck() //null able attributes check 
        {

            if (id_Textbox.Text == "" || firstName_Textbox.Text == "" || lastName_Textbox.Text == "" || phoneNumber_Textbox.Text == "" || email_Textbox.Text == "")
            {
                MessageBox.Show("אין להזין שדות ריקים", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }//invalid input
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}