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
        const double FEE = 25.00;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void calcRevenueBtn_Click(object sender, EventArgs e)
        {
            string contestants1 = inputLastYear.Text;
            string contestants2 = inputThisYear.Text;
            double revenue = int.Parse(contestants2) * FEE;
            outputRevenue.Text = revenue.ToString("C");
            outputRevenue.Visible = true;
            bool yearTwoIsBigger = double.Parse(contestants2) > double.Parse(contestants1);
            outputMoreOrLess.Text = String.Format("It is {0} that this year has more contestants than last year.", yearTwoIsBigger);
            outputMoreOrLess.Visible = true;
            
        }
    }
}
