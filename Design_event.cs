using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace group28_1
{
    class Design_event
    {
        private long DesignID;
        private String eventID;
        private int quantity;

        public Design_event(long DesignID, String eventID, int quantity, bool is_new)
        {
            this.DesignID = DesignID;
            this.eventID = eventID;
            this.quantity = quantity;
            if (is_new)
            {
                this.create_design_eventID();
                Program.all_design_event.Add(this);
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
        public String get_eventID()
        {
            return this.eventID;
        }
        public void set_eventID(String ProductID)
        {
            this.eventID = eventID;
        }
        public void create_design_eventID()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = " dbo.SP_add_design_event @DesigniD ,@eventID ,@quantity";
            c.Parameters.AddWithValue("@DesigniD", this.DesignID);
            c.Parameters.AddWithValue("@eventID", this.eventID.ToString());
            c.Parameters.AddWithValue("@quantity", this.quantity);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

        }
        public void update_design_event()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = " dbo.SP_update_design_event @DesigniD ,@eventID,@quantity";
            c.Parameters.AddWithValue("@DesigniD", this.DesignID);
            c.Parameters.AddWithValue("@eventID", this.eventID.ToString());
            c.Parameters.AddWithValue("@quantity", this.quantity);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


    }
}
