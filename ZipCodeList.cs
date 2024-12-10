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
    public partial class ZipCodeList : Form
    {
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataset;
        public ZipCodeList()
        {
            InitializeComponent();
            LoadZipCodeList();
        }


        private void LoadZipCodeList()
        {
            string sql;
            try
            {
                
                using (conn = new iDB2Connection("DataSource=deathstar.gtc.edu"))
                {
                    sql = "SELECT * FROM ITPA675.ZIPCODE";
                    adapter = new iDB2DataAdapter(sql, conn);

                    dataset = new DataSet();
                    adapter.Fill(dataset);

                    ZipCodeDataGrid.DataSource = dataset.Tables[0];
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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            UpdateZipCodes addForm = new UpdateZipCodes(false);
            addForm.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            PromptForZipCode promptForm = new PromptForZipCode();
            if (promptForm.ShowDialog() == DialogResult.OK)
            {
                string zipCode = promptForm.ZipCode;
                
                UpdateZipCodes updateForm = new UpdateZipCodes(updateMode: true, zipCode: zipCode);
                updateForm.ShowDialog();
            }
        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            LoadZipCodeList();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
