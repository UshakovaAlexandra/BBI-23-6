// задача 10 
using System;
 
namespace Laba3_2_10
{
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
            //Определение первого положительного элемента массива и его индекса
            int min = 0;
            int mi = 0;            //индекс
            for (int i = 0; i < q; i++)
            {
                if (a[i] > 0)
                {
                    min = a[i];
                    mi = i;
                    break;
                }
            }
            for (int i = 0; i < q; i++)                   //начинаем перебор элементов массива
            {
                if (a[i] > 0)                       //отсеиваем отрицательные элементы
                {
                    if (a[i] < min)                 
                    {
                        min = a[i];                        //текущий минимальный элемент массива
                        mi = i;                             
                    }
                }
            }                               
            Console.WriteLine("минимальный положительный элемент {0} и индекс {1}", min, mi);
            //вывод массива
            if (min > 0)
            {
                q = q - 1;                     //уменьшаем размер нового массива
                for (int i = mi; i < q; i++)                   //элемент с минимальным индексом пропускаем
                {
                    a[i] = a[i + 1];
                }
            }
            for (int i = 0; i < q; i++)                   //выводим новый массив
            {
                Console.Write("Новый массив: ");
                Console.Write("{0:f1}", a[i]);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
// задача 11
using System;
 
namespace Laba3_2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод размера массива и его  элементов
            Console.Write("Введите количество элементов массива: ");
            int q = Convert.ToInt32(Console.ReadLine());
            int f = q + 1;
            int[] a = new int[f];
            for (int n = 0; n < q; n++)
            {
                Console.Write("Введите " + n + "элемент массива: ");
                a[n] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Введите значение элемента P: ");
            int p = Convert.ToInt32(Console.ReadLine());
            // Проходим массив "задом наперёд"
            int k = 0;
            int c = 0;
            for (int i = 0; i < q; i++)
            {
                if (a[i] > 0)
                {
                    c = a[i];
                    k = i;
                }
            }
            Console.Write("k = {0}", k);
            Console.WriteLine();
            if (c > 0)
            {
                for (int i = q; i > k; i--) a[i] = a[i - 1];
                a[k + 1] = p;
                for (int i = 0; i < f; i++)
                {
                    //Console.Write("{0:d} ", a[i]);
                    Console.Write(a[i] + "  ");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.Write("В массиве нет положительных чисел");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
// задача 12

// задача 14
using System;
 
class Program
{
    static void Main()
    {
        //Ввод размера массива и его  элементов
        Console.Write("Введите количество элементов массива: ");
        int q = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[q];
        for (int i = 0; i < q; i++)
        {
            Console.Write("Введите " + i + "элемент массива: ");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
 
        int max = -1;
        int c = -1;
        for (int i = 0; i < q; i++)
        {
            //if (a[i] > max && a[max] < i)
            //максимальный элемент
            if (a[i] > max)
            {
                max = a[i];
                c = i;
            }
        }
        //Console.Write("максимальный элемент {0} индекс {1}", max, c);
        //Console.WriteLine();
 
        //Определение первого отрицательного элемента массива и его индекса
        int t = 0;
        int ti = -1;            //индекс
        for (int i = 0; i < q; i++)
        {
            if (a[i] < 0)
            {
                t = a[i];
                ti = i;
                break;
            }
        }
            //Console.Write("первого отрицательного элемента {0} индекс {1}", t, ti);
            //Console.WriteLine();
 
        if (c != -1 && ti != -1)
        {
            int m = a[c];
            a[c] = a[ti];
            a[ti] = m;
            Console.WriteLine("Массив после замены:");
            foreach (int nu in a)
            {
                Console.Write(nu + " ");
            }
        }
        else
        {
            Console.WriteLine("Массив не может быть изменен");
        }
        Console.ReadKey();
    }
}
// задача 15
using System;
 
class Program
{
    static void Main()
    {
        //Ввод размера массива и его  элементов
        Console.Write("Введите количество элементов массива: ");
        int q = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[q];
        for (int i = 0; i < q; i++)
        {
            Console.Write("Введите " + i + "элемент массива: ");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
 
        int max = -1;
        int c = -1;
        for (int i = 0; i < q; i++)
        {
            //if (a[i] > max && a[max] < i)
            //максимальный элемент
            if (a[i] > max)
            {
                max = a[i];
                c = i;
            }
        }
        //Console.Write("максимальный элемент {0} индекс {1}", max, c);
        //Console.WriteLine();
 
        //Определение первого отрицательного элемента массива и его индекса
        int t = 0;
        int ti = -1;            //индекс
        for (int i = 0; i < q; i++)
        {
            if (a[i] < 0)
            {
                t = a[i];
                ti = i;
                break;
            }
        }
            //Console.Write("первого отрицательного элемента {0} индекс {1}", t, ti);
            //Console.WriteLine();
 
        if (c != -1 && ti != -1)
        {
            int m = a[c];
            a[c] = a[ti];
            a[ti] = m;
            Console.WriteLine("Массив после замены:");
            foreach (int nu in a)
            {
                Console.Write(nu + " ");
            }
        }
        else
        {
            Console.WriteLine("Массив не может быть изменен");
        }
        Console.ReadKey();
    }
}
// задача 17
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите массив: ");
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            a[i] = int.Parse(s);
        }
        int amax = 0;
        int imax = 0;
        int amin = 0;
        int imin = 0;
        for (int i = 0; i < n; i++)
        {
            if (a[i] > amax)
            {
                amax = a[i];
                imax = i;
            }
            if (a[i] < amin)
            {
                amin = a[i];
                imin = i;
            }
        }
        Console.WriteLine("максимальное значение: {0}", amax);
        Console.WriteLine("минимальное значение: {0}", amin);
        double sump = 0;
        double sumo = 0;
        int m = 0;
        int v = 0;
        double srp = 0;
        double sro = 0;
        if (imax < imin)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0)
                {
                    sump += a[i];
                    m++;
                }
            }
            Console.WriteLine($"sum: {sump}");
            srp = sump / m;
            Console.WriteLine($"среднее значение: {srp}");
        }
        else if (imax > imin)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0)
                {
                    sumo += a[i];
                    v++;
                }
            }
            sro = sumo / v;
            Console.WriteLine("sum: {0}", sumo);
            Console.WriteLine("среднее значение: {0}", sro);
        }
        //Console.WriteLine("среднее значение: {0}", sr);
        //Console.WriteLine(sr);
        Console.ReadKey();
    }
}