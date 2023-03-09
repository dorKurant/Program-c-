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
    public partial class View_Products : Form
    {
        public View_Products()
        {
            InitializeComponent();
        }

        private void View_Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_28DataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.sAD_28DataSet1.Product);
        }

        private void cboColumn_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            CRUD_Products cv = new CRUD_Products();
            cv.Show();
            this.Hide();
        }

        private void logOut_button_Click(object sender, EventArgs e)
        {
            Entry_Screen cv = new Entry_Screen();
            cv.Show();
            this.Hide();
        }

        private void cboColumn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
