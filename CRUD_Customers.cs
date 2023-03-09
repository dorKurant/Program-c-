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
    public partial class CRUD_Customers : Form
    {
        public CRUD_Customers()
        {
            InitializeComponent();
        }

        private void create_New_Customer_button_Click(object sender, EventArgs e)
        {
            Add_New_Customer c = new Add_New_Customer();
            c.Show();
            this.Hide();
        }

        private void view_Customers_button_Click(object sender, EventArgs e)
        {
            View_Customers c = new View_Customers();
            c.Show();
            this.Hide();
        }

        private void CRUD_Customers_Load(object sender, EventArgs e)
        {

        }

        private void return_button_Click(object sender, EventArgs e)
        {
            if (Global.type.Equals("CEO"))
            {
                CEO_Screen CS = new CEO_Screen();
                CS.Show();
                this.Hide();
                return;
            }
            EventDesignerScreen ED = new EventDesignerScreen();
            ED.Show();
            this.Hide();
        }

        private void sign_out_button_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            ARCHIVE_CUSTOMERS ac = new ARCHIVE_CUSTOMERS();
            ac.Show();
            this.Hide();
        }
    }
}
