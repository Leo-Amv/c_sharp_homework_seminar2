internal class Program //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Enter the number: ");
        string? number = Console.ReadLine();
        if(number!=null)
        {
            string str = Convert.ToString(number);
            if (str.Length < 3)
        {
            Console.WriteLine("Third digit does not exist!");
        }
        else
        {
            Console.WriteLine(number[2]);
        }            
        }
        
        
    }
}