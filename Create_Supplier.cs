using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace group28_1
{
    public partial class Create_Supplier : Form
    {
        public Create_Supplier()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (!NullCheck())
                return;
            if (!this.integerCheck()) //Input ID check
                return;
            if (!IsValidEmail(email.Text))// Mail check
            {
                MessageBox.Show("אימייל הוכנס בפורמט לא תקין", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string phoneNumberPattern = @"^[0-9]{3}[0-9]{3}[0-9]{4}$";
            if (Regex.IsMatch(phone.Text, phoneNumberPattern))
            {
                // The text in the textbox is a valid phone number
            }
            else
            {
                MessageBox.Show("מספר טלפון בפורמט לא תקין", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Program.seekSupplier(long.Parse(ID.Text.ToString())) != null)
            {
                MessageBox.Show("עובד זה קיים במערכת, אנא הכנס עובד אחר", "", MessageBoxButtons.OK);
            }
            else
            {
                Supplier S = new Supplier(long.Parse(ID.Text.ToString()), supplier_Name.Text, email.Text, phone.Text, true);//יצירת רכב חדש
                Crud_Supplier cv = new Crud_Supplier();
                cv.Show();
                this.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Crud_Supplier cs = new Crud_Supplier();
            cs.Show();
            this.Hide();
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplier_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void sing_Out_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();
        }

        private Boolean integerCheck() //Input ID check
        {
            int parsedValue;//help variable
            if (!int.TryParse(ID.Text, out parsedValue)) //check if the input is a number
            {
                MessageBox.Show("מזהה ספק לא תקין, אנא הכנס מספרים בלבד", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; //exit
            }
            return true;
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
        private void Create_Supplier_Load(object sender, EventArgs e)
        {

        }

        private Boolean NullCheck() //null able attributes check 
        {

            if (ID.Text == "" || supplier_Name.Text == "" || email.Text == "" || phone.Text == "")
            {
                MessageBox.Show("אין להזין שדות ריקים", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }//invalid input
            return true;
        }
    }
}