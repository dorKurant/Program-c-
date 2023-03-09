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
    public partial class CreateNewemployee : Form
    {
        public CreateNewemployee()
        {
            InitializeComponent();
            employeeType.DataSource = Enum.GetValues(typeof(employeeType));
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateNewemployee_Load(object sender, EventArgs e)
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

        private void salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id.Text.Length!=0 && firstName.Text.Length != 0 && lastName.Text.Length != 0 && userName.Text.Length != 0 && password.Text.Length != 0 && employeeType.Text.Length != 0 &&
                salary.Text.Length != 0)
            {
                if (Program.isThereAChar(id.Text))
                {
                    MessageBox.Show("מספר תעודת זהות חייב להיות מורכב ממספרים בלבד", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Program.isThereAChar(salary.Text) || double.Parse(salary.Text.ToString()) < 30 || double.Parse(salary.Text.ToString()) > 200)
                {
                    MessageBox.Show("שכר שעתי חייב להיות מורכב ממספרים בין 30 ל- 200", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (employee emp in Program.employees)
                {
                    if (userName.Text == emp.get_userName())
                    {
                        MessageBox.Show("שם המשתמש כבר קיים במערכת, אנא בחר שם משתמש חדש", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                Boolean findCEO = false;
                //if ((employeeType)Enum.Parse(typeof(employeeType), employeeType.Text)==)
                if (employeeType.Text == "CEO")
                {

                    foreach (employee ee in Program.employees)
                    {
                        if (ee.get_employeeType().ToString() == "CEO")
                        {
                            MessageBox.Show("אינך יכול להוסיף מנכל נוסף", "המשך", MessageBoxButtons.OK);
                            findCEO = true;
                            break;
                        }
                    }
                }
                if (findCEO == false)
                {
                    employee ee = new employee(long.Parse(id.Text.ToString()), firstName.Text, lastName.Text, userName.Text, password.Text, (employeeType)Enum.Parse(typeof(employeeType), employeeType.Text), double.Parse(salary.Text.ToString()), true);
                }
            }
            else
                MessageBox.Show("לא ניתן להזין שדות ריקים", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        private void back_Click(object sender, EventArgs e)
        {
            CRUD_Employees cr = new CRUD_Employees();
            cr.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();
        }
    }
}
