List<int> ages = new List<int>();

ages.Add(1);
ages.Add(2);
ages.Add(3);
ages.Add(4);
ages.Add(5);
ages.Add(6);

ages.Remove(5);

for (int i = 0; i < ages.Count(); i++)
{
    System.Console.WriteLine(ages[i]);
}