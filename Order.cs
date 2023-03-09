using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace group28_1
{
    class Order
    {
        private long? employeeMadeID;
        private long? SupplierID;
        private string orderID;
        private DateTime date;
        private float price;

        public Order(string orderID,DateTime date,float price, long? SupplierID, long? employeeMadeID)
        {
            this.orderID = orderID;
            this.date = date;
            this.price = price;
            this.SupplierID = SupplierID;
            this.employeeMadeID = employeeMadeID;
        }
        //לעשות getim
        public long? GetEmployeeMadeID()
        {
            return this.employeeMadeID;
        }

        public void SetEmployeeMadeID(long? value)
        {
            this.employeeMadeID = value;
        }

        public long? GetSupplierID()
        {
            return this.SupplierID;
        }

        public void SetSupplierID(long? value)
        {
            this.SupplierID = value;
        }

        public string GetOrderID()
        {
            return this.orderID;
        }

        public void SetOrderID(string value)
        {
            this.orderID = value;
        }

        public DateTime GetDate()
        {
            return this.date;
        }

        public void SetDate(DateTime value)
        {
            this.date = value;
        }

        public float GetPrice()
        {
            return this.price;
        }

        public void SetPrice(float value)
        {
            this.price = value;
        }
    }
}
