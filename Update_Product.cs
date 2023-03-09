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
    public partial class Update_Product : Form
    {
        public Update_Product()
        {
            InitializeComponent();
            productType.DataSource = Enum.GetValues(typeof(productType));
        }

        private void Add_New_Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_28DataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.sAD_28DataSet1.Product);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void new_product_lable_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Update_click_Click(object sender, EventArgs e)
        {
            if (!this.integerCheck()) //not int
            {
                return;
            }
            foreach (Product p in Program.Products) //loop
            {
                if (p.get_type() == (productType)productType.SelectedItem) //same type
                {
                    if (Int32.Parse(quantityTextBox.Text.ToString()) < 0) //reduce quantity 
                    {
                        int absQuantity; //help variable
                        absQuantity = Math.Abs(Int32.Parse(quantityTextBox.Text.ToString()));
                        if (p.get_quantity() < absQuantity) //unvalid
                        {
                            MessageBox.Show("not possible - Quantity below '0'");
                            return;
                        }
                        else //valid
                        {
                            p.set_quantity(p.get_quantity() - absQuantity); //update quantity
                            if (p.get_quantity() == 0)
                            {
                                p.set_status(productStatus.out_of_stock);
                            }
                            p.SP_update_product_withoutId();
                            this.productTableAdapter.Fill(this.sAD_28DataSet1.Product);

                            return;
                        }
                    }
                    p.set_quantity(p.get_quantity() + Int32.Parse(quantityTextBox.Text.ToString())); //update quantity
                    p.set_status(productStatus.in_stock);//make sure in case of was out of stock
                    p.SP_update_product_withoutId();//update
                    this.productTableAdapter.Fill(this.sAD_28DataSet1.Product);

                    return;
                }
            }
            this.productTableAdapter.Fill(this.sAD_28DataSet1.Product);

        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void productType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private Boolean integerCheck()
        {
            int parsedValue;//help variable
            if (!int.TryParse(quantityTextBox.Text, out parsedValue)) //check if the input is a number
            {
                MessageBox.Show("This is a number only field");
                return false; //exit
            }
            return true;
        }
        private void BackButton_Click_1(object sender, EventArgs e)
        {
            CRUD_Products cv = new CRUD_Products();
            cv.Show();
            this.Hide();
        }

        private void logOut_button_Click_1(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //private void productType_SelectedIndexChanged(object sender, EventArgs e)
        // {
        //}

        //private void quantityTextBox_TextChanged(object sender, EventArgs e)
        //{
        //}
    }
}