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
    public partial class Trace_on_financial_balance : Form
    {
        public Trace_on_financial_balance()
        {
            InitializeComponent();
            workers_salary.Hide();
            bids.Hide();
            orders.Hide();
            total.Hide();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Trace_on_financial_balance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_28DataSet1.Order_Expendiure' table. You can move, or remove it, as needed.
            this.order_ExpendiureTableAdapter.Fill(this.sAD_28DataSet1.Order_Expendiure);
            // TODO: This line of code loads data into the 'sAD_28DataSet1.Bids_Revenue' table. You can move, or remove it, as needed.
            this.bids_RevenueTableAdapter.Fill(this.sAD_28DataSet1.Bids_Revenue);
            // TODO: This line of code loads data into the 'sAD_28DataSet1.Bids' table. You can move, or remove it, as needed.
            this.bidsTableAdapter.Fill(this.sAD_28DataSet1.Bids);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void calc_buuton_Click(object sender, EventArgs e)
        {
            int year;
            double income = 0;
            double expendiure = 0;
            string input = year_textbox.Text;
            int result;
            bool isInteger = int.TryParse(input, out result);
            if (!isInteger)
            {
                MessageBox.Show("שנה יכולה להיות מספר בלבד", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                year = int.Parse(year_textbox.Text.ToString());
            }
            foreach (KeyValuePair<int, double> k in Program.income)
            {
                if (k.Key == year)
                {
                    income = k.Value;
                    break;
                }
            }
            foreach (KeyValuePair<int, double> k in Program.order_expendiure)
            {
                if (k.Key == year)
                {
                    expendiure = k.Value;
                    break;
                }
            }
            showSums();
            workers_salary.Text = calcSalary(year).ToString();
            bids.Text = income.ToString();
            orders.Text = expendiure.ToString();
            double outcome = income - expendiure - calcSalary(year);
            total.Text = outcome.ToString();
        }

        public double calcSalary(int year)
        {
            double sum = 0;
            foreach (Assignment a in Program.assignments)
            {
                if (a.GetStartTime() != null) {
                    DateTime k = (DateTime)a.GetStartTime();
                    int kyear = k.Year;
                    if (kyear == year)
                    {
                        DateTime x = DateTime.Parse(a.GetStartTime().ToString());
                        DateTime y = DateTime.Parse(a.GetEndTime().ToString());
                        TimeSpan duration = y - x;
                        double hours = duration.TotalHours;
                        employee e = Program.seekEmployee(long.Parse(a.GetEmployeeID().ToString()),true);
                        if (e != null)
                        {
                            double sal = e.get_salaryPerHour();
                            sum += (hours * sal);
                        }
                        else sum = 0;
                    }
                }
            }
            return sum;
        }

        public void showSums()
        {
            workers_salary.Show();
            bids.Show();
            orders.Show();
            total.Show();
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

        private void expendiure_Click(object sender, EventArgs e)
        {

        }
    }
}
