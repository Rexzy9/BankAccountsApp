namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //bankAccount.Owner = "Adelowotan Victor";
            //bankAccount.AccountNumber = Guid.NewGuid();
            //bankAccount.Balance = 250;

            BankAccount bankAccount = new BankAccount("Adelowotan Victor");
            BankAccount bankAccount2 = new BankAccount("Steve Jobs");
            BankAccount bankAccount3 = new BankAccount("Oluwaropo Jones");
            BankAccount bankAccount4 = new BankAccount("George Gameliel");
            

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount);
            bankAccounts.Add(bankAccount2);
            bankAccounts.Add(bankAccount3);
            bankAccounts.Add(bankAccount4);

            BankAccountGrid.DataSource = bankAccounts;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
