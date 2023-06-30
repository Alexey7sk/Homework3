Console.WriteLine("Введите пятизначное число, чтобы узнать является ли оно палиндромом: ");
string number = Console.ReadLine();
int length = number.Length;

if (length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Данное число является палиндромом");
    }
    else
    {
        Console.WriteLine($"{number} - Данное число не является палиндромом");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - Введенное число не является пятизначным");
}
