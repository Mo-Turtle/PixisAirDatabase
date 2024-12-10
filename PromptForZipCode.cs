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
    public partial class PromptForZipCode : Form
    {
        public string ZipCode { get; private set; }
        public PromptForZipCode()
        {
            InitializeComponent();
        }

        private void OkayBtn_Click(object sender, EventArgs e)
        {
            ZipCode = textBoxZipCode.Text;//when you click okay, this will set ZipCode to be the ZipCode entered in the textbox
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
