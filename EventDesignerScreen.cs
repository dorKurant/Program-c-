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
    public partial class EventDesignerScreen : Form
    {
        public EventDesignerScreen()
        {
            InitializeComponent();
        }

        private void EventDesignerScreen_Load(object sender, EventArgs e)
        {

        }

        private void create_event_button_Click(object sender, EventArgs e)
        {
            Create_New_Event cne = new Create_New_Event();
            cne.Show();
            this.Hide();
        }

        private void customer_button_Click(object sender, EventArgs e)
        {
            CRUD_Customers cc = new CRUD_Customers();
            cc.Show();
            this.Hide();
        }

        private void view_events_button_Click(object sender, EventArgs e)
        {
            View_Events ve = new View_Events();
            ve.Show();
            this.Hide();
        }

        private void archive_customers_button_Click(object sender, EventArgs e)
        {
            ARCHIVE_CUSTOMERS ac = new ARCHIVE_CUSTOMERS();
            ac.Show();
            this.Hide();
        }

        private void sign_ouy_button_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            
        }

        private void update_design_Click(object sender, EventArgs e)
        {
            Update_Design ud = new Update_Design();
            ud.Show();
            this.Hide();
        }
    }
}