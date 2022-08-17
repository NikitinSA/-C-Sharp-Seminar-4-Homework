/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.*/

Console.Write("Введите число из которого должен состоять массив: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] a = new int[N];

void Massive(int[] array)
{
    for (int i = 0; i < a.Length; i++)
    {
        Random rnd = new Random();
        int value = rnd.Next(100);
        a[i] = value;
        Console.Write($"{a[i]} ");
    }
}

Massive(a);