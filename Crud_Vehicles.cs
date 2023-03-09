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
    public partial class Crud_Vehicles : Form
    {
        public Crud_Vehicles()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void creat_Car_Click(object sender, EventArgs e)
        {
            Create_Vehicle vc = new Create_Vehicle();
            vc.Show();
            this.Hide();
        }

        private void view_Vehicles_Click(object sender, EventArgs e)
        {
            View_Vehicle vv = new View_Vehicle();
            vv.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();
        }

        private void Manag_Vehicle_TextChanged(object sender, EventArgs e)
        {

        }

        private void manage_Vehicle_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            LogisticsManager_Screen lms = new LogisticsManager_Screen();
            lms.Show();
            this.Hide();
        }

        private void vehice_archive_button_Click(object sender, EventArgs e)
        {
            ARCHIVE_VEHICLES arv = new ARCHIVE_VEHICLES();
            arv.Show();
            this.Hide();
        }
    }
}
