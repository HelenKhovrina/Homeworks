
Console.WriteLine ("Input first number");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input second number");
int y = Convert.ToInt32(Console.ReadLine());
int max = x;
int min = x;
if (y > max)
{
    max = y; min = x;
}
else
{
    max = x; min = y;
}
Console.Write ("max = ");
Console.WriteLine (max);
Console.Write ("min = ");
Console.WriteLine (min);