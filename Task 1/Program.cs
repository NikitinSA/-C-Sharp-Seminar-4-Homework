/*цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Clear();
Console.Write("Введите число A: ");
int number_A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень числа A: ");
int degree_A = Convert.ToInt32(Console.ReadLine());

double result = 0;

for (int count = 0; count <= degree_A; count++)
{
    result = Math.Pow(number_A, count);
}

Console.Write($"Число {number_A} в степени {degree_A} = {result}");