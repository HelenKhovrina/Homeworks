Console.WriteLine ("Input number");
int x = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i < x+1)
{
    if ( i % 2 == 0)
        Console.WriteLine ($"{i}");
        i= i+1; 
}