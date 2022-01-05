using NacktBank.Models.CurrentAccounts;

CurrentAccount fabio = new CurrentAccount(4242,321654);

fabio.Deposit(800);
fabio.Withdraw(654);

System.Console.WriteLine(fabio.Balance);
