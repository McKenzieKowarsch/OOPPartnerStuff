using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        double const FEE = 25.00;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void calcRevenueBtn_Click(object sender, EventArgs e)
        {
            contestents1 = inputLastYeat.Text;
            contestents2 = inputThisYeat.Text;
            double revenue = int.Parse(contestents2) * FEE;
            outputRevenue.Text = revenue.ToString("C");
            outputRevenue.Visible = true;
            bool yearTwoIsBigger = double.Parse(contestents2) > double.Parse(contestents1);
            outputMoreOrLess.Text = String.Format("It is {0} that this year has more contestents than last year.", yearTwoIsBigger);
            outputMoreOrLess.Visible = true;
            
        }
    }
}
