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
using static atm2.withdraw;

namespace atm2
{

    public partial class deposit : Form
    {
        int[] availableBills = { 20 };
        private int withdrawalAmount = 0;
        private int remainingAmount = 0;
        private bool dispensed = false;
        public string filePath = "UserInfo.json";
        public List<UserCred> userData;
        int bal;
        string loggedInUser = CurrentLogUser.LoggedInPass;
        string realuser;

        public string filePath2 = "Transaction.json";
        public List<transacdata> TransHistory = new List<transacdata>();

        
        DateTime currentDateTime = DateTime.Now;

        public class UserCred
        {
            public string User { get; set; }
            public string Pass { get; set; }
            public string Balance { get; set; }
        }
        public void FindUserBalance()
        {

            foreach (var user in userData)
            {
                if (user.Pass == loggedInUser)
                {
                    bal = int.Parse(user.Balance);
                    realuser = user.User;
                    return;
                }
            }
        }
        private void LoadTransactionHistory()
        {
            if (File.Exists(filePath2))
            {
                string json = File.ReadAllText(filePath2);
                TransHistory = JsonConvert.DeserializeObject<List<transacdata>>(json);
            }
        }

        private void LoadUserData()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                userData = JsonConvert.DeserializeObject<List<UserCred>>(json);
            }


        }

        private void SaveUserData()
        {
            string json = JsonConvert.SerializeObject(userData);
            File.WriteAllText(filePath, json);
        }


        public deposit()
        {
            InitializeComponent();
            LoadUserData();
            LoadTransactionHistory();
            FindUserBalance();

            string loggedInUser = CurrentLogUser.LoggedInPass;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxamount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                withdrawalAmount = int.Parse(txtboxamount.Text);
                remainingAmount = int.Parse(txtboxamount.Text);
            }
            catch
            {
                withdrawalAmount = 0;
                remainingAmount = 0;
            }

        }

        private void btnwithdraw_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Press Ok again to Confirm?", "Confirm?", MessageBoxButtons.YesNo);

            // (Start) if yes run the function 
            if (result == DialogResult.Yes)
            {
                //20k limit
                if (withdrawalAmount > 40000)
                {
                    MessageBox.Show("Withdrawal amount exceeds the limit of 40,000 pesos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //check if withdrawalamount is enough
                if (withdrawalAmount > bal)
                {
                    MessageBox.Show("Not enough money", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (withdrawalAmount <= 0)
                {
                    MessageBox.Show("Please enter an amount greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //function for calulating if bills are availble for widthdrawing
                for (int i = 0; i < availableBills.Length; i++)
                {
                    int billCount = remainingAmount / availableBills[i];
                    if (billCount > 0)
                    {
                        remainingAmount %= availableBills[i];
                        dispensed = true;
                    }
                }

                // if cannot dispense bills
                if (!dispensed || remainingAmount > 0)
                {
                    MessageBox.Show("Unable to deposit the full amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Subtract withdrawal amount from account balance

                bal += withdrawalAmount;

                // json transac saving

                string formattedDateTime = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");

                var Transac = new transacdata
                {
                    User = realuser,
                    Amount = $"+₱{withdrawalAmount}",
                    Issuer = "",
                    Date = formattedDateTime
                };
                TransHistory.Add(Transac);
                var json = JsonConvert.SerializeObject(TransHistory);
                File.WriteAllText(filePath2, json);

                //check userbal

                foreach (var user in userData)
                {
                    if (user.Pass == loggedInUser)
                    {
                        user.Balance = bal.ToString();
                        break;
                    }
                }

                SaveUserData();

                //receipt
                var receipt = MessageBox.Show("Would you like a receipt", "Depositing!", MessageBoxButtons.YesNo);
                if (receipt == DialogResult.Yes)
                {
                    

                    Receipt Receipt = new Receipt();

                    Receipt.TransactionType = "Amount Deposit: ";
                    Receipt.Amount = withdrawalAmount;

                    Receipt.ShowDialog();

                    
                }
               

            }
        }

        private void btnmain_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            this.Hide();
            Form2.ShowDialog();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            txtboxamount.Text = "100";
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            txtboxamount.Text = "200";
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            txtboxamount.Text = "500";
        }

        private void btn1000_Click(object sender, EventArgs e)
        {
            txtboxamount.Text = "1000";
        }

        private void btn2000_Click(object sender, EventArgs e)
        {
            txtboxamount.Text = "2000";
        }

        private void btn5000_Click(object sender, EventArgs e)
        {
            txtboxamount.Text = "5000";
        }

        private void btn10000_Click(object sender, EventArgs e)
        {
            txtboxamount.Text = "10000";
        }

        private void btn10500_Click(object sender, EventArgs e)
        {
            txtboxamount.Text = "10500";
        }
    }
}
