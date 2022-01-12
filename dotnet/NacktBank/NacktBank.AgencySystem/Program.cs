using NacktBank.Models.CurrentAccounts;

AccountList list = new AccountList(inicialCapacity: 6);

CurrentAccount fabio = new CurrentAccount(555,4444);

list.Add(fabio);
list.Add(new CurrentAccount(123,1111));
list.Add(new CurrentAccount(123,2222));

CurrentAccount[] accounts = new CurrentAccount[] {
    new CurrentAccount(123,2222),
    new CurrentAccount(123,3333),
    new CurrentAccount(123,4444),
    new CurrentAccount(123,5555),
    new CurrentAccount(123,6666),
    new CurrentAccount(123,7777),
    new CurrentAccount(123,8888),
};

list.AddMoreThanOne(accounts);

list.AddMoreThanOne(
    new CurrentAccount(123,2222),
    new CurrentAccount(123,3333),
    new CurrentAccount(123,4444),
    new CurrentAccount(123,5555),
    new CurrentAccount(123,6666),
    new CurrentAccount(123,7777),
    new CurrentAccount(123,8888));

// list.List();
// list.Remove(fabio);
// list.List();

for (int i = 0; i < list.TotalAccounts; i++)
{
    System.Console.WriteLine(list[i]);
}