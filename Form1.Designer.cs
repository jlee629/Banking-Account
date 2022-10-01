
namespace AccountsApp
{
    partial class FrmAccounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.lblLimit = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.lblInterest = new System.Windows.Forms.Label();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.rbtnChecking = new System.Windows.Forms.RadioButton();
            this.rbtnSavings = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grpDetails.SuspendLayout();
            this.grpType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(592, 378);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(168, 43);
            this.btnCreateAccount.TabIndex = 0;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.grpType);
            this.grpDetails.Controls.Add(this.txtInterest);
            this.grpDetails.Controls.Add(this.lblInterest);
            this.grpDetails.Controls.Add(this.txtLimit);
            this.grpDetails.Controls.Add(this.lblLimit);
            this.grpDetails.Controls.Add(this.txtBalance);
            this.grpDetails.Controls.Add(this.lblBalance);
            this.grpDetails.Controls.Add(this.txtName);
            this.grpDetails.Controls.Add(this.lblName);
            this.grpDetails.Controls.Add(this.txtNumber);
            this.grpDetails.Controls.Add(this.lblNumber);
            this.grpDetails.Location = new System.Drawing.Point(37, 31);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(723, 317);
            this.grpDetails.TabIndex = 1;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Account Details";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(73, 52);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(124, 15);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Account Number: ";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(257, 52);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(114, 25);
            this.txtNumber.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(257, 105);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(114, 25);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(73, 105);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Client Name: ";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(257, 152);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(114, 25);
            this.txtBalance.TabIndex = 5;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(73, 152);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(65, 15);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Balance:";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(257, 199);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(114, 25);
            this.txtLimit.TabIndex = 7;
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(73, 199);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(142, 15);
            this.lblLimit.TabIndex = 6;
            this.lblLimit.Text = "Daily Withdraw Limit:";
            // 
            // txtInterest
            // 
            this.txtInterest.Enabled = false;
            this.txtInterest.Location = new System.Drawing.Point(257, 247);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(114, 25);
            this.txtInterest.TabIndex = 9;
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(73, 247);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(94, 15);
            this.lblInterest.TabIndex = 8;
            this.lblInterest.Text = "Interest Rate:";
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.rbtnSavings);
            this.grpType.Controls.Add(this.rbtnChecking);
            this.grpType.Location = new System.Drawing.Point(472, 56);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(200, 149);
            this.grpType.TabIndex = 10;
            this.grpType.TabStop = false;
            this.grpType.Text = "Type of Account";
            // 
            // rbtnChecking
            // 
            this.rbtnChecking.AutoSize = true;
            this.rbtnChecking.Checked = true;
            this.rbtnChecking.Location = new System.Drawing.Point(27, 45);
            this.rbtnChecking.Name = "rbtnChecking";
            this.rbtnChecking.Size = new System.Drawing.Size(88, 19);
            this.rbtnChecking.TabIndex = 0;
            this.rbtnChecking.TabStop = true;
            this.rbtnChecking.Text = "Checking";
            this.rbtnChecking.UseVisualStyleBackColor = true;
            this.rbtnChecking.CheckedChanged += new System.EventHandler(this.rbtnChecking_CheckedChanged);
            // 
            // rbtnSavings
            // 
            this.rbtnSavings.AutoSize = true;
            this.rbtnSavings.Location = new System.Drawing.Point(27, 92);
            this.rbtnSavings.Name = "rbtnSavings";
            this.rbtnSavings.Size = new System.Drawing.Size(81, 19);
            this.rbtnSavings.TabIndex = 1;
            this.rbtnSavings.Text = "Savings";
            this.rbtnSavings.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(385, 387);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 34);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(242, 391);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(127, 25);
            this.txtSearch.TabIndex = 21;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(41, 392);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(193, 15);
            this.lblSearch.TabIndex = 20;
            this.lblSearch.Text = "Search By Account Number:";
            // 
            // FrmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnCreateAccount);
            this.Name = "FrmAccounts";
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.FrmAccounts_Load);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.RadioButton rbtnSavings;
        private System.Windows.Forms.RadioButton rbtnChecking;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}

