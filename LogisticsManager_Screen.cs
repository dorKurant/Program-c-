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
    public partial class LogisticsManager_Screen : Form
    {
        public LogisticsManager_Screen()
        {
            InitializeComponent();
        }

        private void product_Click(object sender, EventArgs e)
        {
            CRUD_Products cp = new CRUD_Products();
            cp.Show();
            this.Hide();
        }

        private void vehicle_Click(object sender, EventArgs e)
        {
            Crud_Vehicles cv = new Crud_Vehicles();
            cv.Show();
            this.Hide();
        }

        private void sing_Out_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void LogisticsManager_Screen_Load(object sender, EventArgs e)
        {

        }

        private void return_button_Click(object sender, EventArgs e)
        {

        }

        private void report_Click(object sender, EventArgs e)
        {
            ChooseProductReportScreen cs = new ChooseProductReportScreen();
            cs.Show();
            this.Hide();
        }
    }
}