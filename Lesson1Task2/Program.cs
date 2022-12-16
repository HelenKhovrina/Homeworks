
Console.WriteLine ("Input first number");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input second number");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input third number");
int z = Convert.ToInt32(Console.ReadLine());
int max = x;
if (y > max)
{
    max = y;
}
if (z > max)
{
    max = z;
}
Console.Write ("max = ");
Console.WriteLine (max);
