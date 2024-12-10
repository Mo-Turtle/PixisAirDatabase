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
    public partial class UpdateEmployees : Form
    {
        private bool isUpdateMode;
        private string employeeID;
        iDB2Connection conn;
        iDB2Command cmd;
        iDB2DataReader reader;
        
        public UpdateEmployees(bool updateMode = false, string empID = null)
        {
            InitializeComponent();
            isUpdateMode = updateMode;
            employeeID = empID;

            if (isUpdateMode)
            {
                LoadEmployeeData(employeeID);
            }
            else
            {
                ClearEmployeeFields();
            }
        }
        //if Update mode is set to True, this method grabs all of the data associated with the User Entered EMPNO (empID)
        private void LoadEmployeeData(string empID)
        {
            try
            {
                using (conn = new iDB2Connection("DataSource=deathstar.gtc.edu"))
                {
                    conn.Open();
                    string sql = $"SELECT * FROM EMPLOYEE WHERE EMPNO = '{empID}'";
                    using(cmd = new iDB2Command(sql, conn))
                    using(reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())//fiills the textboxes with the appropriate data
                        {
                            textBoxEmpID.Text = reader["EMPNO"].ToString();
                            textBoxFName.Text = reader["EFNAME"].ToString();
                            textBoxLName.Text = reader["ELNAME"].ToString();
                            textBoxEmpAddr.Text = reader["EADDR"].ToString();
                            textBoxEmpCity.Text = reader["ECITY"].ToString();
                            textBoxEmpState.Text = reader["ESTATE"].ToString();
                            textBoxEmpZip.Text = reader["EZIP"].ToString();
                            textBoxEmpPhone.Text = reader["EPHONE"].ToString();
                            textBoxEmpEmail.Text = reader["EMAIL"].ToString();
                            textBoxEmpDOB.Text = reader["DOB"].ToString();
                            textBoxEmpGender.Text = reader["GENDER"].ToString();
                            textBoxJobID.Text = reader["JOBID"].ToString();
                            textBoxEmpWrkSts.Text = reader["WRKSTATUS"].ToString();
                            textBoxEmpHrlyR8.Text = reader["HRLYRATE"].ToString();
                            textBoxEmpHrDt.Text = reader["EMHIREDT"].ToString();
                            textBoxEmpStrtDt.Text = reader["EMSTARTDT"].ToString();
                            textBoxEmpTrmDt.Text = reader["EMTERMDT"].ToString();
                            textBoxEmpRgnID.Text = reader["REGIONID"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Employee not Found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Loading Employee Data: {ex.Message}");
            }
        }

        private void ClearEmployeeFields()//clears any textboxes just in case
        {
            textBoxEmpID.Clear();
            textBoxFName.Clear();
            textBoxLName.Clear();
            textBoxEmpAddr.Clear();
            textBoxEmpCity.Clear();
            textBoxEmpState.Clear();
            textBoxEmpZip.Clear();
            textBoxEmpPhone.Clear();
            textBoxEmpEmail.Clear();
            textBoxEmpDOB.Clear();
            textBoxEmpGender.Clear();
            textBoxJobID.Clear  ();
            textBoxEmpWrkSts.Clear();
            textBoxEmpHrlyR8.Clear();
            textBoxEmpHrDt.Clear();
            textBoxEmpStrtDt.Clear();
            textBoxEmpTrmDt.Clear();
            textBoxEmpRgnID.Clear();
        }

        private void SaveButton_Click(object sender, EventArgs e)//saves the information depending on if isUpdateMode is true or false
        {
            if (isUpdateMode)
            {
                UpdateEmployee();
            }
            else
            {
                AddEmployee();
            }
        }

        private void UpdateEmployee()//this takes the data in the textboxes and updated the associated data entry in the employee table
        {
            try
            {
                using (conn = new iDB2Connection("DataSource=deathstar.gtc.edu"))
                {
                    conn.Open();
                    string sql = "UPDATE EMPLOYEE SET " +
                             "EFNAME = ?, ELNAME = ?, EADDR = ?, ECITY = ?, ESTATE = ?, EZIP = ?, " +
                             "EPHONE = ?, EMAIL = ?, DOB = ?, GENDER = ?, JOBID = ?, WRKSTATUS = ?, " +
                             "HRLYRATE = ?, EMHIREDT = ?, EMSTARTDT = ?, EMTERMDT = ?, REGIONID = ? " +
                             "WHERE EMPNO = ?";
                    using (cmd = new iDB2Command(sql, conn))
                    {
                        cmd.Parameters.Add(new iDB2Parameter("EFNAME", textBoxFName.Text));
                        cmd.Parameters.Add(new iDB2Parameter("ELNAME", textBoxLName.Text));
                        cmd.Parameters.Add(new iDB2Parameter("EADDR", textBoxEmpAddr.Text));
                        cmd.Parameters.Add(new iDB2Parameter("ECITY", textBoxEmpCity.Text));
                        cmd.Parameters.Add(new iDB2Parameter("ESTATE", textBoxEmpState.Text));
                        cmd.Parameters.Add(new iDB2Parameter("EZIP", textBoxEmpZip.Text));
                        cmd.Parameters.Add(new iDB2Parameter("EPHONE", textBoxEmpPhone.Text));
                        cmd.Parameters.Add(new iDB2Parameter("EMAIL", textBoxEmpEmail.Text));
                        cmd.Parameters.Add(new iDB2Parameter("DOB", textBoxEmpDOB.Text));
                        cmd.Parameters.Add(new iDB2Parameter("GENDER", textBoxEmpGender.Text));
                        cmd.Parameters.Add(new iDB2Parameter("JOBID", textBoxJobID.Text));
                        cmd.Parameters.Add(new iDB2Parameter("WRKSTATUS", textBoxEmpWrkSts.Text));
                        cmd.Parameters.Add(new iDB2Parameter("HRLYRATE", textBoxEmpHrlyR8.Text));
                        cmd.Parameters.Add(new iDB2Parameter("EMHIREDT", textBoxEmpHrDt.Text));
                        cmd.Parameters.Add(new iDB2Parameter("EMSTARTDT", textBoxEmpStrtDt.Text));
                        cmd.Parameters.Add(new iDB2Parameter("EMTERMDT", textBoxEmpTrmDt.Text));
                        cmd.Parameters.Add(new iDB2Parameter("REGIONID", textBoxEmpRgnID.Text));
                        cmd.Parameters.Add(new iDB2Parameter("EMPNO", textBoxEmpID.Text));
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Employee updated successfully.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Employee: {ex.Message} ");
            }
        }

        private void AddEmployee()//this takes the data entered into the textboxes and adds it to the EMPLOYEE table as a new entry
        {
            try
            {
                using (conn = new iDB2Connection("DataSource=deathstar.gtc.edu"))
                {
                    conn.Open();
                    string sql = "INSERT INTO EMPLOYEE (EMPNO, EFNAME, ELNAME, EADDR, ECITY, ESTATE, EZIP, " +
                             "EPHONE, EMAIL, DOB, GENDER, JOBID, WRKSTATUS, HRLYRATE, EMHIREDT, EMSTARTDT, " +
                             "EMTERMDT, REGIONID) " +
                             "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
                    using (cmd = new iDB2Command(sql, conn))
                    {
                        cmd.Parameters.Add(new iDB2Parameter("EMPNO", textBoxEmpID.Text));
                        cmd.Parameters.Add(new iDB2Parameter("EFNAME", textBoxFName.Text));
                        cmd.Parameters.Add(new iDB2Parameter("ELNAME", textBoxLName.Text));
                        cmd.Parameters.Add(new iDB2Parameter("EADDR", textBoxEmpAddr.Text));
                        cmd.Parameters.Add(new iDB2Parameter("ECITY", textBoxEmpCity.Text));
                        cmd.Parameters.Add(new iDB2Parameter("ESTATE", textBoxEmpState.Text));
                        cmd.Parameters.Add(new iDB2Parameter("EZIP", textBoxEmpZip.Text));
                        cmd.Parameters.Add(new iDB2Parameter("EPHONE", textBoxEmpPhone.Text));
                        cmd.Parameters.Add(new iDB2Parameter("EMAIL", textBoxEmpEmail.Text));
                        cmd.Parameters.Add(new iDB2Parameter("DOB", textBoxEmpDOB.Text));
                        cmd.Parameters.Add(new iDB2Parameter("GENDER", textBoxEmpGender.Text));
                        cmd.Parameters.Add(new iDB2Parameter("JOBID", textBoxJobID.Text));
                        cmd.Parameters.Add(new iDB2Parameter("WRKSTATUS", textBoxEmpWrkSts.Text));
                        cmd.Parameters.Add(new iDB2Parameter("HRLYRATE", textBoxEmpHrlyR8.Text));
                        cmd.Parameters.Add(new iDB2Parameter("EMHIREDT", textBoxEmpHrDt.Text));
                        cmd.Parameters.Add(new iDB2Parameter("EMSTARTDT", textBoxEmpStrtDt.Text));
                        cmd.Parameters.Add(new iDB2Parameter("EMTERMDT", textBoxEmpTrmDt.Text));
                        cmd.Parameters.Add(new iDB2Parameter("REGIONID", textBoxEmpRgnID.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee added successfully.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Adding Employee: {ex.Message} ");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();//this closes the Update table and the update table only.
        }
    }
}
