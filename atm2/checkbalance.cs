using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm2
{

    public partial class checkbalance : Form
    {
        int value = GlobalVariables.GlobalIntVariable;

        public checkbalance()
        {
            InitializeComponent();
            UpdateBalance();
        }

        public void UpdateBalance()
        {
            txtboxBal.Text = GlobalVariables.GlobalIntVariable.ToString();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            txtboxBal.Text = GlobalVariables.GlobalIntVariable.ToString();
        }
    }
}
