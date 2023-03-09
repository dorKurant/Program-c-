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
    public partial class employeeSetUp_Events : Form
    {
        public employeeSetUp_Events()
        {
            InitializeComponent();
            show_table();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void show_table()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.view_employee_events @employeeID";
            c.Parameters.AddWithValue("@employeeID", Global.employeeID);
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            DataTable dataTable = new DataTable();
            dataTable.Load(rdr);
            dataGridView1.DataSource = dataTable;
        }

        private void remove_from_event_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string eventID = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            foreach (Event E in Program.Events)
            {
                if (E.get_eventID() == eventID)
                {

                    E.set_numberOfEmployees(E.get_numberOfEmployees() + 1);//remove assign
                    E.removeAssignOfEmployee();
                    this.show_table();
                    return;
                }
            }
        }
            else
            {
                MessageBox.Show("לא נמצאו אירועים", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            assignToEvent cv = new assignToEvent();
            cv.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Entry_Screen es = new Entry_Screen();
            es.Show();
            this.Hide();
        }

        private void employeeSetUp_Events_Load(object sender, EventArgs e)
        {

        }
    }
}
