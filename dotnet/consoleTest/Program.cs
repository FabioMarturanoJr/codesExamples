using System;
class Program {
    static void Main(string[] args) {
        int age = 27;
        double num = 20.25;
        double salary = 300.25;

        float height = 1.72f;

        long universeAge = 130000000000000;
        short habitablePlanets = 1;

        // cast to other dataType
        age = (int)num;

        Console.WriteLine($"My age {age}, my salary {salary + num}");
        // Console.ReadLine();
    }
}