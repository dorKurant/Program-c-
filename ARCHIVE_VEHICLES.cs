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
    public partial class ARCHIVE_VEHICLES : Form
    {
        public ARCHIVE_VEHICLES()
        {
            InitializeComponent();
        }

        private void ARCHIVE_VEHICLES_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_28DataSet1.ARCHIVE_VEHICLES' table. You can move, or remove it, as needed.
            this.aRCHIVE_VEHICLESTableAdapter.Fill(this.sAD_28DataSet1.ARCHIVE_VEHICLES);
        }

        private void outOfArchive_click_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vehicleNumber_textBox.Text))//empty
            {
                MessageBox.Show("Please enter a vehicle number");
                return;
            }
            string vehicleNumber = vehicleNumber_textBox.Text; //varchar
            foreach (vehicle i in Program.archive_vehicles)
            {

                if (i.get_vehicleNumber().Equals(vehicleNumber))
                {
                    i.return_archive_vehicle();
                    this.aRCHIVE_VEHICLESTableAdapter.Fill(this.sAD_28DataSet1.ARCHIVE_VEHICLES);
                    return;
                }
            }
            MessageBox.Show("Vehicle not found");
            this.aRCHIVE_VEHICLESTableAdapter.Fill(this.sAD_28DataSet1.ARCHIVE_VEHICLES);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crud_Vehicles LM = new Crud_Vehicles();
            LM.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entry_Screen ES = new Entry_Screen();
            ES.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboColumn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
