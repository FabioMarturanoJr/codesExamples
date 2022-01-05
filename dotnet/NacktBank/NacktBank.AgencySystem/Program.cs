using NacktBank.Models.CurrentAccounts;

CurrentAccount fabio = new CurrentAccount(4242,321654);

fabio.Deposit(800);

System.Console.WriteLine(fabio.Balance);
