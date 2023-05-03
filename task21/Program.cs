// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int x1 = Prompt("Введите кординаты первой точки в 3D пространстве x1: ");
int y1 = Prompt("Введите кординаты первой точки в 3D пространстве y1: ");
int z1 = Prompt("Введите кординаты первой точки в 3D пространстве z1: ");

int x2 = Prompt("Введите кординаты второй точки в 3D пространстве x2: ");
int y2 = Prompt("Введите кординаты второй точки в 3D пространстве y2: ");
int z2 = Prompt("Введите кординаты второй точки в 3D пространстве z2: ");

double length = Math.Round(Math.Sqrt((FindSquareNumbers(x1, x2) + FindSquareNumbers(y1, y2) + FindSquareNumbers(z1, z2))), 2);
Console.WriteLine("Расстояние между точками " + length);


int FindSquareNumbers(int num1, int num2)
{
    return ((num2 - num1) * (num2 - num1));
}

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}