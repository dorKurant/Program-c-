using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group28_1
{
    class OrderedProduct
    {
        private string OrderID;
        private string ProductID;
        private int Quantity;
        private DateTime date;
        private float pricePerUnit;
        private string type;

        public OrderedProduct(string OrderID, string ProductID, int Quantity)
        {
            this.OrderID = OrderID;
            this.ProductID = ProductID;
            foreach (Product p in Program.Products)
            {
                if (this.ProductID.Equals(p.get_prouductID()))
                {
                    this.set_type(p.get_type().ToString());
                    break;
                }
            }
            this.Quantity = Quantity;
        }
        public string get_orderID()
        {
            return this.OrderID;
        }
        public float get_totalPrice()
        {
            return this.Quantity * this.pricePerUnit;
        }
        public string get_ProductID()
        {
            return this.ProductID;

        }
        public int get_Quantity()
        {
            return this.Quantity;
        }
        public string get_Type()
        {
            return this.type;
        }
        public DateTime get_date()
        {
            return this.date;
        }
        public void set_type(string pt)
        {
            this.type = pt;
        }
        public void set_orderID(string o)
        {
            this.OrderID = o;
        }
        public void set_Price_per_unit(float p)
        {
            this.pricePerUnit = p;
        }
        public void set_ProductID(string p)
        {
            this.ProductID = p;

        }
        public void set_Quantity(int q)
        {
            this.Quantity = q;
        }
        public void set_date(DateTime d)
        {
            this.date = d;
        }
    }
}
