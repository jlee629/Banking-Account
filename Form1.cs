using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsApp
{

    public partial class FrmAccounts : Form
    {
        private List<Account> accounts = new List<Account>();
        private Account myAccount;
        public FrmAccounts()
        {
            InitializeComponent();
        }
        private void rbtnChecking_CheckedChanged(object sender, EventArgs e)
        {
            txtLimit.Enabled = rbtnChecking.Checked;
            txtInterest.Enabled = !rbtnChecking.Checked;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                Account newAccount;
                if (rbtnChecking.Checked)
                {
                    newAccount = new CheckingAccount(int.Parse(txtNumber.Text),
                        txtName.Text,
                        double.Parse(txtBalance.Text),
                        double.Parse(txtLimit.Text));
                }
                else
                {
                    newAccount = new SavingsAccount(int.Parse(txtNumber.Text),
                        txtName.Text,
                        double.Parse(txtBalance.Text),
                        double.Parse(txtInterest.Text));
                }
                accounts.Add(newAccount);
                ClearControls();
                MessageBox.Show($"Total Number of Accounts: {accounts.Count}");
                txtNumber.Focus();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void ClearControls()
        {
            txtNumber.Text = "";
            txtName.Text = "";
            txtBalance.Text = "";
            txtLimit.Text = "";
            txtInterest.Text = "";
            rbtnChecking.Checked = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ClearControls();
                myAccount = null;

                foreach (Account account in accounts)
                {
                    if (account.Number == int.Parse(txtSearch.Text))
                        myAccount = account;
                }

                txtNumber.Text = myAccount.Number.ToString();
                txtName.Text = myAccount.Name;
                txtBalance.Text = myAccount.Balance.ToString();

                if (myAccount is CheckingAccount)
                {
                    txtLimit.Text = (myAccount as CheckingAccount).Limit.ToString();
                    rbtnChecking.Checked = true;
                }
                else
                if (myAccount is SavingsAccount)
                {
                    txtInterest.Text = (myAccount as SavingsAccount).Interest.ToString();
                    rbtnSavings.Checked = true;
                }
            }
            catch (Exception)
            {
                ClearControls();
                MessageBox.Show("Account not found!");
            }
        }

        private void FrmAccounts_Load(object sender, EventArgs e)
        {
            accounts.Add(new CheckingAccount(141, "Lee", 40, 10));
            accounts.Add(new SavingsAccount(241, "Kim", 30, 0.5));
        }
    }
}
