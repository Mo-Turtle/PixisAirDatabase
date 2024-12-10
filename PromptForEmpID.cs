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
    public partial class PromptForEmpID : Form
    {
        public string EmployeeID { get; private set; }//this holds the empID to be accessed outside this form
        public PromptForEmpID()
        {
            InitializeComponent();
        }

        private void PromptForEmpID_Load(object sender, EventArgs e)
        {
            //this is useless.
        }

        private void OkayBtn_Click(object sender, EventArgs e)//this asks
        {
            EmployeeID = textBoxEmpIDPrompt.Text;//when you click okay, this will set EmployeeID to be the ID entered in the textbox
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
