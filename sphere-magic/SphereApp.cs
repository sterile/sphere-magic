/*
 * Grading ID: M5477
 * Lab: 3
 * Due Date: Feb 10 2019
 * Course Section: 01
 * Description: This application takes the radius of a sphere and calculates diameter, surface area, and volume.
 */

 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sphere_magic
{
    public partial class SphereApp : Form
    {
        public SphereApp()
        {
            InitializeComponent();
        }

        // Handles the 'calculate' button being clicked by performing mathematical magical
        private void calcBtn_Click(object sender, EventArgs e)
        {
            double diameter, // Variable to be set when we calculate diameter
                surfaceArea, // ... and we'll do the same for surface area
                volume;      // ... surprisingly we're doing the same for volume!

            double radius;   // A pretty place to hold the user's input for radius

            // Performs calculations

            radius = double.Parse(radiusTBox.Text);

            diameter = 2.0 * radius;
            surfaceArea = 4.0 * Math.PI * Math.Pow(radius, 2.0);
            volume = (4.0 * Math.PI * Math.Pow(radius, 3.0)) / 3.0;

            // Sets label values to show calculations

            calcDiameterLabel.Text = diameter.ToString("F2");
            calcSurfaceLbl.Text = surfaceArea.ToString("F2");
            calcVolumeLbl.Text = volume.ToString("F2");
        }
    }
}
