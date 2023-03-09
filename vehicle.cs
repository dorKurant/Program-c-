// File:    Worker.cs
// Author:  ranalm
// Created: יום שני 12 מאי 2014 21:00:31
// Purpose: Definition of Class Worker

using System;
using System.Data.SqlClient;

namespace group28_1
{
    public class vehicle
    {
        private string vehicleNumber;
        private vehicleType type;
        private int vechicleYear;
        private double kilometrage;
        // public System.Collections.Generic.List<Order> orders;
        public vehicle(string vehicleNumber, vehicleType type, int vechicleYear, double kilometrage, bool is_new)
        {

            this.vehicleNumber = vehicleNumber;
            this.type = type;
            this.vechicleYear = vechicleYear;
            this.kilometrage = kilometrage;
            if (is_new)
            {
                this.create_vehicle();
                Program.vehicles.Add(this);

            }
        }
        public string get_vehicleNumber()
        {
            return this.vehicleNumber;
        }
        public void set_vehicleNumber(string vehicleNumber)
        {
            this.vehicleNumber = vehicleNumber;
        }
        public vehicleType get_type()
        {
            return this.type;
        }
        public double get_kilometrage()
        {
            return this.kilometrage;
        }
        public int get_vechicleYear()
        {
            return this.vechicleYear;
        }
        public void set_vechicleYear(int vechicleYear)
        {
            this.vechicleYear = vechicleYear;
        }
        public void set_kilometrage(double kilometrage)
        {
            this.kilometrage = kilometrage;
        }
        public void set_type(vehicleType t)
        {
            this.type = t;
        }
        public void create_vehicle()//לעדכן לפרוצדורה שלנו
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_vehicle  @vehicleNumber , @type , @vechicleYear ,@kilometrage";
            c.Parameters.AddWithValue("@vehicleNumber", this.vehicleNumber);
            c.Parameters.AddWithValue("@type", this.type.ToString());
            c.Parameters.AddWithValue("@vechicleYear", this.vechicleYear);
            c.Parameters.AddWithValue("@kilometrage", this.kilometrage);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void update_vehicle(String oldVehicleNumber)//לבדוק אולי שאני רוצה שבפרC:\Users\dorku\Downloads\group28_1 (2)guychuk\group28_1 (1)guyguy\group28_1 (1)\group28_1\employeeType.csוצדורה יעדכנו לי את כל השדות או לא
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_vehicle @oldVehicleNumber , @vehicleNumber , @type , @vehicleYear , @kilometrage ";
            c.Parameters.AddWithValue("@oldVehicleNumber", oldVehicleNumber.ToString());
            c.Parameters.AddWithValue("@vehicleNumber", this.vehicleNumber.ToString());
            c.Parameters.AddWithValue("@type", this.type.ToString());
            c.Parameters.AddWithValue("@vehicleYear", this.vechicleYear);
            c.Parameters.AddWithValue("@kilometrage", this.kilometrage);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void move_archive_vehicle()//move vehicle to archive
        {
            Program.vehicles.Remove(this);
            Program.archive_vehicles.Add(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_move_archive_vehicle  @vehicleNumber, @type, @vechicleYear, @kilometrage";
            c.Parameters.AddWithValue("@vehicleNumber", this.vehicleNumber);
            c.Parameters.AddWithValue("@type", this.type.ToString());
            c.Parameters.AddWithValue("@vechicleYear", this.vechicleYear);
            c.Parameters.AddWithValue("@kilometrage", this.kilometrage);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void return_archive_vehicle()//return vehicle from archive
        {
            Program.archive_vehicles.Remove(this);
            Program.vehicles.Add(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_return_archive_vehicle  @vehicleNumber, @type, @vechicleYear, @kilometrage";
            c.Parameters.AddWithValue("@vehicleNumber", this.vehicleNumber);
            c.Parameters.AddWithValue("@type", this.type.ToString());
            c.Parameters.AddWithValue("@vechicleYear", this.vechicleYear);
            c.Parameters.AddWithValue("@kilometrage", this.kilometrage);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}