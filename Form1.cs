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
// Team 1: Connor, Jacey, Pamela, Thomas
// Date: 12/2/2024
// 
//
//
namespace PixisAirDatabaseTest2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void addOrUpdateEmpLstBtn_Click(object sender, EventArgs e)
        {
            //does nothing because I moved this button to the EmployeeList Form
        }

        private void dspEmpListBtn_Click(object sender, EventArgs e)
        {
            //opens the EmployeeList Form
            EmployeeList employeeList = new EmployeeList();
            employeeList.Show();
        }

        private void ListJobsBtn_Click(object sender, EventArgs e)
        {
            ListJobs listJobs = new ListJobs();
            listJobs.Show();
        }

        private void MngCstmrsBtn_Click(object sender, EventArgs e)
        {
            ManageCustomers manageCustomers = new ManageCustomers();
            manageCustomers.Show();
        }

        private void ZipCodeBtn_Click(object sender, EventArgs e)
        {
            ZipCodeList zipCodeList = new ZipCodeList();
            zipCodeList.Show();
        }

        private void displayEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeList employeeList = new EmployeeList();
            employeeList.Show();
        }

        private void displayJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListJobs listJobs = new ListJobs();
            listJobs.Show();
        }

        private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomers manageCustomers = new ManageCustomers();
            manageCustomers.Show();
        }

        private void manageLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZipCodeList zipCodeList = new ZipCodeList();
            zipCodeList.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FlightCrew_Btn_Click(object sender, EventArgs e)
        {
            FlightDisplay flightDisplay = new FlightDisplay();
            flightDisplay.Show();
        }

        private void CrewDisplay_CheckedChanged(object sender, EventArgs e)
        {
            //ignore this. Was the crew checkbox but I replaced it with a button.
        }

        private void CrewBtn_Click(object sender, EventArgs e)
        {
            CrewDisplay crewDisplay = new CrewDisplay();
            crewDisplay.Show();
        }
    }
}
