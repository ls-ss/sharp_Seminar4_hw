// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите степень числа B: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"Значение А в степени B равно: {APowB(a, b)}.");

int APowB(int A, int B){
    return (int)(Math.Pow(A, B));
}