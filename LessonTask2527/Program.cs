// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3?)
// 2, 4 -> 16

void degree (int A, int B)
 {   
    Console.WriteLine($"{A} в степени {B} -> {Math.Pow(A,B)}");
 }

Console.WriteLine("Введите значение числа");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение степени");
int B = Convert.ToInt32(Console.ReadLine());
degree (A, B);


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int SumNum(int Num)
  {    
     int sum = 0;
           while ( Num > 0)
         {             
                sum = sum + Num%10;
                Num = Num/10;
         }
             return sum;
  }

 Console.WriteLine ("Введите число");
 int Num = Convert.ToInt32(Console.ReadLine());
int result = SumNum(Num);
Console.WriteLine(result);
