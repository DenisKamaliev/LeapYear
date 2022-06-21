using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите год: ");
        string input = Console.ReadLine();
        int Year = int.Parse(input);
        
       if(SharpFirstTask.LeapYearCheck.LeapYearCheckFunc(Year))
        Console.WriteLine(Year + " - Високосный год");
       else
        Console.WriteLine(Year + " - Не високосный год");
    }
}