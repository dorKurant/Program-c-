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
    public partial class View_Employees : Form
    {
        int rowIndex;
        public View_Employees()
        {
            InitializeComponent();
            //employeeType.DataSource = Enum.GetValues(typeof(employeeType));
        }

        private void View_Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_28DataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.sAD_28DataSet1.Employees);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            //dataGridView1.Rows.RemoveAt(rowIndex);
            int mone = 0;
            foreach (employee i in Program.employees)
            {
                if (mone == rowIndex)
                {
                    i.move_archive_employee();
                    this.employeesTableAdapter.Fill(this.sAD_28DataSet1.Employees);
                    break;
                }
                mone++;
            }
            // Console.WriteLine(Program.employees);
            //dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salaryPerHour_TextChanged(object sender, EventArgs e)
        {

        }
        private void update_Click(object sender, EventArgs e)
        {
            if (!this.NullCheck()) //null able attributes check 
                return;
            if (!this.integerCheck()) //Input ID and salary per hour check
                return;
            if (this.nothingChanged()) //check if nothing changed
                return;
            foreach (employee ee in Program.employees)
                if (ee.get_userName().Equals(userName.Text.ToString()) & !userName.Text.ToString().Equals(dataGridView1.Rows[rowIndex].Cells[3].Value.ToString()))
                {
                    MessageBox.Show("שם המשתמש תפוס, אנא בחר שם משתמש אחר", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            string id_a = dataGridView1[0, rowIndex].Value.ToString();//
            employee i = Program.employees.FirstOrDefault(p => p.get_id().ToString() == id_a);
            long old_id = i.get_id();
            i.set_firsrName(firstName.Text.ToString());
            i.set_lastName(lastName.Text.ToString());
            i.set_userName(userName.Text.ToString());
            i.set_password(password.Text.ToString());
            i.set_salaryPerHour(long.Parse(salaryPerHour.Text.ToString()));
            long new_id = long.Parse(id.Text.ToString());
            if (old_id != new_id) //changed ID
            {
                i.set_id(new_id);//update C#
                employee emp = new employee(new_id, i.get_firstName(), i.get_lastName(), i.get_userName(), i.get_password(), i.get_employeeType(), i.get_salaryPerHour(), false);
                Program.employees.Add(emp);
                i.update_employeeID(old_id);
                Program.employees.Remove(i);//remove employee
                this.employeesTableAdapter.Fill(this.sAD_28DataSet1.Employees);
                return;
            }
            i.update_employee();//else
            this.employeesTableAdapter.Fill(this.sAD_28DataSet1.Employees);
        }

        private void checkEmployeeID(employee i)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            CRUD_Employees cr = new CRUD_Employees();
            cr.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            id.Text = row.Cells[0].Value.ToString();
            firstName.Text = row.Cells[1].Value.ToString();
            lastName.Text = row.Cells[2].Value.ToString();
            userName.Text = row.Cells[3].Value.ToString();
            password.Text = row.Cells[4].Value.ToString();
            salaryPerHour.Text = row.Cells[6].Value.ToString();
        }
        private Boolean NullCheck() //null able attributes check 
        {

            if (id.Text == "" || firstName.Text == "" || lastName.Text == "" || userName.Text == "" || password.Text == "" || salaryPerHour.Text == "")
            {
                MessageBox.Show("אין להזין שדות ריקים", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }//invalid input
            return true;
        }
        private Boolean nothingChanged()
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int IDD = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
            string FN = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            string LN = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            string UN = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            string PW = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            string type = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            float SPH = float.Parse(dataGridView1.Rows[rowIndex].Cells[6].Value.ToString());
            if (IDD != int.Parse(id.Text))
                return false;
            if (!FN.Equals(firstName.Text))
                return false;
            if (!LN.Equals(lastName.Text))
                return false;
            if (!UN.Equals(userName.Text))
                return false;
            if (!PW.Equals(password.Text))
                return false;
            if (SPH != float.Parse(salaryPerHour.Text))
                return false;
            MessageBox.Show("לא שונה דבר");
            return true;//nothing changed
        }
        private Boolean integerCheck() //Input ID check
        {
            int parsedValue;//help variable
            if (!int.TryParse(id.Text, out parsedValue)) //check if the input is a number
            {
                MessageBox.Show("תעודת זהות לא תקינה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; //exit
            }
            if (!int.TryParse(salaryPerHour.Text, out parsedValue)) //check if the input is a number
            {
                MessageBox.Show("שכר לא תקין", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; //exit
            }
            if (float.Parse(salaryPerHour.Text) <= 0)
            {
                MessageBox.Show("שכר לא תקין", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; //exit
            }
            return true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();
        }

        private void cboColumn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}