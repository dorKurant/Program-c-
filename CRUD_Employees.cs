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
    public partial class CRUD_Employees : Form
    {
        public CRUD_Employees()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateNewemployee c = new CreateNewemployee();
            c.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View_Employees ve = new View_Employees();
            ve.Show();
            this.Hide();
        }

        private void CRUD_Employees_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            CEO_Screen cs = new CEO_Screen();
            cs.Show();
            this.Hide();
        }

        private void sign_out_button_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();
        }

        private void archive_Click(object sender, EventArgs e)
        {
            ARCHIVE_EMPLOYEES ae = new ARCHIVE_EMPLOYEES();
            ae.Show();
            this.Hide();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            CEO_Screen cs = new CEO_Screen();
            cs.Show();
            this.Hide();
        }
    }
}
