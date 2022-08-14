using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WGS84_DMS_Arc_Distance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Input variables
            string latInputString = latitudeTextbox.Text;   // user input latitude (degrees) as string
            double latInputDeg = 0.0;                       // user input latitude (degrees) as double


            if (double.TryParse(latitudeTextbox.Text, out latInputDeg) &&
                latInputDeg <= 90 && latInputDeg >= -90)
            {
                double latInputRad = latInputDeg * (Math.PI / 180.0);

                // Formula calculation components
                double ERAD = 6378137.0;                            // equatorial radius
                double PRAD = 6356752.3142;                         // polar radius
                double FLAT = (ERAD - PRAD) / ERAD;                 // flattening/oblateness
                double ESQD = (2.0 * FLAT) - Math.Pow(FLAT, 2.0);   // eccentricity squared


                // East/West calculation (in meters)
                double ewCalcMeters = ((Math.PI) * ERAD * (Math.Cos(latInputRad))) /
                    (180.0 * (Math.Sqrt((1.0 - (ESQD * (Math.Pow((Math.Sin(latInputRad)), 2.0)))))));

                // North/South calculation (in meters)
                /*double nsCalcMeters = ((Math.PI) * ERAD * (1.0 - ESQD)) /
                    (180.0 * (Math.Pow((1.0 - (ESQD * (Math.Pow((Math.Sin(latInputRad)), 2.0)))), (1.5))));*/

                double nsCalcMeters = 111132.954 - (559.822 * (Math.Cos(2 * latInputRad))) +
                    (1.175 * (Math.Cos(4 * latInputRad)));




                // Variables - East/West distance measurement output
                double ewDistDeg = 0.0;
                double ewDistMin = 0.0;
                double ewDistSec = 0.0;

                // Variables - North/South distance measurement output
                double nsDistDeg = 0.0;
                double nsDistMin = 0.0;
                double nsDistSec = 0.0;




                // Calculate values for distance output labels
                if (kilometersRadioButton.Checked)
                {
                    ewDistDeg = ewCalcMeters * 0.001;
                    ewDistMin = ewDistDeg / 60.0;
                    ewDistSec = ewDistDeg / 3600.0;

                    nsDistDeg = nsCalcMeters * 0.001;
                    nsDistMin = nsDistDeg / 60.0;
                    nsDistSec = nsDistDeg / 3600.0;

                    // assign unit to unit labels
                    degreeEWUnitLabel.Text = "kilometers";
                    minuteEWUnitLabel.Text = "kilometers";
                    secondEWUnitLabel.Text = "kilometers";

                    degreeNSUnitLabel.Text = "kilometers";
                    minuteNSUnitLabel.Text = "kilometers";
                    secondNSUnitLabel.Text = "kilometers";
                }

                else if (metersRadioButton.Checked)
                {
                    ewDistDeg = ewCalcMeters;
                    ewDistMin = ewDistDeg / 60.0;
                    ewDistSec = ewDistDeg / 3600.0;

                    nsDistDeg = nsCalcMeters;
                    nsDistMin = nsDistDeg / 60.0;
                    nsDistSec = nsDistDeg / 3600.0;

                    // assign unit to unit labels
                    degreeEWUnitLabel.Text = "meters";
                    minuteEWUnitLabel.Text = "meters";
                    secondEWUnitLabel.Text = "meters";

                    degreeNSUnitLabel.Text = "meters";
                    minuteNSUnitLabel.Text = "meters";
                    secondNSUnitLabel.Text = "meters";
                }

                else if (milesRadioButton.Checked)
                {
                    ewDistDeg = ewCalcMeters * 0.0006213712;
                    ewDistMin = ewDistDeg / 60.0;
                    ewDistSec = ewDistDeg / 3600.0;

                    nsDistDeg = nsCalcMeters * 0.0006213712;
                    nsDistMin = nsDistDeg / 60.0;
                    nsDistSec = nsDistDeg / 3600.0;

                    // assign unit to unit labels
                    degreeEWUnitLabel.Text = "miles";
                    minuteEWUnitLabel.Text = "miles";
                    secondEWUnitLabel.Text = "miles";

                    degreeNSUnitLabel.Text = "miles";
                    minuteNSUnitLabel.Text = "miles";
                    secondNSUnitLabel.Text = "miles";
                }

                else
                {
                    ewDistDeg = ewCalcMeters * 3.2808399;
                    ewDistMin = ewDistDeg / 60.0;
                    ewDistSec = ewDistDeg / 3600.0;

                    nsDistDeg = nsCalcMeters * 3.2808399;
                    nsDistMin = nsDistDeg / 60.0;
                    nsDistSec = nsDistDeg / 3600.0;

                    // assign unit to unit labels
                    degreeEWUnitLabel.Text = "feet";
                    minuteEWUnitLabel.Text = "feet";
                    secondEWUnitLabel.Text = "feet";

                    degreeNSUnitLabel.Text = "feet";
                    minuteNSUnitLabel.Text = "feet";
                    secondNSUnitLabel.Text = "feet";
                }

                // Assign values to distance output labels
                ewDegreeOutput.Text = ewDistDeg.ToString("n3");
                ewMinuteOutput.Text = ewDistMin.ToString("n3");
                ewSecondOutput.Text = ewDistSec.ToString("n3");

                nsDegreeOutput.Text = nsDistDeg.ToString("n3");
                nsMinuteOutput.Text = nsDistMin.ToString("n3");
                nsSecondOutput.Text = nsDistSec.ToString("n3");
            }
            else
            {
                MessageBox.Show("Invalid input!\n\n" +
                   "Enter a latitude between\n" + "-90° and 90° (inclusive).",
                   "Invalid Input", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear all text boxes and labels
            latitudeTextbox.Text = String.Empty;
            ewDegreeOutput.Text = String.Empty;
            ewMinuteOutput.Text = String.Empty;
            ewSecondOutput.Text = String.Empty;
            nsDegreeOutput.Text = String.Empty;
            nsMinuteOutput.Text = String.Empty;
            nsSecondOutput.Text = String.Empty;

            degreeEWUnitLabel.Text = String.Empty;
            minuteEWUnitLabel.Text = String.Empty;
            secondEWUnitLabel.Text = String.Empty;
            degreeNSUnitLabel.Text = String.Empty;
            minuteNSUnitLabel.Text = String.Empty;
            secondNSUnitLabel.Text = String.Empty;

            // Set unit selection to kilometers
            kilometersRadioButton.Checked = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This calculator computes the arc distance of one degree,\n" +
                "minute, and second of longitude and latitude from any\n" +
                "given latitude (expressed in the user's choice of kilometers,\n" +
                "meters, miles, or feet).\n\n" +
                "The values derived with this calculator are based on the\n" +
                "World Geodetic Survey 1984 (WGS84) reference ellipsoid.\n\n" +
                "The radii used in the formulas are as follows:\n\n" +
                "Semi-major (equatorial) --> 6,378,137.0000 meters\n" +
                "Semi-minor (polar) --------> 6,356,752.3142 meters",
                "About", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DMS Arc Distance Calculator\n" +
                "by Brandon Hoffman\nCopyright 2021",
                "Credit", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
