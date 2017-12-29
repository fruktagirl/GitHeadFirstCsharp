using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DinnerParty
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        private void DisplayDinnerPartyCost()
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            dinnerParty.HealthyOption = checkBox2.Checked;
            bool fancyDecoration = checkBox1.Checked;
            decimal totalCost = dinnerParty.CalculateCost();

            textBox1.Text = totalCost.ToString();
        }

        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty();


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }
    }
}
