using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace group28_1
{
    class Bid

    {
        private string bidID;
        private DateTime date;
        private double totalPrice;
        private double discountRate;
        private double initialPrice;
        private Boolean approval;
        private long? CustomerID;
        private string eventID;

        public Bid(string bidID, DateTime date, double initialPrice, double discountRate, double totalPrice, Boolean approval, long? customerID, string eventID, Boolean is_new)
        {
            this.bidID = bidID;
            this.date = date;
            this.initialPrice = initialPrice;
            this.discountRate = discountRate;
            this.totalPrice = totalPrice;
            this.approval = approval;
            this.CustomerID = customerID;
            this.eventID = eventID;
            calculate_Bid();
            if (is_new == true)
            {
                this.create_Bid();
                Program.bids.Add(this);
            }

        }
        // GETTERS
        public string get_bidID()
        {
            return this.bidID;
        }

        public DateTime get_date()
        {
            return this.date;
        }

        public double get_totalPrice()
        {
            return this.totalPrice;
        }

        public double get_discountRate()
        {
            return this.discountRate;
        }
        public double get_initialPrice()
        {
            return this.initialPrice;
        }

        public Boolean get_approval()
        {
            return this.approval;
        }

        public long? get_customerID()
        {
            return this.CustomerID;
        }
        public string get_eventID()
        {
            return this.eventID;
        }
        // SETTERS
        public void set_bidID(string bidID)
        {
            this.bidID = bidID;
        }

        public void set_date(DateTime date)
        {
            this.date = date;
        }

        public void set_totalPrice(double totalPrice)
        {
            this.totalPrice = totalPrice;
        }

        private void set_discountRate(double discountRate)
        {
            this.discountRate = discountRate;
        }

        public void set_initialPrice(double initialPrice)
        {
            this.initialPrice = initialPrice;
        }

        public void set_approval(Boolean approval)
        {
            this.approval = approval;
        }

        public void set_customerID(long customerID)
        {
            this.CustomerID = customerID;
        }
        public void set_eventID(string eventID)
        {
            this.eventID = eventID;
        }
        private void check_discountRate()//כרגע לא בשימוש כרגע למחוק
        {
            foreach (Customer i in Program.customers)
            {
                if (i.get_id() == this.CustomerID && i.get_type().ToString() == "returningCustomer")
                    this.discountRate = 0.15;
            }
        }
        public void calculate_Bid()
        {
            foreach (Customer i in Program.customers)
            {
                if (i.get_id() == this.CustomerID && i.get_type().ToString() == "returningCustomer")
                {
                    this.discountRate = 0.1;
                    this.totalPrice = this.totalPrice * (1 - 0.1);
                }
            }
            //foreach (Event e in Program.Events)
            //{
            foreach (Design_event de in Program.all_design_event)
            {
                if (de.get_eventID() == this.eventID)//must
                {
                    foreach (Design d in Program.Designs)
                    {
                        if (de.get_designID() == d.get_DesignID())//must
                        {
                            foreach (Product p in d.product2.Keys)
                            {
                                if (p.get_rate() == 1)
                                {
                                    this.discountRate = this.discountRate + 0.05;
                                    this.totalPrice = this.totalPrice * (1 - 0.05);
                                }
                                else if (p.get_rate() == 2)
                                {
                                    this.discountRate = this.discountRate + 0.03;
                                    this.totalPrice = this.totalPrice * (1 - 0.03);
                                }
                                else if (p.get_rate() == 4)
                                {
                                    if (this.discountRate > 0.03)
                                        this.discountRate = this.discountRate - 0.03;
                                    else
                                        this.discountRate = 0;
                                    this.totalPrice = this.totalPrice * (1 + 0.03);
                                }
                                else if (p.get_rate() == 5)
                                {
                                    if (this.discountRate > 0.05)
                                        this.discountRate = this.discountRate - 0.05;
                                    else
                                        this.discountRate = 0;
                                    this.totalPrice = this.totalPrice * (1 + 0.05);
                                }
                            }
                        }
                    }
                }
            }
            //} 
        }
        // PROCEDURES
        public void create_Bid()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Add_Bid @bidID, @date, @totalPrice, @discountRate, @initialPrice, @approval, @customerID, @eventID";
            c.Parameters.AddWithValue("@bidID", this.bidID);
            c.Parameters.AddWithValue("@date", DateTime.Parse(this.date.ToString()));
            c.Parameters.AddWithValue("@totalPrice", double.Parse(this.totalPrice.ToString()));
            c.Parameters.AddWithValue("@discountRate", double.Parse(this.discountRate.ToString()));
            c.Parameters.AddWithValue("@initialPrice", double.Parse(this.initialPrice.ToString()));
            c.Parameters.AddWithValue("@approval", Boolean.Parse(this.approval.ToString()));
            c.Parameters.AddWithValue("@customerID", long.Parse(this.CustomerID.ToString()));
            c.Parameters.AddWithValue("@eventID", this.eventID.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_Bid()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Bid @bidID, @date, @totalPrice, @discountRate, @initialPrice, @approval, @customerID, @eventID";
            c.Parameters.AddWithValue("@bidID", this.bidID);
            c.Parameters.AddWithValue("@date", DateTime.Parse(this.date.ToString()));
            c.Parameters.AddWithValue("@totalPrice", double.Parse(this.totalPrice.ToString()));
            c.Parameters.AddWithValue("@discountRate", double.Parse(this.discountRate.ToString()));
            c.Parameters.AddWithValue("@initialPrice", double.Parse(this.initialPrice.ToString()));
            c.Parameters.AddWithValue("@approval", Boolean.Parse(this.approval.ToString()));
            c.Parameters.AddWithValue("@customerID", long.Parse(this.CustomerID.ToString()));
            c.Parameters.AddWithValue("@eventID", this.eventID.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void delete_Bid()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Delete_Bid @bidID";
            c.Parameters.AddWithValue("@bidID", this.bidID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}