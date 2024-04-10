﻿using System;
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

    public partial class deposit : Form
    {
        int[] availableBills = { 20, 50, 100, 200, 500, 1000 };
        int accountBalance = GlobalVariables.GlobalIntVariable;
        private int withdrawalAmount = 0;
        private int remainingAmount = 0;
        private bool dispensed = false;

        public deposit()
        {
            InitializeComponent();
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
            var result = MessageBox.Show("Press Ok again to Confirm?", "Confirm?", MessageBoxButtons.YesNoCancel);

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
                if (withdrawalAmount > accountBalance)
                {
                    MessageBox.Show("Not enough money", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //function for calulating if bills are availble for widthdrawing
                for (int i = availableBills.Length - 1; i >= 0; i--)
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
                GlobalVariables.GlobalIntVariable += withdrawalAmount;
                var receipt = MessageBox.Show("Would you like a receipt", "Depositing!", MessageBoxButtons.YesNo);
                if (receipt == DialogResult.Yes)
                {
                    Receipt Receipt = new Receipt();

                    Receipt.TransactionType = "Account Deposit:";
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
    }
}
