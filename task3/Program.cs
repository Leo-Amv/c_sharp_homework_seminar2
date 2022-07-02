internal class Program //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Enter one digit from 1 to 7: "); // от 1 до 7 включительно
        int number = Convert.ToInt32(Console.ReadLine());
        if (number == 6 || number == 7)
        {
            Console.WriteLine("Today is a weekend day!");
        }
        else
        {
            Console.WriteLine("Today is a working day!");
        }
    }
}