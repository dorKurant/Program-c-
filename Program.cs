using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;


namespace group28_1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static System.Collections.Generic.List<vehicle> vehicles;
        public static System.Collections.Generic.List<vehicle> archive_vehicles;
        public static System.Collections.Generic.List<employee> employees;
        public static System.Collections.Generic.List<employee> archive_employees;
        public static System.Collections.Generic.List<Product> Products;
        public static System.Collections.Generic.List<Event> Events;
        public static System.Collections.Generic.List<Customer> customers;
        public static System.Collections.Generic.List<Customer> archive_customers;
        public static System.Collections.Generic.List<Supplier> suppliers;
        public static System.Collections.Generic.List<Supplier> archive_suppliers;
        public static System.Collections.Generic.List<Design> Designs;
        public static System.Collections.Generic.List<design_products> all_design_products;
        public static System.Collections.Generic.List<Bid> bids;
        public static System.Collections.Generic.List<Order> orders;
        public static System.Collections.Generic.List<Design_event> all_design_event;
        public static System.Collections.Generic.List<Assignment> assignments;
        public static System.Collections.Generic.Dictionary<int, double> income;
        public static System.Collections.Generic.Dictionary<int, double> order_expendiure;
        public static System.Collections.Generic.List<OrderedProduct> orderedProducts;






        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists();
            updateLastUse();
            rateProduct();
            //vehicleType truck1 = vehicleType.truck; 
            //vehicle V = new vehicle("1234",truck1 , 2022, 22000, true);
            //Application.Run(new View_Vehicle());
            //Application.Run(new CreateNewemployee());
            //Application.Run(new Crud_Vehicles());
            //Application.Run(new Create_New_Event());
            //Application.Run(new Create_Vehicle());
            //Application.Run(new Entry_Screen());
            //Application.Run(new Create_New_Event());
            //Application.Run(new Create_Bid());
            //Application.Run(new Create_Vehicle());
            //Application.Run(new View_Supplier());
            //Application.Run(new Trace_on_financial_balance());
            Application.Run(new Entry_Screen());
            //Application.Run(new Create_New_Event());
            //Application.Run( new ChooseProductReportScreen());
        }
        public static void initLists()//intial the lists from the DB
        {
            init_vehicles();//intial vehicles
            init_Products();//intial Products
            init_employee();//intial employee
            init_event();//intial events
            init_customer();//initial customer
            init_Supplier();//initial suppliers
            init_all_design_products();//initial suppliers
            init_all_design_event();
            init_ARCHIVE_CUSTOMERS();//initial archive customers
            init_Designs();//initial customer
            init_ARCHIVE_EMPLOYEES();//initial employees archive
            init_archive_vehicles();//initial archive vehicles
            init_ARCHIVE_SUPPLIERS();//initial archive suppliers
            init_Bids(); //inital bids
            init_Orders();//initial orders
            init_Assignments();//initial assignments
            init_orderedProducts();//initial ordered Products 
            init_income();
            init_order_expendiure();


        }
        public static void init_orderedProducts()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.view_all_ordered_products";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            orderedProducts = new List<OrderedProduct>();

            while (rdr.Read())
            {
                OrderedProduct op = new OrderedProduct(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), int.Parse(rdr.GetValue(2).ToString()));
                orderedProducts.Add(op);
            }
            foreach (OrderedProduct op in orderedProducts)
            {
                foreach (Order o in orders)
                {
                    if (op.get_orderID().Equals(o.GetOrderID()))
                    {
                        op.set_date(o.GetDate());//update day time
                        op.set_Price_per_unit((o.GetPrice() / op.get_Quantity()));
                        break;
                    }
                }
            }
        }
        public static void init_Bids()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.view_all_bids";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            bids = new List<Bid>();
            while (rdr.Read())
            {
                long? customer;
                if (string.IsNullOrEmpty(rdr.GetValue(6).ToString()))
                    customer = null;
                else
                    customer = long.Parse(rdr.GetValue(6).ToString());

                Bid b = new Bid(rdr.GetValue(0).ToString(), DateTime.Parse(rdr.GetValue(1).ToString()), double.Parse(rdr.GetValue(2).ToString()), double.Parse(rdr.GetValue(3).ToString()), double.Parse(rdr.GetValue(4).ToString()), Boolean.Parse(rdr.GetValue(5).ToString()), customer, rdr.GetValue(7).ToString(), false);
                bids.Add(b);
            }
        }
        public static void init_all_design_event()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.view_all_design_event";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            all_design_event = new List<Design_event>();

            while (rdr.Read())
            {
                //customerType ct = (customerType)Enum.Parse(typeof(customerType), rdr.GetValue(2).ToString());
                Design_event cus = new Design_event(long.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), int.Parse(rdr.GetValue(2).ToString()), false);
                all_design_event.Add(cus);
            }

        }
        public static void init_Designs() //inital customers from the DB
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.view_all_design";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Designs = new List<Design>();

            while (rdr.Read())
            {
                //customerType ct = (customerType)Enum.Parse(typeof(customerType), rdr.GetValue(2).ToString());
                Design cus = new Design(long.Parse(rdr.GetValue(0).ToString()), double.Parse(rdr.GetValue(1).ToString()), false);
                Designs.Add(cus);
            }
        }
        public static void init_all_design_products() //inital customers from the DB
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.view_all_design_product";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            all_design_products = new List<design_products>();

            while (rdr.Read())
            {
                //customerType ct = (customerType)Enum.Parse(typeof(customerType), rdr.GetValue(2).ToString());
                design_products cus = new design_products(long.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), int.Parse(rdr.GetValue(2).ToString()), false);
                all_design_products.Add(cus);
            }
        }


        public static void init_customer() //inital customers from the DB
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.View_all_Customers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            customers = new List<Customer>();
            archive_customers = new List<Customer>();

            while (rdr.Read())
            {
                customerType ct = (customerType)Enum.Parse(typeof(customerType), rdr.GetValue(5).ToString());
                Customer cus = new Customer(long.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), ct, false);
                customers.Add(cus);
            }
        }


        public static void init_event()//intial event from the DB
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.view_all_events";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Events = new List<Event>();

            while (rdr.Read())
            {
                eventType Et = (eventType)Enum.Parse(typeof(eventType), rdr.GetValue(3).ToString());
                Event ABC = new Event(rdr.GetValue(0).ToString(), DateTime.Parse(rdr.GetValue(1).ToString()), int.Parse(rdr.GetValue(2).ToString()), Et, double.Parse(rdr.GetValue(4).ToString()), false);
                Events.Add(ABC);
            }
        }

        public static void init_vehicles()//intial vehicles from the DB
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.view_all_vehicle";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            vehicles = new List<vehicle>();

            while (rdr.Read())
            {
                vehicleType T = (vehicleType)Enum.Parse(typeof(vehicleType), rdr.GetValue(1).ToString());
                vehicle V = new vehicle(rdr.GetValue(0).ToString(), T, int.Parse(rdr.GetValue(2).ToString()), int.Parse(rdr.GetValue(3).ToString()), false);
                vehicles.Add(V);
            }
        }
        public static void init_archive_vehicles()//intial archive vehicles from the DB
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.view_all_archive_vehicle";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            archive_vehicles = new List<vehicle>();
            while (rdr.Read())
            {
                vehicleType T = (vehicleType)Enum.Parse(typeof(vehicleType), rdr.GetValue(1).ToString());
                vehicle V = new vehicle(rdr.GetValue(0).ToString(), T, int.Parse(rdr.GetValue(2).ToString()), int.Parse(rdr.GetValue(3).ToString()), false);
                archive_vehicles.Add(V);
            }
        }
        public static void init_Products()//intial Products from the DB
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.view_all_product";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Products = new List<Product>();

            while (rdr.Read())
            {
                productStatus S = (productStatus)Enum.Parse(typeof(productStatus), rdr.GetValue(2).ToString());
                productType T = (productType)Enum.Parse(typeof(productType), rdr.GetValue(4).ToString());
                Product P = new Product(rdr.GetValue(0).ToString(), DateTime.Parse(rdr.GetValue(1).ToString()), S, int.Parse(rdr.GetValue(3).ToString()), T, double.Parse(rdr.GetValue(5).ToString()), DateTime.Parse(rdr.GetValue(6).ToString()), double.Parse(rdr.GetValue(7).ToString()), false);
                Products.Add(P);
            }
        }

        public static void init_employee()//intial employees from the DB
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.view_all_Employees";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            employees = new List<employee>();

            while (rdr.Read())
            {
                employeeType T = (employeeType)Enum.Parse(typeof(employeeType), rdr.GetValue(5).ToString());
                employee E = new employee(long.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), T, double.Parse(rdr.GetValue(6).ToString()), false);
                employees.Add(E);
            }
        }
        public static void init_Supplier()//intial suppliers from the DB
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.view_all_supplier";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            suppliers = new List<Supplier>();

            while (rdr.Read())
            {
                Supplier s = new Supplier(long.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), false);
                suppliers.Add(s);
            }
        }
        public static void init_ARCHIVE_CUSTOMERS()//intial ARCHIVECUSTOMERS from the DB
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GET_ARCHIVE_CUSTOMERS";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            archive_customers = new List<Customer>();

            while (rdr.Read())
            {
                customerType ct = (customerType)Enum.Parse(typeof(customerType), rdr.GetValue(5).ToString());
                Customer cus = new Customer(long.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), ct, false);
                archive_customers.Add(cus);
            }
        }
        public static void init_ARCHIVE_EMPLOYEES()//intial employees from the DB
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.View_all_Employees_Archive";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            archive_employees = new List<employee>();

            while (rdr.Read())
            {
                employeeType T = (employeeType)Enum.Parse(typeof(employeeType), rdr.GetValue(5).ToString());
                employee E = new employee(long.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), T, double.Parse(rdr.GetValue(6).ToString()), false);
                archive_employees.Add(E);
            }
        }
        public static void init_ARCHIVE_SUPPLIERS() //initial archive suppliers from DB
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.view_all_archive_supplier";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            archive_suppliers = new List<Supplier>();

            while (rdr.Read())
            {
                Supplier s = new Supplier(long.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), false);
                archive_suppliers.Add(s);
            }
        }
        public static void init_Orders()//initial orders from DB
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_view_all_orders";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            orders = new List<Order>();
            while (rdr.Read())
            {
                long? supplier;
                if (string.IsNullOrEmpty(rdr.GetValue(3).ToString()))
                    supplier = null;
                else
                    supplier = long.Parse(rdr.GetValue(3).ToString());
                long? employee;
                    if (string.IsNullOrEmpty(rdr.GetValue(4).ToString()))
                    employee = null;
                else
                    employee = long.Parse(rdr.GetValue(4).ToString());
                rdr.GetValue(3).ToString();
                Order o = new Order(rdr.GetValue(0).ToString(),DateTime.Parse(rdr.GetValue(1).ToString()), float.Parse(rdr.GetValue(2).ToString()),supplier, employee);
                orders.Add(o);
            }
        }
        public static void init_Assignments() //initial archive suppliers from DB
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.view_all_assignments";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            assignments = new List<Assignment>();
            DateTime? startTime = null;//NULL ABLE
            DateTime? endTime = null;//NULL ABLE
            while (rdr.Read())
            {
                if (rdr.GetValue(2).ToString() != "")
                    startTime = DateTime.Parse(rdr.GetValue(2).ToString());
                if (rdr.GetValue(2).ToString() != "")
                    endTime = DateTime.Parse(rdr.GetValue(3).ToString());
                Assignment a = new Assignment(rdr.GetValue(0).ToString(), long.Parse(rdr.GetValue(1).ToString()), startTime, endTime);
                assignments.Add(a);
            }
        }

        public static void init_income()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "SELECT * FROM dbo.Bids_Revenue";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            income = new Dictionary<int, double>();
           
            while (rdr.Read())
            {
                income.Add(int.Parse(rdr.GetValue(0).ToString()), double.Parse(rdr.GetValue(1).ToString()));
            }
        }

        public static void init_order_expendiure()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "SELECT * FROM dbo.Order_Expendiure";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            order_expendiure = new Dictionary<int, double>();

            while (rdr.Read())
            {
                order_expendiure.Add(int.Parse(rdr.GetValue(0).ToString()), double.Parse(rdr.GetValue(1).ToString()));
            }
        }
        public static employee seekEmployee(long id,bool flag)//seek employee with id. if true then seek from archive also
        {
            if (flag)
            {
                foreach (employee e in employees)
                {
                    if (long.Parse(e.get_id().ToString()) == id)
                        return e;
                }
                foreach (employee e in archive_employees)
                {
                    if (long.Parse(e.get_id().ToString()) == id)
                        return e;
                }
            }
            else
            {
                foreach (employee e in employees)
                {
                    if (long.Parse(e.get_id().ToString()) == id)
                        return e;
                }
            }
            return null;
        }

        public static employee seekEmployee(string userName, string password)//seek employee with userName
        {
            foreach (employee e in employees)
            {
                if (e.get_userName() == userName && e.get_password() == password)
                    return e;
            }
            return null;
        }
        public static vehicle seekvehicle(string id)//seek vehicle with vehicle number
        {
            foreach (vehicle v in vehicles)
            {
                if (v.get_vehicleNumber() == id)
                    return v;
            }
            return null;
        }
        public static Customer seekCustomer(long id)
        {
            foreach (Customer c in customers)
            {
                if (c.get_id() == id)
                    return c;
            }
            return null;
        }
        public static Supplier seekSupplier(long id)//seek supllier with supplier ID
        {
            foreach (Supplier s in suppliers)
            {
                if (s.get_supplierID() == id)
                    return s;
            }
            return null;
        }

        public static Customer seek_Archive_Customer(long id)
        {
            foreach (Customer c in archive_customers)
            {
                if (c.get_id() == id)
                    return c;
            }
            return null;
        }

        public static Bid seek_Bid(string bidID)
        {
            foreach(Bid b in bids)
            {
                if (b.get_bidID() == bidID)
                    return b;
            }
            return null;
        }
        public static Event seek_event(string eventID)
        {
            foreach (Event e in Events)
            {
                if (e.get_eventID() == eventID)
                    return e;
            }
            return null;
        }
        public static void updateLastUse()
        {

            foreach (Event e in Events)
            {
                if (e.get_date() < DateTime.Now)
                {
                    foreach (Design_event de in all_design_event)
                    {
                        if (de.get_eventID().ToString() == e.get_eventID().ToString())
                        {
                            foreach (Design d in Designs)
                            {
                                if (de.get_designID().ToString() == d.get_DesignID().ToString())
                                {
                                    foreach (Product p in d.product2.Keys)
                                    {
                                        if (p.get_lastUsed() < e.get_date())
                                        {
                                            p.update_lastUsed(e.get_date());
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
        public static void rateProduct()
        {
            DateTime thirtyDaysAgo = DateTime.Now.AddDays(-30);
            foreach (Product p in Products)
            {
                if (p.get_rateDate() < thirtyDaysAgo)
                {
                    int counter = 0;

                    foreach (Event e in Events)
                    {
                        if (e.get_date() < thirtyDaysAgo)
                        {
                            foreach (Design_event de in all_design_event)
                            {
                                if (de.get_eventID() == e.get_eventID())//must
                                {
                                    foreach (Design d in Designs)
                                    {
                                        if (de.get_designID() == d.get_DesignID())//must
                                        {
                                            foreach (Product p_used in d.product2.Keys)
                                            {
                                                if (p == p_used)
                                                {
                                                    counter++;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    p.rate_product_popularity(counter);
                }

            }

        }

        public static bool isThereAChar(string str) //false if the string is only numbers
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                    return true;
            }
            return false;
        }
        public static void SendMail(string SMTPServer, int SMTP_Port, string From, string Password, string To, string Subject, string Body, Attachment attachment)
        {
            var smtpClient = new SmtpClient(SMTPServer, SMTP_Port)
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
            };
            smtpClient.Credentials = new NetworkCredential(From, Password);

            var message = new System.Net.Mail.MailMessage(new System.Net.Mail.MailAddress(From, "SendMail"), new System.Net.Mail.MailAddress(To, To));
            message.Subject = Subject;
            message.Body = Body;

            // Add the attachment to the email
            //var attachment = new Attachment (FileNames[0]);
            message.Attachments.Add(attachment);
            smtpClient.Send(message);
        }
    }
}
