using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace group28_1
{
    class Event
    {
        private string eventID;
        private int numberOfEmployees;
        private DateTime date;
        private eventType type;
        private double grossPrice;
        public Dictionary<Design, int> designs;

        public Event(string eventID, DateTime date, int numberOfEmployees, eventType type, double grossPrice, bool is_new)
        {
            this.eventID = eventID;
            this.numberOfEmployees = numberOfEmployees;
            this.date = date;
            this.type = type;
            this.grossPrice = grossPrice;
            designs = new Dictionary<Design, int>();
            if (is_new)
            {
                this.create_Event();
                Program.Events.Add(this);
            }
        }

        public void add_list(Dictionary<Design, int> designsNew)
        {
            this.designs = designsNew;
            foreach (KeyValuePair<Design, int> x in designs)
            {
                Design_event y = new Design_event(x.Key.get_DesignID(), this.eventID, x.Value, true);
            }
        }

        public string get_eventID()
        {
            return this.eventID;
        }
        public void set_eventID(String eventid)
        {
            this.eventID = eventid;
        }
        public int get_numberOfEmployees()
        {
            return this.numberOfEmployees;
        }
        public void set_numberOfEmployees(int numberOfEmployees)
        {
            this.numberOfEmployees = numberOfEmployees;
        }
        public DateTime get_date()
        {
            return this.date;
        }
        public void set_date(DateTime date)
        {
            this.date = date;
        }
        public eventType get_type()
        {
            return this.type;
        }
        public void set_type(eventType type)
        {
            this.type = type;
        }
        public double get_grossPrice()
        {
            return this.grossPrice;
        }
        public void set_grossPrice(double grossPrice)
        {
            this.grossPrice = grossPrice;
        }
        public void create_Event()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = " EXECUTE SP_add_Event @eventID, @date , @numberOfEmployees, @type ,@grossPrice";
            c.Parameters.AddWithValue("@eventID", this.eventID.ToString());
            c.Parameters.AddWithValue("@date", this.date);
            c.Parameters.AddWithValue("@numberOfEmployees", this.numberOfEmployees);
            c.Parameters.AddWithValue("@type", this.type.ToString());
            c.Parameters.AddWithValue("@grossPrice", this.grossPrice);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void update_Event(string oldEventId)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = " EXECUTE SP_Update_Event @oldEventId ,@eventID, @date , @numberOfEmployees, @type ,@grossPrice";
            c.Parameters.AddWithValue("@oldEventId", oldEventId.ToString());
            c.Parameters.AddWithValue("@eventID", this.eventID.ToString());
            c.Parameters.AddWithValue("@date", this.date);
            c.Parameters.AddWithValue("@numberOfEmployees", this.numberOfEmployees);
            c.Parameters.AddWithValue("@type", this.type.ToString());
            c.Parameters.AddWithValue("@grossPrice", this.grossPrice);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_Event_price()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = " EXECUTE dbo.update_Event_price  @eventId ,@grossPrice";
            c.Parameters.AddWithValue("@eventId", this.eventID.ToString());
            c.Parameters.AddWithValue("@grossPrice", this.grossPrice);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void Assign_Employee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = " EXECUTE dbo.SP_Assign_Employee @eventID ,@EmployeeID, @numberOfEmployeesUpdated";
            c.Parameters.AddWithValue("@eventID", this.eventID);
            c.Parameters.AddWithValue("@EmployeeID", Global.employeeID);
            c.Parameters.AddWithValue("@numberOfEmployeesUpdated", this.numberOfEmployees);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void delete_Event()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = " EXECUTE dbo.SP_delete_events@eventID";
            c.Parameters.AddWithValue("@eventID", this.eventID.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void removeAssignOfEmployee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = " EXECUTE dbo.SP_remove_assign @eventID, @employeeID, @NEWnumberOfEmployees";
            c.Parameters.AddWithValue("@eventID", this.eventID.ToString());
            c.Parameters.AddWithValue("@employeeID", Global.employeeID);
            c.Parameters.AddWithValue("@NEWnumberOfEmployees", this.get_numberOfEmployees() + 1);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


    }
}
