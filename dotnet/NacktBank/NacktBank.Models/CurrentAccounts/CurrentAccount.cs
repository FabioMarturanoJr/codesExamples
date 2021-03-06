using NacktBank.Models.CustomExceptions;

namespace NacktBank.Models.CurrentAccounts
{
    /// <summary>
    /// Define a current account from the Bank.
    /// </summary>
    public class CurrentAccount {
        public static double TransactionFee { get; private set; }
        public static int TotalAccounts { get; private set; }
        public Client Owner { get; set; } = new Client();
        public int Agency { get;}
        public int Account { get; }
        public int TotalNotAllowedWithdraw { get; private set; }
        public int TotalNotAllowedDeposit { get; private set; }
        private double _balance;
        public double Balance {
            get { return _balance; }
            set { 
                if (value >= 0) _balance = value; 
            }
        }
        /// <summary>
        /// Create a instance of currente accounts.
        /// </summary>
        /// <param name="agency">Represents <see cref="Agency"/> number and shoud be greater than zero</param>
        /// <param name="account">Represents <see cref="Account"/> number and shoud be greater than zero</param>
        public CurrentAccount(int agency, int account) {
            if ( account <= 0) throw new ArgumentException("shoud be greater than zero", nameof(account));
            if (agency <= 0) throw new ArgumentException("shoud be greater than zero", nameof(agency)); 

            Agency = agency;
            Account = account;
            TotalAccounts++;
            TransactionFee = 30 / TotalAccounts;
        }
        /// <summary>
        /// cash out and update the propert <see cref="Balance"/>
        /// </summary>
        /// <exception cref="InsufficientBalanceException">Where trying witthdraw with <see cref="Balance"/> zero or <see cref="Balance"/> lower than <paramref name="value"/></exception>
        /// <param name="value">the valeu shoud be greater than zero end the propert <see cref="Balance"/> shoud not to be lower  or equal zero</param>
        public void Withdraw(double value) {
            if(_balance == 0 ||_balance < value) {
                TotalNotAllowedWithdraw++;
                throw new InsufficientBalanceException("Balance insufficient to withdraw", Balance, value);
            }
            _balance -= value;
        }
        public void Deposit(double value) {
            if (value <= 0) {
                TotalNotAllowedDeposit++;
                throw new DepositInvalidException($"{nameof(Deposit)} shoud be greater than zero");
            }
            _balance += value;
        }
        public void Transfer(double value, CurrentAccount destAccount) {
            if (value <= 0) {
                throw new ArgumentException("shoud be greater than zero", nameof(value));
            }
            try
            {
                Withdraw(value);
                destAccount.Deposit(value);
            }
            catch (InsufficientBalanceException e)
            {
                throw new FinancialOperationException("Error Operation withdraw", e);
            }
            catch (DepositInvalidException e) {
                throw new FinancialOperationException("Error Operation deposit", e);
            }

        }
        public override string ToString()
        {
            return $"{Agency}, {Account}, {Balance}";
        }
        public override bool Equals(object? obj)
        {
            CurrentAccount objAccout = obj as CurrentAccount;

            if (objAccout == null) return false;

            return Account == objAccout.Account && Agency == objAccout.Agency;
        }
    }
}