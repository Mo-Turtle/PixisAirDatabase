using IBM.Data.DB2.iSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PixisAirDatabaseTest2
{
    public partial class EmployeeList : Form
    {
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataset;

        public EmployeeList()
        {
            InitializeComponent();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            LoadEmployeeList();
        }

        private void LoadEmployeeList()
        {
            string sql;
            try
            {
                //connects to deathstar, grabs EMPLOYEE data, and populates the DataGridView with it
                using (conn = new iDB2Connection("DataSource=deathstar.gtc.edu"))
                {
                    sql = "SELECT * FROM ITPA675.EMPLOYEE";
                    adapter = new iDB2DataAdapter(sql, conn);

                    dataset = new DataSet();
                    adapter.Fill(dataset);

                    EmployeeDataGrid.DataSource = dataset.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                //checks if the connection is still open and closes it.
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void AddEmpBtn_Click(object sender, EventArgs e)
        {
            //this will open the UpdateEmployees form set to add employee (false for update)
            UpdateEmployees addForm = new UpdateEmployees(false);
            addForm.Show();
        }

        private void UpdateEmpBtn_Click(object sender, EventArgs e)
        {
            PromptForEmpID promptForm = new PromptForEmpID();
            if (promptForm.ShowDialog() == DialogResult.OK)
            {
                string empID = promptForm.EmployeeID;
                //passes empID to the UpdateEmployee form for processing
                UpdateEmployees updateForm = new UpdateEmployees(updateMode: true, empID: empID);
                updateForm.ShowDialog();
            }

        }

        
        //closes the EmployeeList Form
        private void ExtBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeList_FormClosed(object sender, FormClosedEventArgs e)
        {
            //does nothing because I am tired and it is 7:50AM
        }
        //this reloads the data to see the updated added employee entry
        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            LoadEmployeeList();
        }
    }
}
