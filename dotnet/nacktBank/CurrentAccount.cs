namespace nacktBank
{
    public class CurrentAccount{
        public string owner = "User";
        public int agencyNumb;
        public int accountNumb;
        public double balance;
        public bool Withdraw(double value) {
            if(this.balance == 0 ||this.balance < value) return false;
            this.balance -= value;
            return true;
        }
        public void Deposit(double value) {
            this.balance += value;
        }
        public bool Transfer(double value, CurrentAccount destAccount) { 
            if (!this.Withdraw(value)) return false;
            destAccount.Deposit(value);
            return true;
        }
    }
}