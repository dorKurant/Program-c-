using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace group28_1
{
    public partial class assignToEvent : Form
    {
        public assignToEvent()
        {
            InitializeComponent();
        }

        private void assignToEvent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_28DataSet1.Events' table. You can move, or remove it, as needed.
            this.show_table();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.eventsTableAdapter.FillBy(this.sAD_28DataSet1.Events);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int numOfEmployees = int.Parse(dataGridView1.Rows[rowIndex].Cells[3].Value.ToString());
            if (numOfEmployees == 0)
            {
                MessageBox.Show("לא נדרשים עובדים נוספים לאירוע זה");
                return;
            }
            string eventID = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            Bid b = Program.bids.FirstOrDefault(Bid => Bid.get_eventID().ToString() == eventID.ToString());
            if (b.get_approval() == false)
            {
                MessageBox.Show("אירוע זה עוד לא אושר ולכן לא ניתן להשתבץ אליו");

            }
            else
            {
                if (!possibleMatch(eventID))
                {//check if the employee already assign
                    MessageBox.Show("הינך כבר משויך לאירוע הזה");
                    return;
                }
                foreach (Event E in Program.Events)
                {
                    if (E.get_eventID() == eventID)
                    {

                        E.set_numberOfEmployees(numOfEmployees - 1);//assign
                        E.Assign_Employee();
                        //MessageBox.Show("שובצת בהצלחה!");
                        this.show_table();
                        return;
                    }
                }
            }
        }
        private void show_table()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.view_future_events";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            DataTable dataTable = new DataTable();
            dataTable.Load(rdr);
            dataGridView1.DataSource = dataTable;
        }

        private void userEvents_Click(object sender, EventArgs e)
        {
            employeeSetUp_Events EE = new employeeSetUp_Events();
            EE.Show();
            this.Hide();
        }
        private Boolean possibleMatch(string eventID) //check if the assign is possible
        {
            foreach (Assignment a in Program.assignments)
            {
                if (a.GetEmployeeID() == Global.employeeID & a.GetEventID() == eventID)
                    return false;//impossible to assign
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eventSetUpEmployeeHomeScreen cv = new eventSetUpEmployeeHomeScreen();
            cv.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Entry_Screen cv = new Entry_Screen();
            cv.Show();
            this.Hide();
        }
    }
}