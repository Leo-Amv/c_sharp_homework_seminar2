Console.Clear();
int a = new Random().Next(100, 1000);
Console.WriteLine($"number: {a}");
string str = a.ToString();
Console.WriteLine($"{str[0]}{str[2]}");