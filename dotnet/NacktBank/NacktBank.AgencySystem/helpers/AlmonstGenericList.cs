namespace NacktBank.AgencySystem.helpers
{
    public class AlmonstGenericList
    {
        private object[] _items;
        private int _nextPosition;
        public int TotalItems { get { return _nextPosition; } }

        public AlmonstGenericList(int nextPosition = 0, int inicialCapacity = 5)
        {
            _items = new object[inicialCapacity];
            _nextPosition = nextPosition;
        }
        public void Add(object item) {
            VerifyCapacity(_nextPosition + 1);
            // System.Console.WriteLine($"add position {_nextPosition}");

            _items[_nextPosition] = item;
            _nextPosition++;
        }
        public void AddMoreThanOne(params object[] items) {
            foreach (object item in items)
            {
                Add(item);
            }
        }
        public void Remove(object item) {
            int indexItem = -1;

            for(int i = 0; i < _nextPosition; i++)
            {
                if(_items[i].Equals(item)) {
                    indexItem = i;
                    break;
                }
            }

            for (int i = 0; i < _nextPosition; i++)
            {
                _items[i] = _items[i +1];
            }
            _nextPosition--;
            _items[_nextPosition] = null;
        }
        public void List() {
            for (int i = 0; i < _nextPosition; i++)
            {
                System.Console.WriteLine($"{i}: {_items[i]}");
            }
        }
        public object GetObjectByIndex(int index) {
            if(index < 0 || index >= _nextPosition)
                throw new ArgumentOutOfRangeException(nameof(index));

            return _items[index];
        }
        private void VerifyCapacity(int requiredSize) {
            if(_items.Length >= requiredSize) return;

            int newLength = _items.Length * 2;

            if (newLength < requiredSize) {
                newLength = requiredSize;
            }

            // System.Console.WriteLine($"increase Size");
            object[] newAccount = new object[newLength];
            
            for (int i = 0; i < _items.Length; i++)
            {
                newAccount[i] = _items[i];
                // System.Console.WriteLine('.');
            }
            _items = newAccount;
        }
        public object this[int index] {
            get 
            {
                return GetObjectByIndex(index);
            }
        }
    }
}