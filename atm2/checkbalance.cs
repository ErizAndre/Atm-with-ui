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

namespace atm2
{

    public partial class checkbalance : Form
    {
        public string filePath = "UserInfo.json";
        public List<UserCred> userData;
      
        string bal;
        private void LoadUserData()
        {
            if (File.Exists(filePath))
            {

                string json = File.ReadAllText(filePath);
                userData = JsonConvert.DeserializeObject<List<UserCred>>(json);
            }

        }
        public checkbalance()
        {
            InitializeComponent();
            LoadUserData();
            string loggedInUser = CurrentLogUser.LoggedInPass;
            FindUserBalance(); 
            UpdateBalance(); 
        }

        public class UserCred
        {
            public string User { get; set; }
            public string Pass { get; set; }
            public string Balance {  get; set; }
        }

        public void FindUserBalance()
        {
            string loggedInUser = CurrentLogUser.LoggedInPass;

            foreach (var user in userData)
            {
                if (user.Pass == loggedInUser)
                {
                    bal = user.Balance;
                    return; 
                }
            }
        }

        public void UpdateBalance()
        {
            txtboxBal.Text = bal;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            txtboxBal.Text = bal;
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            this.Hide();
            Form2.ShowDialog();
        }
    }
}
