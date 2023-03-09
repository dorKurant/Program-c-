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

    public partial class View_Vehicle : Form
    {


        public View_Vehicle()
        {
            InitializeComponent();
            type_Combobox.DataSource = Enum.GetValues(typeof(vehicleType));//אתחול הקומבובוקס
            this.vehiclesTableAdapter.Fill(this.sAD_28DataSet1.Vehicles);
        }

        private void View_Vehicles_SQL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Vehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_28DataSet1.Vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.Fill(this.sAD_28DataSet1.Vehicles);
            // TODO: This line of code loads data into the 'sAD_28DataSet1.view_all_vehicle' table. You can move, or remove it, as needed.
            //this.view_all_vehicleTableAdapter.Fill(this.sAD_28DataSet1.view_all_vehicle);
        }

        private void Update_Vehicle_Button_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int mone = 0;
            if (!this.NullCheck()) //null able attributes check 
                return;
            if (!check_Year())
            {
                MessageBox.Show("שנת רכב לא בטווחים של 1990-2023", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!this.integerCheck()) //Input ID check
                return;
            if (this.nothingChanged()) //check if nothing changed
                return;
            foreach (vehicle i in Program.vehicles)
            {
                string oldVehicleNumber = i.get_vehicleNumber();
                if (mone == rowIndex)
                {

                    if (vehicleNumber_Textbox.Text != "")
                    {
                        i.set_vehicleNumber(vehicleNumber_Textbox.Text);
                    }
                    if (vehicleYear_Textbox.Text != "")
                        i.set_vechicleYear(Int32.Parse(vehicleYear_Textbox.Text));
                    if (kilometrage_Textbox.Text != "")
                        i.set_kilometrage(double.Parse(kilometrage_Textbox.Text.ToString()));
                    i.update_vehicle(oldVehicleNumber);
                    //this.vehiclesTableAdapter.Fill(this.sAD_28DataSet1.Vehicles);
                    // TODO: This line of code loads data into the 'sAD_28DataSet1.view_all_vehicle' table. You can move, or remove it, as needed.
                    Program.init_vehicles();
                    this.vehiclesTableAdapter.Fill(this.sAD_28DataSet1.Vehicles);
                    break;
                }
                mone++;
            }
        }

        private void Delete_Vehicle_Button_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int mone = 0;
            foreach (vehicle i in Program.vehicles)
            {

                if (mone == rowIndex)
                {
                    i.move_archive_vehicle();
                    this.vehiclesTableAdapter.Fill(this.sAD_28DataSet1.Vehicles);
                    // TODO: This line of code loads data into the 'sAD_28DataSet1.view_all_vehicle' table. You can move, or remove it, as needed.
                    //this.view_all_vehicleTableAdapter.Fill(this.sAD_28DataSet1.view_all_vehicle);
                    break;
                }
                mone++;
            }
        }
        private Boolean nothingChanged()
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string vn = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            string type = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            int vh = int.Parse(dataGridView1.Rows[rowIndex].Cells[2].Value.ToString());
            float kil = float.Parse(dataGridView1.Rows[rowIndex].Cells[3].Value.ToString());
            if (!vn.Equals(vehicleNumber_Textbox.Text))
                return false;
            if (!type.Equals(type_Combobox.Text))
                return false;
            if (vh != int.Parse(vehicleYear_Textbox.Text))
                return false;
            if (kil != float.Parse(kilometrage_Textbox.Text))
                return false;
            MessageBox.Show("לא שונה דבר");
            return true;//nothing changed
        }
        private void Return_Button_Click(object sender, EventArgs e)
        {
            Crud_Vehicles cv = new Crud_Vehicles();
            cv.Show();
            this.Hide();
        }

        private void vehicleNumber_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void type_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int mone = 0;
            foreach (vehicle i in Program.vehicles)
            {

                if (mone == rowIndex)
                {
                    vehicleNumber_Textbox.Text = i.get_vehicleNumber().ToString();
                    type_Combobox.Text = i.get_type().ToString();
                    vehicleYear_Textbox.Text = i.get_vechicleYear().ToString();
                    kilometrage_Textbox.Text = i.get_kilometrage().ToString();
                    break;
                }
                mone++;
            }
        }


        private Boolean integerCheck() //Input ID check
        {
            int parsedValue;//help variable
            if (!int.TryParse(vehicleNumber_Textbox.Text, out parsedValue)) //check if the input is a number
            {
                MessageBox.Show("מספר רכב' בפורמט לא תקין, אנא הכנס מספרים בלבד", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; //exit
            }
            if (!int.TryParse(kilometrage_Textbox.Text, out parsedValue)) //check if the input is a number
            {
                MessageBox.Show("קילומטרז' בפורמט לא תקין, אנא הכנס מספרים בלבד", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; //exit
            }
            if (double.Parse(kilometrage_Textbox.Text.ToString()) <= 0)
            {
                MessageBox.Show("קילומטרז' בפורמט לא תקין", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } //exit
            return true;
        }
        private Boolean NullCheck() //null able attributes check 
        {

            if (vehicleNumber_Textbox.Text == "" || vehicleYear_Textbox.Text == "" || kilometrage_Textbox.Text == "")
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
                if (vehicleYear_Textbox.Text == years[i].ToString())
                    return true;
            }
            return false;
        }

        /*private void cboColumn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }*/

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void cboColumn_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyDown_1(object sender, KeyEventArgs e)
        {
            
        }
    }
}
