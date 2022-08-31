// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int NumElem = 8; // Переменная обозначающая кол-во элементов в массиве.
int [] array = new int[NumElem]; // Объявляем о создании массива на 'NumElem' элементов типа int

// Организуем ввод значений элементов массива
for (int i = 0; i < NumElem; i++){
    Console.Write("Введите число: ");
    array[i] = int.Parse(Console.ReadLine());
}

// Формируем вывод массива на экран
Console.Write("[");
for (int i = 0; i < NumElem; i++){
    Console.Write($"{array[i]}");
    if(i < NumElem -1) Console.Write(", ");
}
Console.WriteLine("]");