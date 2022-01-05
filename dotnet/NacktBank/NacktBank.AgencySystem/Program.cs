using NacktBank.Models.CurrentAccounts;

CurrentAccount fabio = new CurrentAccount(123,55324);

fabio.Deposit(600);

System.Console.WriteLine(fabio.Account);
