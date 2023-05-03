// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number = Prompt("Введите число: ");
int count = 1;
while (count <= number)
{
    Console.Write(FindCubeNumbers(count) + " ");
    count++;
}
Console.WriteLine();


int FindCubeNumbers(int num)
{
    int cubeNum = num * num * num;
    return cubeNum;
}

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}