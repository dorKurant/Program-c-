using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace group28_1
{
    class Product
    {
        private string prouductID;
        private DateTime lastUsed; //להחליף לאינמורטור סוג מכוניתת
        private productStatus status;
        private int quantity;
        private productType type;
        private double rate;
        private DateTime rateDate;
        private double price;
        // public System.Collections.Generic.List<Order> orders;


        public Product(string prouductID, DateTime lastUsed, productStatus status, int quantity, productType type, double rate, DateTime rateDate, double price, bool is_new)
        {
            this.prouductID = prouductID;
            this.lastUsed = DateTime.Parse(lastUsed.ToString());//לבדוק שזה ממומר לתאריך+זמן פה בקוד
            this.status = status;
            this.quantity = quantity;
            this.type = type;
            this.rate = rate;
            this.rateDate = DateTime.Parse(rateDate.ToString());//לבדוק שזה ממומר לתאריך+זמן פה בקוד
            this.price = price;
            if (is_new)
            {
                this.create_product();
                Program.Products.Add(this);
            }
        }
        public void rate_product_popularity(int counter)
        {
            if (counter == 0)
            {
                if (this.get_rate() > 0)
                {
                    this.set_rate(this.get_rate() - 1);
                }
            }
            else if (counter == 3 || counter == 4)
            {
                if (this.get_rate() < 5)
                {
                    this.set_rate(this.get_rate() + 1);
                }
            }
            else if (counter >= 5)
            {
                if (this.get_rate() < 4)
                    this.set_rate(this.get_rate() + 2);
                else if (this.get_rate() == 4)
                    this.set_rate(5);
            }
            this.set_rateDate(DateTime.Now);
        }

        public string get_prouductID()
        {
            return this.prouductID;
        }
        public DateTime get_lastUsed()
        {
            return this.lastUsed;
        }
        public productStatus get_status()
        {
            return this.status;
        }
        public int get_quantity()
        {
            return this.quantity;
        }
        public productType get_type()
        {
            return this.type;
        }
        public double get_rate()
        {
            return this.rate;
        }
        public DateTime get_rateDate()
        {
            return this.rateDate;
        }
        public double get_price()
        {
            return this.price;
        }
        public void set_prouductID(string prouductID)
        {
            this.prouductID = prouductID;
        }
        public void update_lastUsed(DateTime lastUsed)
        {
            this.lastUsed = lastUsed;
            SP_update_product_withoutId();
        }
        public void set_status(productStatus s)
        {
            string status = s.ToString();
            this.status = s;
        }
        public void set_quantity(int quantity)
        {
            this.quantity = quantity;
        }
        public void set_type(productType type)
        {
            this.type = type;
        }
        public void set_rate(double rate)
        {
            this.rate = rate;

        }
        public void set_rateDate(DateTime rateDate)
        {
            this.rateDate = rateDate;
            SP_update_product_withoutId();

        }
        public void set_price(double price)
        {
            this.price = price;
        }
        public void create_product()//לעדכן לפרוצדורה שלנו
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_product  @ProductID , @LastUsed , @Status ,@Quantity, @Type, @Rate, @rateDate, @Price";
            c.Parameters.AddWithValue("@ProductID", this.prouductID);
            c.Parameters.AddWithValue("@LastUsed", this.lastUsed);
            c.Parameters.AddWithValue("@Status", this.status.ToString());
            c.Parameters.AddWithValue("@Quantity", this.quantity);
            c.Parameters.AddWithValue("@Type", this.type.ToString());
            c.Parameters.AddWithValue("@Rate", this.rate);
            c.Parameters.AddWithValue("@rateDate", this.rateDate);
            c.Parameters.AddWithValue("@Price", this.price);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void update_productID(string old_productId)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_update_product  @old_productId, @ProductID , @LastUsed , @Status ,@Quantity, @Type, @Rate, @rateDate, @Price";
            c.Parameters.AddWithValue("@old_productId", old_productId);
            c.Parameters.AddWithValue("@ProductID", this.prouductID);
            c.Parameters.AddWithValue("@LastUsed", this.lastUsed);
            c.Parameters.AddWithValue("@Status", this.status.ToString());
            c.Parameters.AddWithValue("@Quantity", this.quantity);
            c.Parameters.AddWithValue("@Type", this.type.ToString());
            c.Parameters.AddWithValue("@Rate", this.rate);
            c.Parameters.AddWithValue("@rateDate", this.rateDate);
            c.Parameters.AddWithValue("@Price", this.price);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void SP_update_product_withoutId()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_update_product_withoutId @ProductID , @LastUsed , @Status ,@Quantity, @Type, @Rate, @rateDate, @Price";
            c.Parameters.AddWithValue("@ProductID", this.prouductID);
            c.Parameters.AddWithValue("@LastUsed", this.lastUsed);
            c.Parameters.AddWithValue("@Status", this.status.ToString());
            c.Parameters.AddWithValue("@Quantity", this.quantity);
            c.Parameters.AddWithValue("@Type", this.type.ToString());
            c.Parameters.AddWithValue("@Rate", this.rate);
            c.Parameters.AddWithValue("@rateDate", this.rateDate);
            c.Parameters.AddWithValue("@Price", this.price);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void move_archive_product()//להוסיף טבלה של arcihve ולעשות פרוצדורה בהתאם
        {
            Program.Products.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_move_archive_product @ProductID";
            c.Parameters.AddWithValue("@ProductID", this.prouductID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}