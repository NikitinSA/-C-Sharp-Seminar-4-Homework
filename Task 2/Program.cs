/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введите число: ");
int user_number = Convert.ToInt32(Console.ReadLine());

int SumOfDigitInANumber(int user_number)
{
    int result = 0;
    while (user_number > 0)
    {
        result = result + user_number % 10;
        user_number = user_number / 10;
    }
    return result;
}

int result = SumOfDigitInANumber(user_number);
Console.Write($"Сумма цифр в числе {user_number} = {result}");