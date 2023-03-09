using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group28_1
{
    class Assignment
    {
        private string eventID;
        private long employeeID;
        private DateTime? startTime;
        private DateTime? endTime;

        public Assignment(string eventID, long employeeID, DateTime? startTime, DateTime? endTime)
        {
            this.employeeID = employeeID;
            this.eventID = eventID;
            this.startTime = startTime;
            this.endTime = endTime;

        }

        // Getter for eventID attribute
        public string GetEventID()
        {
            return this.eventID;
        }

        // Setter for eventID attribute
        public void SetEventID(string eventID)
        {
            this.eventID = eventID;
        }

        // Getter for employeeID attribute
        public long GetEmployeeID()
        {
            return this.employeeID;
        }

        // Setter for employeeID attribute
        public void SetEmployeeID(long employeeID)
        {
            this.employeeID = employeeID;
        }

        // Getter for startTime attribute
        public DateTime? GetStartTime()
        {
            return this.startTime;
        }

        // Setter for startTime attribute
        public void SetStartTime(DateTime? startTime)
        {
            this.startTime = startTime;
        }

        // Getter for endTime attribute
        public DateTime? GetEndTime()
        {
            return this.endTime;
        }

        // Setter for endTime attribute
        public void SetEndTime(DateTime? endTime)
        {
            this.endTime = endTime;
        }
        // public float calculateWorkTime()
        //{
        //TimeSpan diff = end.Subtract(start);

        //double hours = diff.TotalHours;
        //double minutes = diff.TotalMinutes;
        //startTime = int.Parse(this.startTime);
        // endTime = int.Parse(this.endTime);
        //return endTime - startTime;
        //}

    }
}
