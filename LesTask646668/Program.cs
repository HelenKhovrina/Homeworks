// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void PrintNUm ( int num)
// {
//     if(num>=1)
//     {
//     Console.Write(num+" ");
//     PrintNUm(num-1);    
//     }
// }

// PrintNUm(15);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int FindSum ( int a, int b)
// {
            
//         if (a<b && a!=b)
//         {
//             return a + FindSum(a+1,b);
            
//         }
//         if (a>b && a!=b)
//         {
//             return b + FindSum(a,b+1);
//         }
           
//     else return b;    
// }
// int result = FindSum(2,7);
// Console.WriteLine(result);


 


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return  Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }
// int result = Akkerman(2,3);
// Console.WriteLine(result);








