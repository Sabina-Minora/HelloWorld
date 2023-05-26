// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4


Console.Clear();
Console.WriteLine("Введите любое число: ");
double N = double.Parse(Console.ReadLine());
double B = 1;

while (B <= N)
{
    double sqr = Math.Pow(B,2);
    Console.WriteLine(sqr);
    B++;
}
