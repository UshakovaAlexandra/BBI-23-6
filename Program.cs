// задача 12
using System;

class Program
{
    static void Main()
    {
        //Ввод размера массива и его  элементов
        Console.Write("Введите количество элементов массива: ");
        int q = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[q];
        for (int n = 0; n < q; n++)
        {
            Console.Write("Введите " + n + "элемент массива: ");
            a[n] = Convert.ToInt32(Console.ReadLine());
        }
        int max = 0;
        int sum = 0;

        for (int i = 0; i < q; i++)
        {
            if (a[i] < 0)
            {
                for (int j = i; j < q; j++)
                {
                    sum += a[j];
                }
                break;
            }

            if (a[i] > a[max])
            {
                max = i;
            }
        }

        a[max] += sum;

        Console.WriteLine("Новый массив: ");
        foreach (int n in a)
        {
            Console.Write(n + " ");
        }

        Console.ReadLine();
        Console.ReadKey();
    }
}