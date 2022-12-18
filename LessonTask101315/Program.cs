//Задача 10

//int DeleteNumber (int num) 
//{
//    int ed = num%10;
//    int des = num%100;
//    int k = des-ed;
//    return k/10;
//}

//int randomNumber = new Random().Next(100,999);
//Console.WriteLine (randomNumber);
//int result = DeleteNumber(randomNumber);
//Console.WriteLine(result);


//Задача 13

//int ThirdDigit(int number)
        //{
            //int result = -1;
            //if (number >= 100)
            //{
            //   while (number > 999)
            //    {
            //        number = number / 10;
            //    }
            //    result = number % 10;
            //}
            //return result; 
        //}

//Console.WriteLine("Input number");
//int number = Convert.ToInt32(Console.ReadLine());

//if (ThirdDigit(number) == -1)
//Console.WriteLine("третьей цифры нет");
//else
//Console.WriteLine($"Third digit is {ThirdDigit(number)}");

//Задача 15

void week (int randomNumber)
{
    if (randomNumber > 5)
        {
            Console.WriteLine ("да");
        }
    else
        {
            Console.WriteLine ("нет");
        }
}

Console.WriteLine("Введите номер дня недели");
int randomNumber = new Random().Next(1,7);
Console.WriteLine (randomNumber);
week(randomNumber);
