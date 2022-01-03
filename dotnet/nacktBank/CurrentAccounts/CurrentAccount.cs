using nacktBank.CustomExceptions;

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
            if ( account <= 0) throw new ArgumentException("shoud be greater than zero", nameof(account));
            if (agency <= 0) throw new ArgumentException("shoud be greater than zero", nameof(agency)); 

            Agency = agency;
            Account = account;
            TotalAccounts++;
            TransactionFee = 30 / TotalAccounts;
        }
        public void Withdraw(double value) {
            if(_balance == 0 ||_balance < value) {
                throw new InsufficientBalanceException("Balance insufficient to withdraw");
            }
            _balance -= value;
        }
        public void Deposit(double value) {
            if (value <= 0) {
                throw new DepositInvalidException($"{nameof(Deposit)} shoud be greater than zero");
            }
            _balance += value;
        }
        public void Transfer(double value, CurrentAccount destAccount) {
            try
            {
                this.Withdraw(value);
                destAccount.Deposit(value);
                 
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}