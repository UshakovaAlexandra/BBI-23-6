// задача 15
using System;
 
class Program
{
    static void Main(string[] args)
    {
        int n = 0;
        do
        {
            Console.Write("Введите n: ");
            n = int.Parse(Console.ReadLine());
            if (n < 2) Console.WriteLine("Введите другое значение!");
        } while (n < 2);
        Console.WriteLine("Введите массив: ");
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            a[i] = int.Parse(s);
        }
        Console.Write("Введите m: ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите массив: ");
        int[] b = new int[m];
        for (int i = 0; i < m; i++)
        {
            string s1 = Console.ReadLine();
            b[i] = int.Parse(s1);
        }
        int[] c = new int[n + m];
        int k = 0;
        do
        {
            Console.Write("Введите k: ");
            k = int.Parse(Console.ReadLine());
            if (k > n) Console.WriteLine("Введите другое значение!");
        } while (k > n);
        for (int i = 0; i <= k; i++)
        {
            c[i] = a[i];
        }
        for (int i = 0; i < m; i++)
        {
            c[k + i + 1] = b[i];
        }
        for (int i = k + m + 1; i < m + n; i++)
        {
            c[i] = a[i - m];
        }
        Console.WriteLine("Получившийся массив: ");
        for (int i = 0; i < m + n; i++)
        {
            Console.WriteLine(c[i]);
        }
        Console.ReadKey();
    }
}