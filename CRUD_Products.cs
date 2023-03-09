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
    public partial class CRUD_Products : Form
    {
        public CRUD_Products()
        {
            InitializeComponent();

        }

        private void add_product_click_Click(object sender, EventArgs e)
        {
            Update_Product cv = new Update_Product();
            cv.Show();
            this.Hide();
        }

        private void CRUD_Products_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void view_Products_Button_Click(object sender, EventArgs e)
        {
          View_Products cv = new View_Products();
          cv.Show();
           this.Hide();
        }

        private void back_Button_Click(object sender, EventArgs e)
        {
            LogisticsManager_Screen lms = new LogisticsManager_Screen();
            lms.Show();
            this.Hide();
        }

        private void logOut_button_Click(object sender, EventArgs e)
        {
            Entry_Screen cv = new Entry_Screen();
            cv.Show();
            this.Hide();
        }
    }
}