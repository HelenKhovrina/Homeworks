// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] Create2DRandomArray ( int rows, int columns, int minValue, int maxValue)  
// {                                                                                
//     int[,] newArray = new int[rows,columns];
                                      
//     for(int i = 0; i < rows; i++)
//     {
        
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = new Random().Next(minValue, maxValue+1); 
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }


// void ProductMatrix (int[,] array1, int[,] array2)
// {
//     int P1=array1[0,0]*array2[0,0]+array1[0,1]*array2[1,0];
//     int P2=array1[0,0]*array2[0,1]+array1[0,1]*array2[1,1];
//     int P3=array1[1,0]*array2[0,0]+array1[1,1]*array2[1,0];
//     int P4=array1[1,0]*array2[0,1]+array1[1,1]*array2[1,1];
//     Console.Write(P1 + " ");
//     Console.WriteLine(P2 + " ");
//     Console.Write(P3 + " ");
//     Console.Write(P4 + " ");
// }

// Console.Write("Введите минимальное значение элемента 1ой матрицы ");
// int min1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение элемента 1ой матрицы ");
// int max1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение элемента 2ой матрицы ");
// int min2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение элемента 2ой матрицы ");
// int max2 = Convert.ToInt32(Console.ReadLine());
// int rows = 2;
// int columns = 2; 
// int[,] myArray1 = Create2DRandomArray(rows,columns,min1,max1);
// int[,] myArray2 = Create2DRandomArray(rows,columns,min2,max2);
// Show2DArray(myArray1);
// Console.WriteLine();
// Show2DArray(myArray2);
// Console.WriteLine();
// ProductMatrix(myArray1,myArray2);





// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void Spiral(int[,] array)
// {
//     int Num = 5;
//     int i = 0;
//     int j = 0;

//     while (Num >= 5 && Num <= 20)
//     {
//         array[i, j] = Num;
//         Num++;
//         if (i <= j + 1 && i + j < array.GetLength(1) - 1)
//             j++;
//         else if (i < j && i + j >= array.GetLength(0) - 1)
//             i++;
//         else if (i >= j && i + j > array.GetLength(1) - 1)
//             j--;
//         else
//             i--;
//     }
// }

// int[,] Array = new int[4, 4];

// Spiral(Array);
// Show2DArray(Array);



// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] Create2DRandomArray ( int rows, int columns, int minValue, int maxValue)  
// {                                                                                
//     int[,] newArray = new int[rows,columns];
                                      
//     for(int i = 0; i < rows; i++)
//     {
        
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i,j]=new Random().Next(minValue, maxValue+1); 
//         }
//     }
//     return newArray;
// }
// void Show2DArray (int[,]array)
// {
//     for (int i=0; i< array.GetLength(0);i++)
//     {
//         for (int j=0; j<array.GetLength(1);j++)
//         {
//         Console.Write(array[i,j]+ " "); 
//         }
//     Console.WriteLine();
//     }
// }

// void Sorting(int[,] array)
// {
//     for (int i=0; i <array.GetLength(0); i++)
//     {
//         for (int j=0; j <array.GetLength(1); j++)
//         {
//         for (int A = 0; A<array.GetLength(1)-1; A++)
//             {
//                 if (array[i,A] < array[i, A+1])
//                 {
//                 int temp = array[i, A+1];
//                 array[i, A+1] = array[i, A];
//                 array[i, A] =temp;
//                 }
//             }
//         }
//     }
// }

// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение массива ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение массива ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m,n,min,max);
// Show2DArray (myArray);
// Sorting (myArray);
// Console.WriteLine();
// Show2DArray (myArray);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// int[,] Create2DRandomArray ( int rows, int columns, int minValue, int maxValue)  
// {                                                                                
//     int[,] newArray = new int[rows,columns];                                     
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = new Random().Next(minValue, maxValue+1); 
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }

// void MinimumSumRow(int[,] array)
// {
  
//     int SumMinRow = 0;
//     int IndexminRow = 0;
//     int SumRow = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         SumMinRow += array[0, j];
//     }
//     for (int i = 0; i <array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         SumRow += array[i, j];
//         if (SumRow < SumMinRow)
//         {
//             SumMinRow = SumRow;
//             IndexminRow = i;
//             Console.WriteLine($"Номер строки с минимальной суммой элементов - {i}");
            
//         }
    
//     }
//     Console.WriteLine(SumMinRow);
    
// }

// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m,n,min,max);
// Show2DArray(myArray);
// MinimumSumRow(myArray);



// Задача 60. ..Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] Create3DRandomArray ( int rows, int columns, int diagonals)  
// {                                                                                
//     int[,,] newArray = new int[rows,columns,diagonals];                                     
//     for(int x = 0; x < rows; x++)
//     {
//         for(int y = 0; y < columns; y++)
//         {
//             for(int z = 0; z < diagonals; z++)
        
//             {
//                 newArray[x,y,z] = new Random().Next(10, 99); 
//             }
//         }
//     }
//     return newArray;
// }

// void Show3DArray(int[,,] array)
// {
//     for(int x = 0; x < array.GetLength(0); x++)
//     {
//         for(int y = 0; y < array.GetLength(1); y++)
//         {
//             for(int z = 0; z < array.GetLength(0); z++)
//             Console.Write(array[x,y,z]+" ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Введите первую координату ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите вторую координату ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третью координату ");
// int z = Convert.ToInt32(Console.ReadLine());

// int[,,] myArray = Create3DRandomArray(x, y, z);
// Show3DArray(myArray);


