// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = Prompt("Введите пятизначное число: ");

if (ValidateNumber(number))
{
    if (number == ReverseNumber(number))
    {
        Console.WriteLine("Число является палиндромом");
    }
    else Console.WriteLine("Число не является палиндромом");
}
else Console.WriteLine("Число не пятизначное, будьте внимательнее");


int ReverseNumber(int num)
{
    int result = 0;
    while (num > 0)
    {
        result = result * 10 + num % 10;
        num /= 10;
    }
    return result;
}

bool ValidateNumber(int num)
{
    num = Math.Abs(num);
    if (num > 9999 && num < 100000)
    {
        return true;
    }
    else return false;
}

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}