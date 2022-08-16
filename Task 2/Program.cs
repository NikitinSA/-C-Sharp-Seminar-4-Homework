/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введите число: ");
int user_number = Convert.ToInt32(Console.ReadLine());

int SumOfDigitInANumber(int user_number)
{
    int result =+ rem; 
    while (user_number > 0)
    {
        Console.WriteLine(user_number);
        int rem = user_number % 10;
        Console.WriteLine(rem);
        int res1 = rem;
        int sub = user_number - rem;
        Console.WriteLine(sub);
        Console.WriteLine(result);
        if (sub % 10 == 0)
        {
            user_number = user_number / 10;
        }
    }
    return result;
}

int result = SumOfDigitInANumber(user_number);
Console.Write($"Сумма цифр в числе {user_number} = {result}");



