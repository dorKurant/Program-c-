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
    public partial class eventSetUpEmployeeHomeScreen : Form
    {
        public eventSetUpEmployeeHomeScreen()
        {
            InitializeComponent();
            label1.Text = Global.firstName+" "+ " הבא ברוך";
        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            assignToEvent ATE = new assignToEvent();
            ATE.Show();
            this.Hide();
        }

        private void eventSetUpEmployeeHomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();
        }
    }
}
