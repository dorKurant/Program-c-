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
    public partial class Entry_Screen : Form
    {
        public Entry_Screen()
        {
            InitializeComponent();
        }

        private void Entry_Screen_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }

        private void entry_Click(object sender, EventArgs e)
        {
            check_User();
        }
        private void password_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void password_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                check_User();
            }
        }

        private void sign_out_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void check_User()
        {
            employee emp = Program.seekEmployee(userName.Text, password.Text);
            if (emp == null)
            {
                MessageBox.Show("שם משתשמש או סיסמא זה לא קיימים במערכת, אנא הכנס שם משתמש אחר", "", MessageBoxButtons.OK);//אולי להוסיף פה קטע קוד האם מעוניין להירשם
                password.Clear();
            }

            else
            {
                Global.employeeID = emp.get_id(); //current user
                Global.firstName = emp.get_firstName();//current first name
                //int dbValue = employeeType(emp.GetType());
                //string stringValue = Enum.GetName(typeof(EnumDisplayStatus), dbValue);
                Global.type = emp.get_StringType();
                if (emp.get_employeeType().ToString() == "logisticsManager")
                {
                    LogisticsManager_Screen log = new LogisticsManager_Screen();
                    log.Show();
                    this.Hide();
                }
                if (emp.get_employeeType().ToString() == "CEO")
                {
                    CEO_Screen cs = new CEO_Screen();
                    cs.Show();
                    this.Hide();
                }
                if (emp.get_employeeType().ToString() == "eventSetUpEmployee")
                {
                    eventSetUpEmployeeHomeScreen EU = new eventSetUpEmployeeHomeScreen();
                    EU.Show();
                    this.Hide();

                }
                if (emp.get_employeeType().ToString() == "eventDesigner")
                {
                    EventDesignerScreen ed = new EventDesignerScreen();
                    ed.Show();
                    this.Hide();

                }
            }
        }
        
    }
}
