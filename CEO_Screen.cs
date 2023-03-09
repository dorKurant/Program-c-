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
    public partial class CEO_Screen : Form
    {
        public CEO_Screen()
        {
            InitializeComponent();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            CRUD_Customers CC = new CRUD_Customers();
            CC.Show();
            this.Hide();
        }

        private void employee_Click(object sender, EventArgs e)
        {
            CRUD_Employees ce = new CRUD_Employees();
            ce.Show();
            this.Hide();
        }

        private void supplier_Click(object sender, EventArgs e)
        {
            Crud_Supplier cs = new Crud_Supplier();
            cs.Show();
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

        private void CEO_Screen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ARCHIVE_CUSTOMERS ac = new ARCHIVE_CUSTOMERS();
            ac.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ARCHIVE_EMPLOYEES ae = new ARCHIVE_EMPLOYEES();
            ae.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ARCHIVE_SUPPLIERS ass = new ARCHIVE_SUPPLIERS();
            ass.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void prudoct_Click(object sender, EventArgs e)
        {
            ChooseProductReportScreen cs = new ChooseProductReportScreen();
            cs.Show();
            this.Hide();
        }

        private void balance_Click(object sender, EventArgs e)
        {
            Trace_on_financial_balance tr = new Trace_on_financial_balance();
            tr.Show();
            this.Hide();
        }
    }
}