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
    public partial class ARCHIVE_CUSTOMERS : Form
    {
        public ARCHIVE_CUSTOMERS()
        {
            InitializeComponent();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void ARCHIVE_CUSTOMERS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_28DataSet1.ARCHIVE_CUSTOMERS' table. You can move, or remove it, as needed.
            this.aRCHIVE_CUSTOMERSTableAdapter.Fill(this.sAD_28DataSet1.ARCHIVE_CUSTOMERS);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboColumn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomerID_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void outOfArchive_click_Click(object sender, EventArgs e) //return to Customers list
        {
            if (string.IsNullOrEmpty(CustomerID_textBox.Text))//empty
            {
                MessageBox.Show("Please enter a customer ID");
                return;
            }
            if (!this.integerCheck()) //integer only check
                return;
            long customerID = Int32.Parse(CustomerID_textBox.Text);
            foreach (Customer i in Program.archive_customers)
            {

                if (i.get_id() == customerID)
                {
                    i.return_archive_customers();
                    this.aRCHIVE_CUSTOMERSTableAdapter.Fill(this.sAD_28DataSet1.ARCHIVE_CUSTOMERS);
                    return;
                }
            }
            MessageBox.Show("Customer not found");
            this.aRCHIVE_CUSTOMERSTableAdapter.Fill(this.sAD_28DataSet1.ARCHIVE_CUSTOMERS);

        }
        private Boolean integerCheck()
        {
            int parsedValue;//help variable
            if (!int.TryParse(CustomerID_textBox.Text, out parsedValue)) //check if the input is a number
            {
                MessageBox.Show("This is a number only field");
                return false; //exit
            }
            return true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUD_Customers cc = new CRUD_Customers();
            cc.Show();
            this.Hide();
        }
    }
}
