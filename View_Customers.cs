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
    public partial class View_Customers : Form
    {
        public View_Customers()
        {
            InitializeComponent();
        }

        private void View_Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_28DataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.sAD_28DataSet1.Customers);
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (!this.NullCheck()) //null able attributes check 
                return;
            if (!this.integerCheck()) //Input ID check
                return;
            if (this.nothingChanged()) //check if nothing changed
                return;
            try
            {
                MailAddress address = new MailAddress(email_Textbox.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("כתובת אימייל בפורמט לא תקין", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int mone = 0;
            foreach (Customer i in Program.customers)
            {

                if (mone == rowIndex)
                {
                    string email = email_Textbox.Text;
                    i.set_email(email);
                    string phoneNumber = phoneNumber_Textbox.Text;
                    i.set_phoneNumber(phoneNumber);
                    string firstName = firstName_Textbox.Text;
                    i.set_firstName(firstName);
                    string lastName = lastName_Textbox.Text;
                    i.set_lastName(lastName);
                    long old_id = i.get_id();
                    long new_id = long.Parse(id_Textbox.Text.ToString());
                    i.set_id(new_id);//update C#
                    if (old_id != new_id) //changed ID
                    {
                        Customer cus = new Customer(new_id, email, phoneNumber, firstName, lastName, i.get_type(), false);
                        Program.customers.Add(cus);
                        i.update_CustomerID(old_id);
                        Program.customers.Remove(i);//remove customer
                        Program.init_customer();
                        this.customersTableAdapter.Fill(this.sAD_28DataSet1.Customers);
                        return;
                    }
                    i.update_Customer(old_id); //else
                    Program.init_customer();
                    this.customersTableAdapter.Fill(this.sAD_28DataSet1.Customers);
                    return;
                }
                mone++;
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            int mone = 0;
            foreach (Customer i in Program.customers)
            {

                if (mone == rowIndex)
                {
                    i.move_archive_customers();
                    break;
                }
                mone++;
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.sAD_28DataSet1.Customers);
            Program.init_customer();
        }

        private void header_label_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void return_button_Click(object sender, EventArgs e)
        {
            CRUD_Customers c = new CRUD_Customers();
            this.Hide();
            c.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int mone = 0;
            foreach (Customer i in Program.customers)
            {

                if (mone == rowIndex)
                {
                    id_Textbox.Text = i.get_id().ToString();
                    email_Textbox.Text = i.get_email().ToString();
                    phoneNumber_Textbox.Text = i.get_phoneNumber().ToString();
                    firstName_Textbox.Text = i.get_firstName().ToString();
                    lastName_Textbox.Text = i.get_lastName().ToString();
                    break;
                }
                mone++;
            }
        }
        private Boolean NullCheck() //null able attributes check 
        {

            if (id_Textbox.Text == "" || email_Textbox.Text == "" || phoneNumber_Textbox.Text == "" || firstName_Textbox.Text == "" || lastName_Textbox.Text == "")
            {
                MessageBox.Show("אין להזין שדות ריקים", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }//invalid input
            return true;
        }
        private Boolean nothingChanged()
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int id = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
            string email = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            string phoneNumber = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            string firstName = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            string lastName = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            if (id != int.Parse(id_Textbox.Text))
                return false;
            if (!email.Equals(email_Textbox.Text))
                return false;
            if (!phoneNumber.Equals(phoneNumber_Textbox.Text))
                return false;
            if (!firstName.Equals(firstName_Textbox.Text))
                return false;
            if (!lastName.Equals(lastName_Textbox.Text))
                return false;
            MessageBox.Show("לא שונה דבר");
            return true;//nothing changed
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private Boolean integerCheck() //Input ID check
        {
            int parsedValue;//help variable
            if (!int.TryParse(id_Textbox.Text, out parsedValue)) //check if the input is a number
            {
                MessageBox.Show("תעודת זהות לא תקינה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; //exit
            }
            string phoneNumberPattern = @"^[0-9]{3}[0-9]{3}[0-9]{4}$";
            if (!Regex.IsMatch(phoneNumber_Textbox.Text, phoneNumberPattern))
            {
                MessageBox.Show("מספר טלפון בפורמט לא תקין", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void id_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void sing_Out_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();
        }
    }
}