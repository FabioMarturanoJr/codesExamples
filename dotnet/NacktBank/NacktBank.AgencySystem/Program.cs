using NacktBank.Models.CurrentAccounts;

AccountList list = new AccountList(inicialCapacity: 6);

CurrentAccount fabio = new CurrentAccount(555,4444);

list.Add(fabio);
list.Add(new CurrentAccount(123,1111));
list.Add(new CurrentAccount(123,2222));
list.Add(new CurrentAccount(123,3333));
list.Add(new CurrentAccount(123,3333));
list.Add(new CurrentAccount(123,3333));
list.Add(new CurrentAccount(123,3333));
list.Add(new CurrentAccount(123,3333));
list.Add(new CurrentAccount(123,3333));
list.Add(new CurrentAccount(123,3333));
list.Add(new CurrentAccount(123,3333));
list.Add(new CurrentAccount(123,3333));
list.Add(new CurrentAccount(123,3333));
list.Add(new CurrentAccount(123,3333));
list.Add(new CurrentAccount(123,3333));
list.Add(new CurrentAccount(123,3333));
list.Add(new CurrentAccount(123,3333));
list.Add(new CurrentAccount(123,9999));

list.List();

list.Remove(fabio);

list.List();