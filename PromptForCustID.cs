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
    public partial class PromptForCustID : Form
    {
        public string CustomerID { get; private set; }
        public PromptForCustID()
        {
            InitializeComponent();
        }

        private void OkayBtn_Click(object sender, EventArgs e)
        {
            CustomerID = textBoxCustSSN.Text;//when you click okay, this will set CustomerID to be the ID entered in the textbox
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
