using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace group28_1
{
    class Design
    {
        private long DesignID;
        private double price;
        public Dictionary<Product, int> product2;


        public Design(long DesignID, double price, bool is_new)
        {
            this.DesignID = DesignID;
            this.price = price;
            product2 = new Dictionary<Product, int>();
            this.createList();
            if (is_new)
            {
                this.create_design();
                Program.Designs.Add(this);
            }
        }
        public void remove_Design()
        {
            design_products y = Program.all_design_products.FirstOrDefault(p => p.get_designID().ToString() == this.get_DesignID().ToString());
            y.remove_design(); //delete from the design_product
            Program.Designs.Remove(this); //delete the design from the list 
            this.remove_design_SQL(); // remove the design from the sql
        }
        public void add_list(Dictionary<Product, int> productsNew)
        {
            this.product2 = productsNew;
            foreach (KeyValuePair<Product, int> x in product2)
            {
                design_products y = new design_products(this.DesignID, x.Key.get_prouductID(), x.Value, true);
            }
        }
        public void createList()
        {
            foreach (design_products dp in Program.all_design_products)
            {
                if (dp.get_designID() == this.get_DesignID())
                {
                    Product x = Program.Products.FirstOrDefault(product => product.get_prouductID().ToString() == dp.get_productID().ToString());
                    this.product2.Add(x, x.get_quantity());
                }
            }
        }
        public long get_DesignID()
        {
            return this.DesignID;
        }
        public double get_price()
        {
            return this.price;
        }
        public void set_price(double price)
        {
            this.price = price;
        }

        public void create_design()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_design @DesigniD ,@price";
            c.Parameters.AddWithValue("@DesigniD", this.DesignID);
            c.Parameters.AddWithValue("@price", this.price);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

        }
        public void update_design()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_update_design @DesigniD ,@price";
            c.Parameters.AddWithValue("@DesigniD", this.DesignID);
            c.Parameters.AddWithValue("@price", this.price);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void remove_design_SQL()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_remove_design @DesigniD";
            c.Parameters.AddWithValue("@DesigniD", this.DesignID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

        }


    }
}
