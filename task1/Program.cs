internal class Program //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Enter three-digit number: ");
        string? number = Console.ReadLine();
        if (number!=null)
        Console.WriteLine(number[1]);        
    }
}