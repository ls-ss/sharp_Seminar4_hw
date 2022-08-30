// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите положительное число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(GetSumNum(num));

int GetSumNum(int n){
    int sum = 0;
    if(n > 9){
        while(n > 0){
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }
    else{
        return n;
    }
}