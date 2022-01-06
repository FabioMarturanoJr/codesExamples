using NacktBank.Models.CurrentAccounts;

static string getTimeByDay(TimeSpan time) {
    return time.Days + " days";
}

static string getTimeByYear(TimeSpan time) {
    return (time.Days / 365) + " years";
}

static string getTimeByMonth(TimeSpan time) {
    return (time.Days / 30) + " months";
}

static string getTimeByWeek(TimeSpan time) {
    return (time.Days / 7) + " weeks";
}

Client fabio = new Client();

DateTime now = DateTime.Now;
fabio.birthday = new DateTime(1994, 12, 9);

TimeSpan difference = now - fabio.birthday; 

System.Console.WriteLine(fabio.birthday);
System.Console.WriteLine(now);
System.Console.WriteLine($"Diff: {getTimeByDay(difference)}, {getTimeByWeek(difference)}, {getTimeByMonth(difference)}, {getTimeByYear(difference)}");
