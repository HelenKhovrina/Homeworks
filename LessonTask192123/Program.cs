//Задача 19

void Palindrom (int Num)
{
int ost5 = Num%10; 
int Num4 = Num/10;
int ost4 = Num4%10;
int Num3 = Num4/10;
int ost3 = Num3%10;
int Num2 = Num3/10;
int ost2 = Num2%10;
int Num1 = Num2/10;
int ost1 = Num1%10;
    if (ost1==ost5 && ost2==ost4)
        Console.WriteLine($"Число {Num} - палиндром");
    else
        Console.WriteLine($"Число {Num} - не палиндром");
}

Console.WriteLine("Введите пятизначное число");
int Num = Convert.ToInt32(Console.ReadLine());
Palindrom(Num);

//Задача 21

void Distanse (double x1,double y1, double z1, double x2, double y2, double z2)
{
     double kvadrokatet1 = Math.Pow (x2-x1,2) + Math.Pow (z2-z1,2);
     double kvadrokatet2 = Math.Pow (x2-x1,2) + Math.Pow (y2-y1,2);
     double result = Math.Round(Math.Sqrt (kvadrokatet1 + kvadrokatet2),2);
     Console.WriteLine(result);
}
Console.WriteLine("Значение по оси X1");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Значение по оси Y1");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Значение по оси Z1");
double Az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Значение по оси X2");
double Bx = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Значение по оси Y2");
double By = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Значение по оси Z2");
double Bz = Convert.ToDouble(Console.ReadLine());
Distanse(Ax,Ay,Az,Bx,By,Bz);

//Задача 23

void kybs (int Num)
 {
    int i = 1;
    int degree = 3;
      while ( i <= Num)
      {
        Console.WriteLine($"Куб числа {i} -> {Math.Pow(i,degree)}");
        i++;
      }
 }

Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());

kybs (x);