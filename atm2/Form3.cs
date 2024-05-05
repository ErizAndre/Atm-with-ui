using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace atm2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            LoadUserData();
        }
        public string filePath = "UserInfo.json";
        public List<UserCred> userData;
        public string inputPass = " ";

        public class UserCred
        {
            public string User { get; set; }
            public string Pass { get; set; }
        }

        private void LoadUserData()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                userData = JsonConvert.DeserializeObject<List<UserCred>>(json);
            }

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                inputPass = guna2TextBox1.Text;
            }
            catch
            {
                inputPass = "0";
            }
        }

        private void guna2CircleButton12_Click(object sender, EventArgs e)
        {
            bool ifloggedIn = false;

            foreach (UserCred user in userData)
            {
                if (user.Pass == inputPass)
                {
                    ifloggedIn = true;
                    CurrentLogUser.LoggedInPass = inputPass;


                    Form2 Form2 = new Form2();
                    this.Hide();
                    Form2.ShowDialog();
                    break;
                }
            }
            if (!ifloggedIn)
            {
                MessageBox.Show("Wrong Pin Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "1";
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "2";
        }

        private void guna2CircleButton9_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "3";
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "4";
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "5";
        }

        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "6";
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "7";
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "8";
        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "9";
        }

        private void guna2CircleButton10_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "0";
        }

        private void guna2CircleButton11_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = null;
        }
    }
}
