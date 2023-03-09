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
    public partial class ChooseProductReportScreen : Form
    {
        public static string productType;
        public static DateTime date;

        public ChooseProductReportScreen()
        {
            InitializeComponent();
            chooseProduct.DataSource = Enum.GetValues(typeof(productType));//choose product
            chooseStartDate.MaxDate = DateTime.Today;
        }

        private void ChooseProductReportScreen_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void createReport_Click(object sender, EventArgs e)
        {
            productType p = (productType)chooseProduct.SelectedItem;
            DateTime d = chooseStartDate.Value;
            productType = p.ToString();
            date = d;
            Product_Report_Screen prs = new Product_Report_Screen();
            prs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Global.type.Equals("CEO"))
            {
                CEO_Screen CS = new CEO_Screen();
                CS.Show();
                this.Hide();
                return;
            }
            LogisticsManager_Screen ED = new LogisticsManager_Screen();
            ED.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();
        }
    }
}
