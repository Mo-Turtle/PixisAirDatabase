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
    public partial class Crew_Lookup : Form
    {
        public Crew_Lookup()
        {
            InitializeComponent();
        }

        
        private void Flight_Number_Text(object sender, EventArgs e)
        {
            FlightCrewDisplay flightCrewDisplay = new FlightCrewDisplay();
            flightCrewDisplay.Show();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
