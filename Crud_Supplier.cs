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
    public partial class Crud_Supplier : Form
    {
        public Crud_Supplier()
        {
            InitializeComponent();
        }

        private void add_Supplier_Click(object sender, EventArgs e)
        {
            Create_Supplier cs = new Create_Supplier();
            cs.Show();
            this.Hide();

        }

        private void view_Supplier_Click(object sender, EventArgs e)
        {
            View_Supplier vs = new View_Supplier();
            vs.Show();
            this.Hide();
        }

        private void sing_Out_Click(object sender, EventArgs e)
        {
            Entry_Screen cv = new Entry_Screen();
            cv.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            CEO_Screen lms = new CEO_Screen();
            lms.Show();
            this.Hide();
        }

        private void Crud_Supplier_Load(object sender, EventArgs e)
        {

        }

        private void archive_suppliers_button_Click(object sender, EventArgs e)
        {
            ARCHIVE_SUPPLIERS ars = new ARCHIVE_SUPPLIERS();
            ars.Show();
            this.Hide();
        }
    }
}