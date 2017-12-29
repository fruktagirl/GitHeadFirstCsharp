using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTraveled;
        double reimburseRate = 0.39;
        double amountOwed;

        public Form1()
        {
            InitializeComponent();
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = Convert.ToInt32(numericUpDown1.Value);
            endingMileage = Convert.ToInt32(numericUpDown2.Value);

            //verify starting and ending mileage
            if(startingMileage > endingMileage)
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage.", "Cannot Calculate");
            }
            else
            {
                //calculate milesTraveled
                milesTraveled = endingMileage - startingMileage;

                //calculate amountOwed
                amountOwed = milesTraveled * reimburseRate;

                label4.Text = "$" + amountOwed;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show( milesTraveled + " miles", "Miles Traveled");
        }
    }
}
