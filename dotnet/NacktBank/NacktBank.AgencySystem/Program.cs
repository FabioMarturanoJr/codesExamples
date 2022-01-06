using Humanizer;
using NacktBank.Models.CurrentAccounts;

static string getTimeByDay(TimeSpan time) {
    return TimeSpanHumanizeExtensions.Humanize(time);
}
Client fabio = new Client();

DateTime now = DateTime.Now;
fabio.AccountExpiration = new DateTime(2023, 1, 9);

TimeSpan difference =fabio.AccountExpiration - now; 

System.Console.WriteLine(fabio.AccountExpiration);
System.Console.WriteLine(now);
System.Console.WriteLine($"Exp: {getTimeByDay(difference)} left");
