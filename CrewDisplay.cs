

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
    public partial class CrewDisplay : Form
    {
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataset;

        public CrewDisplay()
        {
            InitializeComponent();
            LoadCrewDisplay();
        }
        private void Crew_Load(object sender, EventArgs e)
        {

        }

        private void LoadCrewDisplay()
        {
            string sql;
            try
            {
                //connects to deathstar, grabs EMPLOYEE data, and populates the DataGridView with it
                using (conn = new iDB2Connection("DataSource=deathstar.gtc.edu"))
                {
                    sql = "SELECT * FROM FLIGHT2024.crew1";
                    adapter = new iDB2DataAdapter(sql, conn);

                    dataset = new DataSet();
                    adapter.Fill(dataset);

                    CrewdataGridView.DataSource = dataset.Tables[0];
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

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {

        }
    }

}