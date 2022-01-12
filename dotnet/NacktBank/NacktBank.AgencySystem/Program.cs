using NacktBank.AgencySystem.helpers;
using NacktBank.Models.CurrentAccounts;

AccountList accountList = new AccountList(inicialCapacity: 6);

CurrentAccount fabio = new CurrentAccount(555,4444);

accountList.Add(fabio);
accountList.Add(new CurrentAccount(123,1111));
accountList.Add(new CurrentAccount(123,2222));

CurrentAccount[] accounts = new CurrentAccount[] {
    new CurrentAccount(123,2222),
    new CurrentAccount(123,3333),
    new CurrentAccount(123,4444),
    new CurrentAccount(123,5555),
    new CurrentAccount(123,6666),
    new CurrentAccount(123,7777),
    new CurrentAccount(123,8888),
};

accountList.AddMoreThanOne(accounts);

accountList.AddMoreThanOne(
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

for (int i = 0; i < accountList.TotalAccounts; i++)
{
    System.Console.WriteLine(accountList[i]);
}

System.Console.WriteLine("=====================================================");

AlmonstGenericList agesList = new AlmonstGenericList();

agesList.AddMoreThanOne(20,15,40,30, "fabio");

agesList.List();

for (int i = 0; i < agesList.TotalItems; i++)
{   
    System.Console.WriteLine(agesList[i]);
}

System.Console.WriteLine("=====================================================");

GenericList<Client> clients = new GenericList<Client>();

GenericList<string> names = new GenericList<string>();

names.Add("fabio");