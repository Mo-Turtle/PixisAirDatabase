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
    public partial class UpdateZipCodes : Form
    {
        private bool isUpdateMode;
        private string zipyCode;
        iDB2Connection conn;
        iDB2Command cmd;
        iDB2DataReader reader;
        public UpdateZipCodes(bool updateMode = false, string zipCode = null)
        {
            InitializeComponent();
            isUpdateMode = updateMode;
            zipyCode = zipCode;

            if (isUpdateMode)
            {
                LoadZipCodeData(zipyCode);
            }
            else
            {
                ClearZipCodeFields();
            }
        }
        private void LoadZipCodeData(string zipCode)
        {
            try
            {
                using (conn = new iDB2Connection("DataSource=deathstar.gtc.edu"))
                {
                    conn.Open();
                    string sql = $"SELECT * FROM ITPA675.ZIPCODE WHERE ZIP = '{zipCode}'";
                    using (cmd = new iDB2Command(sql, conn))
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())//fiills the textboxes with the appropriate data
                        {
                            textBoxZip.Text = reader["ZIP"].ToString();
                            textBoxCity.Text = reader["CITY"].ToString();
                            textBoxState.Text = reader["STATE"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Zip Code not Found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Loading Zip Code Data: {ex.Message}");
            }
        }

        private void ClearZipCodeFields()
        {
            textBoxZip.Clear();
            textBoxCity.Clear();
            textBoxState.Clear();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (isUpdateMode)
            {
                UpdateZipCode();
            }
            else
            {
                AddZipCode();
            }
        }

        public void UpdateZipCode()
        {
            try
            {
                using (conn = new iDB2Connection("DataSource=deathstar.gtc.edu"))
                {
                    conn.Open();
                    string sql = "UPDATE ZIPCODE SET " +
                          "CITY = ?, STATE = ? " + 
                          "WHERE ZIP = ?";
                    using (cmd = new iDB2Command(sql, conn))
                    {
                        cmd.Parameters.Add(new iDB2Parameter("CITY", textBoxCity.Text));
                        cmd.Parameters.Add(new iDB2Parameter("STATE", textBoxState.Text));
                        cmd.Parameters.Add(new iDB2Parameter("ZIP", textBoxZip.Text));
                        cmd.ExecuteNonQuery();
                    }


                    MessageBox.Show("Location updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Location: {ex.Message} ");
            }

        }

        public void AddZipCode()
        {
            try
            {
                using (conn = new iDB2Connection("DataSource=deathstar.gtc.edu"))
                {
                    conn.Open();
                    string sql = "INSERT INTO ZIPCODE (ZIP, CITY, STATE)" +
                                 "VALUES (?, ?, ?)";
                    using (cmd = new iDB2Command(sql, conn))
                    {
                        cmd.Parameters.Add(new iDB2Parameter("ZIP", textBoxZip.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CITY", textBoxCity.Text));
                        cmd.Parameters.Add(new iDB2Parameter("STATE", textBoxState.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer added successfully.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Adding Location: {ex.Message} ");
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
