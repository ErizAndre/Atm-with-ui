using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace atm2
{
    public partial class paybills : Form
    {
        public paybills()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BillsBox_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            this.Hide();
            Form2.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedItem == "Electric")
            {
                comboBox2.Items.Add("Meralco");
                comboBox2.Items.Add("Pelco 1");
                comboBox2.Items.Add("Pelco 2");
                comboBox2.Items.Add("Presco");
            }
            if (comboBox1.SelectedItem == "Water")
            {
                comboBox2.Items.Add("BCBI Waterworks");
                comboBox2.Items.Add("Maynilad ");
                comboBox2.Items.Add("NAWASA");
                comboBox2.Items.Add("Clark Water");
            }
            if (comboBox1.SelectedItem == "Credit Card")
            {
                comboBox2.Items.Add("UnionBank Rewards Credit Card");
                comboBox2.Items.Add("Metrobank World Mastercard®");
                comboBox2.Items.Add("AUB Classic Mastercard");
                comboBox2.Items.Add(" BPI Rewards Card");
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
