using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;

namespace PixisAirDatabaseTest2
{
    public partial class FlightDisplay : Form
    {
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataset;

        public FlightDisplay()
        {
            InitializeComponent();
            LoadFlightDisplay();
            this.FlightdataGridView.SelectionMode =
                  DataGridViewSelectionMode.FullRowSelect;
            this.FlightdataGridView.MultiSelect = true;
        }

        private void FlightDisplay_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadFlightDisplay()
        {
            string sql;
            try
            {
                //connects to deathstar, grabs EMPLOYEE data, and populates the DataGridView with it
                using (conn = new iDB2Connection("DataSource=deathstar.gtc.edu"))
                {
                    sql = "SELECT * FROM Flight2024.FLIGHT order by flightno";
                    adapter = new iDB2DataAdapter(sql, conn);

                    dataset = new DataSet();
                    adapter.Fill(dataset);

                    FlightdataGridView.DataSource = dataset.Tables[0];
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
       

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
                FlightdataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    sb.Append("Row: ");
                    sb.Append(FlightdataGridView.SelectedRows[i].Index.ToString());
                    sb.Append(Environment.NewLine);
                }

                sb.Append("Total: " + selectedRowCount.ToString());
                MessageBox.Show(sb.ToString(), "Selected Rows");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Crew_Lookup crew_Lookup = new Crew_Lookup();
            crew_Lookup.Show();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

