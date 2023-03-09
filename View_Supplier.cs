using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace group28_1
{
    public partial class View_Supplier : Form
    {
        public View_Supplier()
        {
            InitializeComponent();
        }

        int rowIndex;
        private void View_Supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_28DataSet1.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.sAD_28DataSet1.Supplier);
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            Crud_Supplier cs = new Crud_Supplier();
            cs.Show();
            this.Hide();
        }
        private void logOut_button_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            id.Text = row.Cells[0].Value.ToString();
            supplierName.Text = row.Cells[1].Value.ToString();
            email.Text = row.Cells[2].Value.ToString();
            phone.Text = row.Cells[3].Value.ToString();
        }
        private void update_Click(object sender, EventArgs e)
        {
            if (!this.NullCheck()) //null able attributes check 
                return;
            if (!IsValidEmail(email.Text))// Mail check
            {
                MessageBox.Show("אימייל הוכנס בפורמט לא תקין", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string phoneNumberPattern = @"^[0-9]{3}[0-9]{3}[0-9]{4}$";
            if (!Regex.IsMatch(phone.Text, phoneNumberPattern))
            {
                MessageBox.Show("מספר טלפון בפורמט לא תקין", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int mone = 0;
            foreach (Supplier i in Program.suppliers)
            {
                if (mone == rowIndex)
                {
                    if (!this.integerCheck()) //Input ID check
                        return;
                    long oldSupplierID = i.get_supplierID();
                    if ((supplierName.Text.Length != 0))
                        i.set_supplierName(supplierName.Text);
                    if ((email.Text.Length != 0))
                        i.set_email(email.Text);
                    if ((phone.Text.Length != 0))
                        i.set_phone(phone.Text);
                    if (id.Text.Length != 0)
                    {
                        long new_id = long.Parse(id.Text.ToString());
                        if (oldSupplierID != new_id) //changed ID
                        {
                            i.set_supplierID(new_id);//update C#
                            Supplier sup = new Supplier(new_id, i.get_supplierName(), i.get_email(), i.get_phone(), false);
                            Program.suppliers.Add(i);
                            i.update_supplierID(oldSupplierID);
                            Program.suppliers.Remove(i);//remove employee
                            this.supplierTableAdapter.Fill(this.sAD_28DataSet1.Supplier);
                            return;
                        }
                    }
                    i.update_Supplier();
                    Program.init_Supplier();
                    this.supplierTableAdapter.Fill(this.sAD_28DataSet1.Supplier);
                    break;
                }
                mone++;
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            //rowIndex = dataGridView1.CurrentCell.RowIndex;
            int mone = 0;
            foreach (Supplier i in Program.suppliers)
            {
                if (mone == rowIndex)
                {
                    i.move_archive_Supplier();
                    this.supplierTableAdapter.Fill(this.sAD_28DataSet1.Supplier);
                    break;
                }
                mone++;
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private Boolean integerCheck() //Input ID check
        {
            int parsedValue;//help variable
            if (!int.TryParse(id.Text, out parsedValue)) //check if the input is a number
            {
                MessageBox.Show("מזהה ספק לא תקין, אנא הכנס מספרים בלבד", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; //exit
            }
            return true;
        }
        private Boolean NullCheck() //null able attributes check 
        {

            if (id.Text == "" || supplierName.Text == "" || email.Text == "" || phone.Text == "")
            {
                MessageBox.Show("אין להזין שדות ריקים", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }//invalid input
            return true;
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplierName_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cboColumn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}