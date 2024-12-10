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
    public partial class UpdateCustomer : Form
    {
        private bool isUpdateMode;
        private string customerID;
        iDB2Connection conn;
        iDB2Command cmd;
        iDB2DataReader reader;
        public UpdateCustomer(bool updateMode = false, string custID = null)
        {
            InitializeComponent();
            isUpdateMode = updateMode;
            customerID = custID;

            if (isUpdateMode)
            {
                LoadCustomerData(customerID);
            }
            else
            {
                ClearCustomerFields();
            }
        }

       
        private void LoadCustomerData(string custID)
        {
            try
            {
                using (conn = new iDB2Connection("DataSource=deathstar.gtc.edu"))
                {
                    conn.Open();
                    string sql = $"SELECT * FROM CUSTOMER WHERE CUSTNO = '{custID}'";
                    using (cmd = new iDB2Command(sql, conn))
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())//fiills the textboxes with the appropriate data
                        {
                            textBoxCustID.Text = reader["CUSTNO"].ToString();
                            textBoxCustFName.Text = reader["CFNAME"].ToString();
                            textBoxCustLName.Text = reader["CLNAME"].ToString();
                            textBoxCustAddr.Text = reader["CADDR"].ToString();
                            textBoxCustCity.Text = reader["CCITY"].ToString();
                            textBoxCustState.Text = reader["CSTATE"].ToString();
                            textBoxCustZip.Text = reader["CZIP"].ToString();
                            textBoxCustPhone.Text = reader["CPHONE"].ToString();
                            textBoxCustEmail.Text = reader["CEMAIL"].ToString();
                            textBoxCustDOB.Text = reader["CDOB"].ToString();
                            textBoxCustGender.Text = reader["CGENDER"].ToString();
                            textBoxCustPsswrd.Text = reader["CPWORD"].ToString();
                            textBoxCustCardNum.Text = reader["CSCCARDNO"].ToString();
                            textBoxCustPaymntsTtl.Text = reader["CSPYMTSTL"].ToString();
                            textBoxPasswrdHash.Text = reader["CPWORDHASH"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Customer not Found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Loading Customer Data: {ex.Message}");
            }
        }
        private void ClearCustomerFields()
        {
            textBoxCustID.Clear();
            textBoxCustFName.Clear();
            textBoxCustLName.Clear();
            textBoxCustAddr.Clear();
            textBoxCustCity.Clear();
            textBoxCustState.Clear();
            textBoxCustZip.Clear();
            textBoxCustPhone.Clear();
            textBoxCustEmail.Clear();
            textBoxCustDOB.Clear();
            textBoxCustGender.Clear();
            textBoxCustPsswrd.Clear();
            textBoxCustCardNum.Clear();
            textBoxCustPaymntsTtl.Clear();
            textBoxPasswrdHash.Clear();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (isUpdateMode)
            {
                UpdateCustomers();
            }
            else
            {
                AddCustomer();
            }
        }

        public void UpdateCustomers()
        {
            try
            {
                using (conn = new iDB2Connection("DataSource=deathstar.gtc.edu"))
                {
                    conn.Open();
                    string sql = "UPDATE CUSTOMER SET " +
                                 "CFNAME = ?, CLNAME = ?, CADDR = ?, CCITY = ?, CSTATE = ?, CZIP = ?, " +
                                 "CPHONE = ?, CEMAIL = ?, CDOB = ?, CGENDER = ?, CPWORD = ?, " +
                                 "CSCCARDNO = ?, CSPYMTSTL = ?, CPWORDHASH = ? " +
                                 "WHERE CUSTNO = ?";
                    using (cmd = new iDB2Command(sql, conn))
                    {
                        cmd.Parameters.Add(new iDB2Parameter("CFNAME", textBoxCustFName.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CLNAME", textBoxCustLName.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CADDR", textBoxCustAddr.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CCITY", textBoxCustCity.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CSTATE", textBoxCustState.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CZIP", textBoxCustZip.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CPHONE", textBoxCustPhone.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CEMAIL", textBoxCustEmail.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CDOB", textBoxCustDOB.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CGENDER", textBoxCustGender.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CPWORD", textBoxCustPsswrd.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CSCCARDNO", textBoxCustCardNum.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CSPYMTSTL", textBoxCustPaymntsTtl.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CPWORDHASH", textBoxPasswrdHash.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CUSTNO", textBoxCustID.Text));

                        cmd.ExecuteNonQuery();
                    }


                    MessageBox.Show("Employee updated successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating Employee: {ex.Message} ");
                }

        }

        public void AddCustomer()
        {
            try
            {
                using (conn = new iDB2Connection("DataSource=deathstar.gtc.edu"))
                {
                    conn.Open();
                    string sql = "INSERT INTO CUSTOMER (CUSTNO, CFNAME, CLNAME, CADDR, CCITY, CSTATE, CZIP, " +
             "CPHONE, CEMAIL, CDOB, CGENDER, CPWORD, CSCCARDNO, CSPYMTSTL, CPWORDHASH) " +
             "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
                    using (cmd = new iDB2Command(sql, conn))
                    {
                        cmd.Parameters.Add(new iDB2Parameter("CUSTNO", textBoxCustID.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CFNAME", textBoxCustFName.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CLNAME", textBoxCustLName.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CADDR", textBoxCustAddr.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CCITY", textBoxCustCity.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CSTATE", textBoxCustState.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CZIP", textBoxCustZip.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CPHONE", textBoxCustPhone.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CEMAIL", textBoxCustEmail.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CDOB", textBoxCustDOB.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CGENDER", textBoxCustGender.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CPWORD", textBoxCustPsswrd.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CSCCARDNO", textBoxCustCardNum.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CSPYMTSTL", textBoxCustPaymntsTtl.Text));
                        cmd.Parameters.Add(new iDB2Parameter("CPWORDHASH", textBoxPasswrdHash.Text));

                        cmd.ExecuteNonQuery(); // Execute the insert statement
                        MessageBox.Show("Customer added successfully.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Adding Employee: {ex.Message} ");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
                    
                    
