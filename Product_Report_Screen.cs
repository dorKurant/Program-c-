using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace group28_1
{
    public partial class Product_Report_Screen : Form
    {
        public Product_Report_Screen()
        {
            InitializeComponent();
            productname.Hide(); 
            orderNum.Hide();
            ordersCost.Hide();
            numOfChoose.Hide();
            incomeFromProduct.Hide();
            totalRevenue.Hide();
            popularity.Hide();
            popularityDate.Hide();
            this.initValues();
        }

        private void Product_Report_Screen_Load(object sender, EventArgs e)
        {
        }
        private void initValues()
        {
            DateTime fromDate = ChooseProductReportScreen.date;
            string ChoosenProduct = ChooseProductReportScreen.productType;
            this.OrderNum_ordersCost(fromDate, ChoosenProduct);
            this.numOfChoose_incomeFromProduct(fromDate, ChoosenProduct);
            totalRevenue.Text = (double.Parse(incomeFromProduct.Text.ToString()) - double.Parse(ordersCost.Text.ToString())).ToString();
            totalRevenue.Show();
            foreach (Product pro in Program.Products)
            {
                if (pro.get_type().ToString() == ChoosenProduct)
                {
                    productname.Text = pro.get_type().ToString();
                    productname.Show();
                    popularity.Text = pro.get_rate().ToString();
                    popularity.Show();
                    popularityDate.Text = pro.get_rateDate().ToString();
                    popularityDate.Show();
                }

            }
        }
        private void OrderNum_ordersCost(DateTime fromDate, string ChoosenProduct) //count num of unit tha has been ordered
        {
            int countNum = 0;
            float orderCost = 0;
            foreach (OrderedProduct op in Program.orderedProducts)
            {
                if (op.get_date() >= fromDate & op.get_Type().Equals(ChoosenProduct)) //
                {
                    countNum += op.get_Quantity();//update quantity
                    orderCost += op.get_totalPrice();//update total price
                }
            }
            orderNum.Text = countNum.ToString();
            orderNum.Show();
            ordersCost.Text = orderCost.ToString();
            ordersCost.Show();
        }
        private void numOfChoose_incomeFromProduct(DateTime fromDate, string ChoosenProduct)
        {
            int NOF = 0; //num of choosed
            double IFP = 0;//income from product
            Boolean flag = false;//help variable
            foreach (Event e in Program.Events)
            {
                flag = false;
                if (e.get_date() > fromDate)
                {
                    foreach (Design_event de in Program.all_design_event)
                    {
                        if (flag)
                            break;
                        if (de.get_eventID().ToString() == e.get_eventID().ToString())// SAME EVENT
                        {
                            foreach (Design d in Program.Designs)
                            {
                                if (flag)
                                    break;
                                if (de.get_designID().ToString() == d.get_DesignID().ToString())
                                {
                                    foreach (Product p in d.product2.Keys)//כל המוצרים בעיצוב
                                    {
                                        if (flag)
                                            break;
                                        if (p.get_type().ToString() == ChoosenProduct)
                                        {
                                            NOF++;
                                            IFP += this.incomeFromProduct1(p, d, de, e);//הכנסות ממוצר מסוים באירוע מסוים
                                            flag = true;
                                            continue;

                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
            numOfChoose.Text = NOF.ToString();
            incomeFromProduct.Text = IFP.ToString();
            numOfChoose.Show();
            incomeFromProduct.Show();
        }

        private double incomeFromProduct1(Product p, Design d, Design_event de, Event e)
        {
            double ans = 0.0;
            int eachDesign = 0;
            int numOfDesign = 0;
            eachDesign = d.product2[p];
            numOfDesign += de.get_quantity();
            double sum = numOfDesign * eachDesign; //איך ייתכן שמופיע 20 * 5
            return sum;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChooseProductReportScreen CC = new ChooseProductReportScreen();
            CC.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ChooseProductReportScreen cs = new ChooseProductReportScreen();
            cs.Show();
            this.Hide();
        }
    }
}