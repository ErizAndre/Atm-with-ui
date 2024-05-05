using Guna.UI2.WinForms;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnbal_Click(object sender, EventArgs e)
        {
            deposit deposit = new deposit();
            this.Hide();
            deposit.ShowDialog();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            checkbalance checkbalance = new checkbalance();
            this.Hide();
            checkbalance.ShowDialog();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            withdraw withdraw = new withdraw();
            this.Hide();
            withdraw.ShowDialog();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            paybills paybills = new paybills();
            this.Hide();
            paybills.ShowDialog();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.ShowDialog();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            transaction transaction = new transaction();
            this.Hide();
            transaction.ShowDialog();
        }
    }
}
