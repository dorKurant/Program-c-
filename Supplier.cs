using System;
using System.Data.SqlClient;
namespace group28_1
{
    class Supplier
    {
        private long supplierID;
        private string supplierName;
        private string email;
        private string phone;
        public Supplier(long supplierID, string supplierName, string email, string phone, bool is_new)
        {
            this.supplierID = supplierID;
            this.supplierName = supplierName;
            this.email = email;
            this.phone = phone;
            if (is_new)
            {
                this.create_Supplier();
                Program.suppliers.Add(this);
            }
        }
        public long get_supplierID()
        {
            return this.supplierID;
        }
        public void set_supplierID(long supplierID)
        {
            this.supplierID = supplierID;
        }
        public string get_supplierName()
        {
            return this.supplierName;
        }
        public void set_supplierName(string supplierName)
        {
            this.supplierName = supplierName;
        }
        public void set_email(string email)
        {
            this.email = email;
        }
        public string get_email()
        {
            return this.email;
        }
        public void set_phone(string phone)
        {
            this.phone = phone;
        }
        public string get_phone()
        {
            return this.phone;
        }
        public void create_Supplier()//לעדכן לפרוצדורה שלנו
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_supplier @SupplierID, @SupplierName, @Email, @Phone";
            c.Parameters.AddWithValue("@supplierID", this.supplierID);
            c.Parameters.AddWithValue("@SupplierName", this.supplierName.ToString());
            c.Parameters.AddWithValue("@email", this.email.ToString());
            c.Parameters.AddWithValue("@phone", this.phone.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void update_supplierID(long oldSupplierID)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_SupplierID @oldSupplierID , @newSupplierid , @SupplierName , @Email , @Phone ";
            c.Parameters.AddWithValue("@oldSupplierID", oldSupplierID);
            c.Parameters.AddWithValue("@newSupplierid", this.supplierID);
            c.Parameters.AddWithValue("@SupplierName", this.supplierName.ToString());
            c.Parameters.AddWithValue("@Email", this.email.ToString());
            c.Parameters.AddWithValue("@Phone", this.phone.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void update_Supplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "dbo.SP_Update_Supplier @SupplierID, @SupplierName, @Email, @Phone";
            c.Parameters.AddWithValue("@SupplierID", this.supplierID);
            c.Parameters.AddWithValue("@SupplierName", this.supplierName.ToString());
            c.Parameters.AddWithValue("@Email", this.email.ToString());
            c.Parameters.AddWithValue("@Phone", this.phone.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void move_archive_Supplier()//להוסיף טבלה של arcihve ולעשות פרוצדורה בהתאם
        {
            Program.suppliers.Remove(this);
            Program.archive_suppliers.Add(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_move_archive_supplier @SupplierID, @SupplierName, @Email, @Phone ";
            c.Parameters.AddWithValue("@SupplierID", this.supplierID);
            c.Parameters.AddWithValue("@SupplierName", this.supplierName.ToString());
            c.Parameters.AddWithValue("@Email", this.email.ToString());
            c.Parameters.AddWithValue("@Phone", this.phone.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void return_archive_Supplier()//להוסיף טבלה של arcihve ולעשות פרוצדורה בהתאם
        {
            Program.archive_suppliers.Remove(this);
            Program.suppliers.Add(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_return_archive_supplier @SupplierID, @SupplierName, @Email, @Phone ";
            c.Parameters.AddWithValue("@supplierID", this.supplierID);
            c.Parameters.AddWithValue("@SupplierName", this.supplierName.ToString());
            c.Parameters.AddWithValue("@email", this.email.ToString());
            c.Parameters.AddWithValue("@phone", this.phone.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}