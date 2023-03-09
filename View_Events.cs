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
    public partial class View_Events : Form
    {
        public View_Events()
        {
            InitializeComponent();
        }

        private void View_Events_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_28DataSet1.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.sAD_28DataSet1.Events);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            EventDesignerScreen ev = new EventDesignerScreen();
            ev.Show();
            this.Hide();
        }

        private void sign_out_button_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();
        }
        private void cboColumn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}