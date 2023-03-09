using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group28_1
{
    public partial class Create_Vehicle : Form
    {
        public Create_Vehicle()
        {
            InitializeComponent();
            vehicle_Type.DataSource = Enum.GetValues(typeof(vehicleType));//אתחול הקומבובוקס
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void number_TextChanged(object sender, EventArgs e)
        {

        }

        private void vehicle_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vehicle_Year_TextChanged(object sender, EventArgs e)
        {

        }

        private void km_Vehicle_TextChanged(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (!this.NullCheck()) //null able attributes check 
                return;
            if (!check_Year())
            {
                MessageBox.Show("שנת רכב לא בטווחים של 1990-2023", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!this.integerCheck()) //Input ID check
                return;
            if (Program.seekvehicle(number.Text) != null)
            {
                MessageBox.Show("רכב זה כבר קיים במערכת", "", MessageBoxButtons.OK);
            }
            else
            {
                vehicle v = new vehicle(number.Text, (vehicleType)Enum.Parse(typeof(vehicleType), vehicle_Type.Text), int.Parse(vehicle_Year.Text.ToString()), int.Parse(km_Vehicle.Text.ToString()), true);//יצירת רכב חדש
                Crud_Vehicles cv = new Crud_Vehicles();
                cv.Show();
                this.Close();
            }
        }

        private void Create_Vehicle_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Crud_Vehicles c = new Crud_Vehicles();
            c.Show();
            this.Hide();
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
            if (!int.TryParse(number.Text, out parsedValue)) //check if the input is a number
            {
                MessageBox.Show("מספר רכב' בפורמט לא תקין, אנא הכנס מספרים בלבד", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; //exit
            }
            if (!int.TryParse(km_Vehicle.Text, out parsedValue)) //check if the input is a number
            {
                MessageBox.Show("קילומטרז' בפורמט לא תקין, אנא הכנס מספרים בלבד", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; //exit
            }

            return true;
        }
        private Boolean NullCheck() //null able attributes check 
        {

            if (number.Text == "" || vehicle_Year.Text == "" || km_Vehicle.Text == "")
            {
                MessageBox.Show("אין להזין שדות ריקים", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }//invalid input
            return true;
        }
        private Boolean check_Year()
        {
            int startYear = 1990;
            int endYear = 2023;
            int[] years = new int[endYear - startYear + 1];
            for (int i = 0; i < years.Length; i++)
            {
                years[i] = startYear + i;
            }
            for (int i = 0; i < years.Length; i++)
            {
                if (vehicle_Year.Text == years[i].ToString())
                    return true;
            }
            return false;
        }
    }
}