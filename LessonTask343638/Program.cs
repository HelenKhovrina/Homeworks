// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];    
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return myArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Полученный массив ->:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ParityCheck (int[] array)
{
    int sumParity = 0;    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]%2==0)
            array[i] = 1;
        else
            array[i] = 0;
            sumParity += array[i];
    }
    Console.WriteLine($"Количество четных чисел {sumParity}");
}
Console.WriteLine("Введите размер массива:");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное 3х-значное число массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное 3х-значное число массива:"); 
int max = Convert.ToInt32(Console.ReadLine());                                  

int[] newArray = CreateRandomArray(lenght,min,max);

ShowArray(newArray);
ParityCheck(newArray);


// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return myArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Полученный массив ->:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void SumOddCheck (int[] array)
{
    int sum = 0;    
    for(int i = 0; i < array.Length; i++)
    {
        if(i%2>0)
            sum = sum +array[i];
        else
            array[i] = 0;        
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях {sum}");
}
Console.WriteLine("Введите размер массива:");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива:"); 
int max = Convert.ToInt32(Console.ReadLine());                                  

int[] newArray = CreateRandomArray(lenght,min,max);

ShowArray(newArray);
SumOddCheck(newArray);

// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return myArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Полученный массив ->:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FindDiffMAxMin (int[] array)
{
    int Diff = 0;
    int max = array[0];
    int min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        max = array[i];
        else
        if (array[i] < min)
        min = array[i];
        Diff = max - min;
    }
    Console.WriteLine($"Разность между max и min = {Diff}");
}
Console.WriteLine("Введите размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива:"); 
int max = Convert.ToInt32(Console.ReadLine());                                  

int[] newArray = CreateRandomArray(length,min,max);

ShowArray(newArray);
FindDiffMAxMin(newArray);


//Задача 38. Вариант-2

void ShowArray(double[] array)
{
    Console.WriteLine("Полученный массив ->:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FindDiffMAxMin (double[] array)
{
    double Diff = 0;
    double max = array[0];
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        max = array[i];
        else
        if (array[i] < min)
        min = array[i];
        Diff = Math.Round(max - min,2);
    }
    Console.WriteLine($"Разность между max и min = {Diff}");
}

double[] array1 = new double[] { 1.45, 5.67, 9.12, 6.34, 5.83, 9.48 };

                            
ShowArray(array1);
FindDiffMAxMin(array1);

