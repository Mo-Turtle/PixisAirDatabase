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
    public partial class ManageCustomers : Form
    {
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataset;
        public ManageCustomers()
        {
            InitializeComponent();

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //this will open the UpdateCustomer form set to add CUSTOMER (false for update)
            UpdateCustomer addForm = new UpdateCustomer(false);
            addForm.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            PromptForCustID promptForm = new PromptForCustID();
            if (promptForm.ShowDialog() == DialogResult.OK)
            {
                string custID = promptForm.CustomerID;
                //passes custID to the UpdateCustomer form for processing
                UpdateCustomer updateForm = new UpdateCustomer(updateMode: true, custID: custID);
                updateForm.ShowDialog();
            }
        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadCustomerList()
        {
            string sql;
            try
            {
                //connects to deathstar, grabs CUSTOMERS data, and populates the DataGridView with it
                using (conn = new iDB2Connection("DataSource=deathstar.gtc.edu"))
                {
                    sql = "SELECT * FROM ITPA675.CUSTOMER";
                    adapter = new iDB2DataAdapter(sql, conn);

                    dataset = new DataSet();
                    adapter.Fill(dataset);

                    CustomersDataGrid.DataSource = dataset.Tables[0];
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

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        
    }
}
