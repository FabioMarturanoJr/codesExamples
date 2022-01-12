namespace NacktBank.Models.CurrentAccounts
{
    public class AccountList
    {
        private CurrentAccount[] _account;
        private int _nextPosition;
        public int TotalAccounts { get { return _nextPosition; } }

        public AccountList(int nextPosition = 0, int inicialCapacity = 5)
        {
            _account = new CurrentAccount[inicialCapacity];
            _nextPosition = nextPosition;
        }
        public void Add(CurrentAccount account) {
            VerifyCapacity(_nextPosition + 1);
            // System.Console.WriteLine($"add position {_nextPosition}");

            _account[_nextPosition] = account;
            _nextPosition++;
        }
        public void AddMoreThanOne(params CurrentAccount[] accounts) {
            foreach (CurrentAccount account in accounts)
            {
                Add(account);
            }
        }
        public void Remove(CurrentAccount account) {
            int indexAccount = -1;

            for(int i = 0; i < _nextPosition; i++)
            {
                if(_account[i].Equals(account)) {
                    indexAccount = i;
                    break;
                }
            }

            for (int i = 0; i < _nextPosition; i++)
            {
                _account[i] = _account[i +1];
            }
            _nextPosition--;
            _account[_nextPosition] = null;
        }
        public void List() {
            for (int i = 0; i < _nextPosition; i++)
            {
                // System.Console.WriteLine($"{i}: {_account[i]}");
            }
        }
        public CurrentAccount GetCurrentAccountByIndex(int index) {
            if(index < 0 || index >= _nextPosition)
                throw new ArgumentOutOfRangeException(nameof(index));

            return _account[index];
        }
        private void VerifyCapacity(int requiredSize) {
            if(_account.Length >= requiredSize) return;

            int newLength = _account.Length * 2;

            if (newLength < requiredSize) {
                newLength = requiredSize;
            }

            // System.Console.WriteLine($"increase Size");
            CurrentAccount[] newAccount = new CurrentAccount[newLength];
            
            for (int i = 0; i < _account.Length; i++)
            {
                newAccount[i] = _account[i];
                // System.Console.WriteLine('.');
            }
            _account = newAccount;
        }
        public CurrentAccount this[int index] {
            get 
            {
                return GetCurrentAccountByIndex(index);
            }
        }
    }
}