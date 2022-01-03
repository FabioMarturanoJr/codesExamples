namespace nacktBank.CurrentAccounts
{
    public class CurrentAccount {
        public static double TransactionFee { get; private set; }
        public static int TotalAccounts { get; private set; }
        public Client Owner { get; set; } = new Client();
        public int Agency { get;}
        public int Account { get; }
        private double _balance;
        public double Balance {
            get { return _balance; }
            set { 
                if (value >= 0) _balance = value; 
            }
        }        
        public CurrentAccount(int agency, int account) {
            Agency = agency;
            Account = account;
            TotalAccounts++;
            TransactionFee = 30 / TotalAccounts;
        }
        public bool Withdraw(double value) {
            if(_balance == 0 ||_balance < value) return false;
            _balance -= value;
            return true;
        }
        public void Deposit(double value) {
            _balance += value;
        }
        public bool Transfer(double value, CurrentAccount destAccount) { 
            if (!this.Withdraw(value)) return false;
            destAccount.Deposit(value);
            return true;
        }
    }
}