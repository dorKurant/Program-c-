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
    public partial class ARCHIVE_EMPLOYEES : Form
    {
        public ARCHIVE_EMPLOYEES()
        {
            InitializeComponent();
        }

        private void ARCHIVE_EMPLOYEES_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_28DataSet1.ARCHIVE_EMPLOYEES' table. You can move, or remove it, as needed.
            this.aRCHIVE_EMPLOYEESTableAdapter.Fill(this.sAD_28DataSet1.ARCHIVE_EMPLOYEES);
        }  
        private Boolean integerCheck()
        {
            int parsedValue;//help variable
            if (!int.TryParse(EmployeeID_txtBox.Text, out parsedValue)) //check if the input is a number
            {
                MessageBox.Show("This is a number only field");
                return false; //exit
            }
            return true;
        }

        private void remove_EmployeeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmployeeID_txtBox.Text))//empty
            {
                MessageBox.Show("Please enter an employee ID");
                return;
            }
            if (!this.integerCheck()) //integer only check
                return;
            long employeeID = Int32.Parse(EmployeeID_txtBox.Text);
            foreach (employee i in Program.archive_employees)
            {

                if (i.get_id() == employeeID)
                {
                    i.return_archive_employee();
                    this.aRCHIVE_EMPLOYEESTableAdapter.Fill(this.sAD_28DataSet1.ARCHIVE_EMPLOYEES);
                    return;
                }
            }
            MessageBox.Show("Employee not found");
            this.aRCHIVE_EMPLOYEESTableAdapter.Fill(this.sAD_28DataSet1.ARCHIVE_EMPLOYEES);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUD_Employees ce = new CRUD_Employees();
            ce.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entry_Screen ess = new Entry_Screen();
            ess.Show();
            this.Hide();
        }

        private void header_Click(object sender, EventArgs e)
        {

        }

        private void cboColumn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
