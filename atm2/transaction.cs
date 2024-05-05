using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static atm2.withdraw;

namespace atm2
{

    public partial class transaction : Form
    {
        public string filePath2 = "Transaction.json";
        public List<transacdata> TransHistory;
        string loggedInUser = CurrentLogUser.LoggedInPass;
        private List<transacdata> userTransactions;

        public string filePath = "UserInfo.json";
        public List<UserCred> userData;
        string realuser;
        private void LoadUserData()
        {
            if (File.Exists(filePath))
            {

                string json = File.ReadAllText(filePath);
                userData = JsonConvert.DeserializeObject<List<UserCred>>(json);
            }

        }

        public void FindUserBalance()
        {

            foreach (var user in userData)
            {
                if (user.Pass == loggedInUser)
                {
                    realuser = user.User;
                    return;
                }
            }
        }

        public class transacdata
        {
            public string User { get; set; }
            public string Amount { get; set; }
            public string Issuer { get; set; }
            public string Date { get; set; }
        }

        public transaction()
        {
            InitializeComponent();
            LoadUserData();
            LoadTransactionHistory();
            FindUserBalance();
            FilterTransactionsByUser();
            InitializeDataGridView();
            PopulateDataGridView();
        }

        private void LoadTransactionHistory()
        {
            if (File.Exists(filePath2))
            {
                string json = File.ReadAllText(filePath2);
                TransHistory = JsonConvert.DeserializeObject<List<transacdata>>(json);
            }

        }


        private void FilterTransactionsByUser()
        {
            userTransactions = new List<transacdata>();
            foreach (var transaction in TransHistory)
            {
                if (transaction.User == realuser)
                {
                    userTransactions.Add(transaction);
                }
            }
        }

        private void PopulateDataGridView()
        {
            guna2DataGridView1.Rows.Clear();
            foreach (var transaction in userTransactions)
            {
                guna2DataGridView1.Rows.Add(transaction.User, transaction.Amount, transaction.Issuer, transaction.Date);
            }
        }
        private void InitializeDataGridView()
        {

            guna2DataGridView1.Columns.Clear();


            guna2DataGridView1.Columns.Add("User", "User");
            guna2DataGridView1.Columns.Add("Amount", "Amount");
            guna2DataGridView1.Columns.Add("Issuer", "Issuer");
            guna2DataGridView1.Columns.Add("Date", "Date");
        }



        private void transaction_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            this.Hide();
            Form2.ShowDialog();
        }
    }
}
