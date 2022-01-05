using System;
class Program {
    static void Main(string[] args) {
        int age = 27;
        double num = 20.25;
        double salary = 300.25;

        float height = 1.72f;

        long universeAge = 130000000000000;
        short habitablePlanets = 1;

        char letter = (char)65;
        string stacks = "- .NET \n- JavaScript";

        bool ofCorse = true;

        int month = DateTime.Now.Month;

        // cast to other dataType
        age = (int)num;


        System.Console.WriteLine("Write your name");
        System.Console.WriteLine("Hello " + Console.ReadLine() + ":)");


        Console.WriteLine($"My age {age}, my salary {salary - num}");
        Console.WriteLine($"My Height {height}");
        Console.WriteLine($"Age of universe {universeAge}, total habitable planets {habitablePlanets}");
        Console.WriteLine($"ASC 65 {letter}, ASC 66 {(char)(letter++)}");
        Console.WriteLine($"Some Stacks\n{stacks}");
        Console.WriteLine(age >= 18 ? "Can Enter" : "Sorry Maybe later");
        if (ofCorse) Console.WriteLine("I'm a very nice Programer !!!");
        Console.WriteLine(month);

        switch (month)
        {
            case 12:
                System.Console.WriteLine("Happy Birthday Fabio !!!");
                break;
            
            default:
                System.Console.WriteLine("Not Yet :(");
                break;
        }

        // Console.ReadLine();
    }
}