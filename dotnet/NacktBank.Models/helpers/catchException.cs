// catch (System.ArgumentException e)
// {                
//     System.Console.WriteLine(e.Message);
//     System.Console.WriteLine(e.StackTrace);
// }
// catch (InsufficientBalanceException e) {
//     System.Console.WriteLine($"{e.Message} value:{e.Value} balance:{e.Balance}");
//     System.Console.WriteLine(e.StackTrace);
// }
// catch (DepositInvalidException e) {
//     System.Console.WriteLine(e.Message);
//     System.Console.WriteLine(e.StackTrace);
// }

// ---------------------------------------------------------------------------------------

//   public static void Main(string[] args)
//         {
//             try
//             {
//                 LoadCurrentAccounts();
//             }
//             catch (IOException e)
//             {
//                 System.Console.WriteLine(e.Message);
//             }
//         }

//         private static void LoadCurrentAccounts()
//         {
//             using(ReaderFiles reader = new ReaderFiles("accounts.txt")){
//                 reader.ReadNextLine();
//                 reader.ReadNextLine();
//                 reader.ReadNextLine();
//             }
//         }
//         private static void TestExceptions()
//         {
//             try
//             {
//                 CurrentAccount fabio = new CurrentAccount(4242, 123456);
//                 CurrentAccount bruna = new CurrentAccount(4242, 1234567);

//                 fabio.Deposit(600);
//                 bruna.Deposit(600);

//                 // fabio.Withdraw(601);

//                 fabio.Transfer(9000, bruna);
//             }
//             catch (FinancialOperationException e)
//             {
//                 System.Console.WriteLine($"Unexpected Error: {e.Message}");
//                 System.Console.WriteLine(e.StackTrace);
//                 // System.Console.WriteLine("=============================");
//                 // System.Console.WriteLine(e.InnerException.StackTrace);
//             }
//             System.Console.WriteLine(CurrentAccount.TransactionFee);
//             System.Console.WriteLine(CurrentAccount.TotalAccounts);
//         }