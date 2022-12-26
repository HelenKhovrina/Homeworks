// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите размер массива:");
int lenght = int.Parse(Console.ReadLine());
int[] myArray = new int [lenght];

void ShowArray(int[] array)
{
        for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:");
        myArray[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();
}

void SumPositive (int[] array)
{
    int sum = 0;    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]>0)
            array[i] = 1;
        else
            array[i] = 0;
            sum = sum + array[i];
    }
    Console.WriteLine($"Количество положительных чисел {sum}");
}

ShowArray(myArray);
SumPositive(myArray);  

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 

void CoordinatesPoint (double k1,double b1, double k2, double b2)
{
     double x = Math.Round(((b2-b1)/(k1-k2)),2);
     double y = Math.Round((k1*x+b1),2);
     Console.WriteLine ($"Координаты точки пересечения - ({x};{y})");
}
Console.WriteLine("Значение b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Значение k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Значение b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Значение k2");
double k2 = Convert.ToDouble(Console.ReadLine());

CoordinatesPoint(k1, b1, k2, b2);


