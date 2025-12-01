namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OwnerTxt.Text))
                return;

            BankAccount bankAccount = new BankAccount(OwnerTxt.Text);
            BankAccounts.Add(bankAccount);

            RefreshGrid();
            OwnerTxt.Text = string.Empty;
        }

        private void RefreshGrid()
        {
            BankAccountGrid.DataSource = null;
            BankAccountGrid.DataSource = BankAccounts;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccount selectedBankAccount = BankAccountGrid.SelectedRows[0].DataBoundItem as BankAccount;

                selectedBankAccount.Balance += AmountNum.Value;

                RefreshGrid();
                AmountNum.Value = 0;
            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccount selectedBankAccount = BankAccountGrid.SelectedRows[0].DataBoundItem as BankAccount;
                if (AmountNum.Value < selectedBankAccount.Balance)
                {
                    selectedBankAccount.Balance -= AmountNum.Value;

                    RefreshGrid();
                    AmountNum.Value = 0;
                }
                else
                {
                    MessageBox.Show("Insufficient Funds");
                }
                
                
            }
        }
    }
}
