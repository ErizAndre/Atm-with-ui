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
    public partial class Receipt : Form
    {
        public string TransactionType { get; set; }
        public int Amount { get; set; }
        DateTime currentDateTime = DateTime.Now;


        public Receipt()
        {
            InitializeComponent();
            Load += Receipt_Load;
        }
        public void Receipt_Load(object sender, EventArgs e)
        {
            guna2HtmlLabel2.Text = TransactionType;
            guna2HtmlLabel4.Text = DateTime.Now.ToString();
            guna2HtmlLabel5.Text = Amount.ToString();
            guna2HtmlLabel6.Text = GlobalVariables.GlobalIntVariable.ToString();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel2.Text = TransactionType;
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel4.Text = currentDateTime.ToString();
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel5.Text = Amount.ToString();

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel6.Text = GlobalVariables.GlobalIntVariable.ToString();
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
