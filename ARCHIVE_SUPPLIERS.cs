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
    public partial class ARCHIVE_SUPPLIERS : Form
    {
        public ARCHIVE_SUPPLIERS()
        {
            InitializeComponent();
        }

        private void ARCHIVE_SUPPLIERS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_28DataSet1.ARCHIVE_SUPPLIER' table. You can move, or remove it, as needed.
            this.aRCHIVE_SUPPLIERTableAdapter.Fill(this.sAD_28DataSet1.ARCHIVE_SUPPLIER);
        }
        private Boolean integerCheck()
        {
            int parsedValue;//help variable
            if (!int.TryParse(SupplierID_textBox.Text, out parsedValue)) //check if the input is a number
            {
                MessageBox.Show("This is a number only field");
                return false; //exit
            }
            return true;
        }
        private void outOfArchive_click_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SupplierID_textBox.Text))//empty
            {
                MessageBox.Show("Please enter a supplier ID");
                return;
            }
            if (!this.integerCheck()) //integer only check
                return;
            long SupplierID = Int32.Parse(SupplierID_textBox.Text);
            foreach (Supplier i in Program.archive_suppliers)
            {
                if (i.get_supplierID() == SupplierID)
                {
                    i.return_archive_Supplier();
                    this.aRCHIVE_SUPPLIERTableAdapter.Fill(this.sAD_28DataSet1.ARCHIVE_SUPPLIER);
                    return;
                }
            }
            MessageBox.Show("Supplier not found");
            this.aRCHIVE_SUPPLIERTableAdapter.Fill(this.sAD_28DataSet1.ARCHIVE_SUPPLIER);

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Crud_Supplier CS = new Crud_Supplier();
            CS.Show();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Entry_Screen ES = new Entry_Screen();
            ES.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboColumn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
