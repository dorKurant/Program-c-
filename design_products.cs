using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace group28_1
{
    class design_products
    {
        private long DesignID;
        private String ProductID;
        private int quantity;



        public design_products(long DesignID, String productID, int quantity, bool is_new)
        {
            this.DesignID = DesignID;
            this.ProductID = productID;
            this.quantity = quantity;
            if (is_new)
            {
                this.create_design_product();
                Program.all_design_products.Add(this);
            }
        }
        public int get_quantity()
        {
            return this.quantity;
        }
        public void set_quantity(int quantity)
        {
            this.quantity = quantity;
        }
        public long get_designID()
        {
            return this.DesignID;
        }
        public String get_productID()
        {
            return this.ProductID;
        }
        public void set_productID(String ProductID)
        {
            this.ProductID = ProductID;
        }
        public void create_design_product()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = " dbo.SP_add_design_product @DesigniD ,@productID ,@quantity";
            c.Parameters.AddWithValue("@DesigniD", this.DesignID);
            c.Parameters.AddWithValue("@productID", this.ProductID.ToString());
            c.Parameters.AddWithValue("@quantity", this.quantity);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

        }
        public void update_design_product()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = " dbo.SP_update_design_product @DesigniD ,@productID,@quantity";
            c.Parameters.AddWithValue("@DesigniD", this.DesignID);
            c.Parameters.AddWithValue("@productID", this.ProductID.ToString());
            c.Parameters.AddWithValue("@quantity", this.quantity);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void delete_design_product()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = " dbo.SP_delete_design_product @DesigniD ,@productID";
            c.Parameters.AddWithValue("@DesigniD", this.DesignID);
            c.Parameters.AddWithValue("@productID", this.ProductID.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void remove_design_event()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = " dbo.SP_remove_design_event @DesigniD";
            c.Parameters.AddWithValue("@DesigniD", this.DesignID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

        }
        public void remove_design()
        {
            Program.all_design_products.Remove(this);
            remove_design_event();
        }


    }

}


