Console.Write("Введите число A: ");
int number_A= Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите степень числа A: ");
int degree_A= Convert.ToInt32(Console.ReadLine());

double result = Math.Pow(number_A, degree_A);

Console.Write($"Число {number_A} в степени {degree_A} = {result}");