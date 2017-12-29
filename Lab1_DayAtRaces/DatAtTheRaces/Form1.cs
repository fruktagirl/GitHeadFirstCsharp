using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DatAtTheRaces
{
    public partial class Form1 : Form
    {
        Guy joe = new Guy();
        Guy bob;
        Guy al;

        public Form1()
        {
            InitializeComponent();
            joe.Name = "Joe";
            joe.Cash = 10;
            joe.UpdateLabels();
        }



        



        Greyhound grayhound1 = new Greyhound();
 
    }
}
