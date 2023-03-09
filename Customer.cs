using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group28_1
{
    class Customer
    {
        private long id;
        private string email;
        private string phoneNumber;
        private string firstName;
        private string lastName;
        private customerType type;

        public Customer(long id, string email, string phoneNumber, string firstName, string lastName, customerType type, bool is_new)
        {
            this.id = id;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.type = type;
            if (is_new == true)
            {
                this.create_Customer();
                Program.customers.Add(this);
            }
        }

        // CUSTOMERS GETTERS
        public long get_id()
        {
            return this.id;
        }

        public string get_email()
        {
            return this.email;
        }

        public string get_phoneNumber()
        {
            return this.phoneNumber;
        }

        public string get_firstName()
        {
            return this.firstName;
        }

        public string get_lastName()
        {
            return this.lastName;
        }

        public customerType get_type()
        {
            return this.type;
        }

        // CUSTOMERS SETTERS
        public void set_id(long id)
        {
            this.id = id;
        }

        public void set_email(string email)
        {
            this.email = email;
        }

        public void set_phoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public void set_firstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void set_lastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void set_type(customerType type)
        {
            this.type = type;
        }


        //PROCEDURES 

        public void create_Customer()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Add_Customer @id, @email, @phoneNumber ,@firstName , @lastName, @type";
            c.Parameters.AddWithValue("@id", this.id);
            c.Parameters.AddWithValue("@email", this.email.ToString());
            c.Parameters.AddWithValue("@phoneNumber", this.phoneNumber.ToString());
            c.Parameters.AddWithValue("@firstName", this.firstName.ToString());
            c.Parameters.AddWithValue("@lastName", this.lastName.ToString());
            c.Parameters.AddWithValue("@type", this.type.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void update_CustomerID (long old_id) //update customer ID
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_CustomerID @old_id, @newid, @email, @phoneNumber ,@firstName , @lastName, @type";
            c.Parameters.AddWithValue("@old_id", old_id);
            c.Parameters.AddWithValue("@newid", this.id);
            c.Parameters.AddWithValue("@email", this.email.ToString());
            c.Parameters.AddWithValue("@phoneNumber", this.phoneNumber.ToString());
            c.Parameters.AddWithValue("@firstName", this.firstName.ToString());
            c.Parameters.AddWithValue("@lastName", this.lastName.ToString());
            c.Parameters.AddWithValue("@type", this.type.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void update_Customer(long old_id)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Customer @id, @email, @phoneNumber ,@firstName , @lastName, @type";
            //c.Parameters.AddWithValue("@old_id", old_id);
            c.Parameters.AddWithValue("@id", this.id);
            c.Parameters.AddWithValue("@email", this.email.ToString());
            c.Parameters.AddWithValue("@phoneNumber", this.phoneNumber.ToString());
            c.Parameters.AddWithValue("@firstName", this.firstName.ToString());
            c.Parameters.AddWithValue("@lastName", this.lastName.ToString());
            c.Parameters.AddWithValue("@type", this.type.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void move_archive_customers()
        {
            Program.customers.Remove(this);
            Program.archive_customers.Add(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_move_archive_customers @id, @email, @phoneNumber ,@firstName , @lastName, @type";
            c.Parameters.AddWithValue("@id", this.id);
            c.Parameters.AddWithValue("@email", this.email.ToString());
            c.Parameters.AddWithValue("@phoneNumber", this.phoneNumber.ToString());
            c.Parameters.AddWithValue("@firstName", this.firstName.ToString());
            c.Parameters.AddWithValue("@lastName", this.lastName.ToString());
            c.Parameters.AddWithValue("@type", this.type.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        /// <summary>
        /// 
        /// </summary>
        public void return_archive_customers() //return customer from archive 
        {
            Program.archive_customers.Remove(this);
            Program.customers.Add(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_return_archive_Customer @id, @email, @phoneNumber ,@firstName , @lastName, @type";
            c.Parameters.AddWithValue("@id", this.id);
            c.Parameters.AddWithValue("@email", this.email.ToString());
            c.Parameters.AddWithValue("@phoneNumber", this.phoneNumber.ToString());
            c.Parameters.AddWithValue("@firstName", this.firstName.ToString());
            c.Parameters.AddWithValue("@lastName", this.lastName.ToString());
            c.Parameters.AddWithValue("@type", this.type.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        ///
    }


}