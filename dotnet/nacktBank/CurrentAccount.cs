namespace nacktBank
{
    public class CurrentAccount {
        public CurrentAccount(int agencyNumb, int accountNumb) {
            AgencyNumb = agencyNumb;
            AccountNumb = accountNumb;
            TotalAccounts++;
        }
        public static int TotalAccounts { get; private set; }
        public Client Owner { get; set; } = new Client();
        public int AgencyNumb { get; set; }
        public int AccountNumb { get; set; }
        private double _balance;
        public double Balance {
            get { return _balance; }
            set { if (value >= 0) _balance = value; }
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