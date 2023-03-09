using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace group28_1
{
    public class employee
    {
        private long id;
        private string firstName;
        private string lastName;
        private string userName;
        private string password;
        private employeeType type;
        private double salaryPerHour;
        private string stringType;


        public employee(long id, string firstName, string lastName, string userName, string password, employeeType type, double salaryPerHour, bool is_new)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = userName;
            this.password = password;
            this.type = type;
            this.stringType = type.ToString();
            this.salaryPerHour = salaryPerHour;
            if (is_new)
            {
                this.create_employee();
                Program.employees.Add(this);
            }

        }
        public long get_id()
        {
            return this.id;
        }
        public void set_id(long id)
        {
            this.id = id;
        }
        public string get_firstName()
        {
            return this.firstName;
        }
        public void set_firsrName(string firstName)
        {
            this.firstName = firstName;
        }
        public string get_lastName()
        {
            return this.lastName;
        }
        public void set_lastName(string lastName)
        {
            this.lastName = lastName;
        }
        public string get_userName()
        {
            return this.userName;
        }
        public void set_userName(string userName)
        {
            this.userName = userName;
        }
        public string get_password()
        {
            return this.password;
        }
        public void set_password(string password)
        {
            this.password = password;
        }
        public employeeType get_employeeType()
        {
            return this.type;
        }
        public string get_StringType()
        {
            return this.stringType;
        }
        public void set_StringType(string stringT)
        {
            this.stringType = stringT;
        }
        public void set_employeeType(employeeType type)
        {
            this.type = type;
        }
        public double get_salaryPerHour()
        {
            return this.salaryPerHour;
        }
        public void set_salaryPerHour(long salaryPerHour)
        {
            this.salaryPerHour = salaryPerHour;
        }

        public void create_employee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_employee @id , @firstName , @lastName, @userName , @password , @type , @salaryPerHour";
            c.Parameters.AddWithValue("@id", this.id);
            c.Parameters.AddWithValue("@firstName", this.firstName.ToString());
            c.Parameters.AddWithValue("@lastName", this.lastName.ToString());
            c.Parameters.AddWithValue("@userName", this.userName.ToString());
            c.Parameters.AddWithValue("@password", this.password.ToString());
            c.Parameters.AddWithValue("@type", this.type.ToString());
            c.Parameters.AddWithValue("@salaryPerHour", double.Parse(this.salaryPerHour.ToString()));
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void update_employeeID(long old_id)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_update_employeeID @old_id, @newid, @firstName, @lastName, @userName, @password, @type, @salaryPerHour";
            c.Parameters.AddWithValue("@old_id", old_id);
            c.Parameters.AddWithValue("@newid", this.id);
            c.Parameters.AddWithValue("@firstName", this.firstName.ToString());
            c.Parameters.AddWithValue("@lastName", this.lastName.ToString());
            c.Parameters.AddWithValue("@userName", this.userName.ToString());
            c.Parameters.AddWithValue("@password", this.password.ToString());
            c.Parameters.AddWithValue("@type", this.type.ToString());
            c.Parameters.AddWithValue("@salaryPerHour", this.salaryPerHour);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void update_employee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Employee @id , @firstName , @lastName, @userName , @password , @type , @salaryPerHour";
            //c.Parameters.AddWithValue("@old_id", old_id);
            c.Parameters.AddWithValue("@id", this.id);
            c.Parameters.AddWithValue("@firstName", this.firstName.ToString());
            c.Parameters.AddWithValue("@lastName", this.lastName.ToString());
            c.Parameters.AddWithValue("@userName", this.userName.ToString());
            c.Parameters.AddWithValue("@password", this.password.ToString());
            c.Parameters.AddWithValue("@type", this.type.ToString());
            c.Parameters.AddWithValue("@salaryPerHour", this.salaryPerHour);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void move_archive_employee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_move_archive_employee  @id , @firstName , @lastName, @userName , @password , @type , @salaryPerHour";
            c.Parameters.AddWithValue("@id", this.id);
            c.Parameters.AddWithValue("@firstName", this.firstName.ToString());
            c.Parameters.AddWithValue("@lastName", this.lastName.ToString());
            c.Parameters.AddWithValue("@userName", this.userName.ToString());
            c.Parameters.AddWithValue("@password", this.password.ToString());
            c.Parameters.AddWithValue("@type", this.type.ToString());
            c.Parameters.AddWithValue("@salaryPerHour", this.salaryPerHour);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
            Program.employees.Remove(this);
            Program.archive_employees.Add(this);
        }

        public void return_archive_employee() //return employee from archive
        {
            Program.archive_employees.Remove(this);
            Program.employees.Add(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_return_archive__employee @id , @firstName , @lastName, @userName , @password , @type , @salaryPerHour";
            c.Parameters.AddWithValue("@id", this.id);
            c.Parameters.AddWithValue("@firstName", this.firstName.ToString());
            c.Parameters.AddWithValue("@lastName", this.lastName.ToString());
            c.Parameters.AddWithValue("@userName", this.userName.ToString());
            c.Parameters.AddWithValue("@password", this.password.ToString());
            c.Parameters.AddWithValue("@type", this.type.ToString());
            c.Parameters.AddWithValue("@salaryPerHour", this.salaryPerHour);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
