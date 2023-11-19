// Задачи первого уровня
// Задача 1
using System;

class Program
{
    static void Main()
    {

        int n = 6;
        double[] a = new double[6]; // исходный массив
        Console.WriteLine("Введите элементы массива: ");
        for (int i = 0; i < n; i++)
        {
            a[i] = double.Parse(Console.ReadLine());
        }
        // находим сумму элементов исходного массива
        double sum = 0;
        foreach (double x in a)
        {
            sum += x;
        }
        Console.WriteLine("Сумма элементов массива =" + sum);
        // делим каждый элемент исходного массива на сумму
        for (int i = 0; i < 6; i++)
        {
            a[i] /= sum;
        }

        // выводим результат
        Console.WriteLine("Новый массив: ");
        foreach (double x in a)
        {
            Console.WriteLine(x);
        }
        Console.ReadKey();
    }
    }
// задача 2 
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] a = { 2, -5, 7, 10, -3, 4, -8, 12 }; // исходный массив

        // находим сумму и количество положительных элементов
        int sum = 0;
        int c = 0;
        foreach (int y in a)
        {
            if (y > 0)
            {
                sum += y;
                c++;
            }
        }

        // находим среднее арифметическое
        int x = sum / c;

        // заменяем положительные элементы средним арифметическим
        for (int i = 0; i < 8; i++)
        {
            if (a[i] > 0)
            {
                a[i] = x;
            }
        }

        // выводим результат
        foreach (int y in a)
        {
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
// задача 3    
using System;

class Program
{
    static void Main()
    {
        int[] a1 = { 1, 2, 3, 4 };
        int[] a2 = { 5, 6, 7, 8 };// исходные массивы

        int[] sum = new int[4]; // ввод массива суммы
        int[] diff= new int[4]; // ввод массива разности

        for (int i = 0; i < 4; i++)
        {
            sum[i] = a1[i] + a2[i]; 
            diff[i] = a1[i] - a2[i];
        }
        Console.WriteLine("Сумма массивов:"); // вывод значений суммы
        foreach (int n in sum)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine(); 

        Console.WriteLine("Разность массивов:"); // вывод значений разности
        foreach (int n in diff)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
    }
}
// задача 4
using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4, 5 }; // Исходный массив
        int sum = 0;

        // Вычисляем сумму всех элементов массива
        for (int i = 0; i < 5; i++)
        {
            sum += a[i];
        }
        int x = sum/5;
        // Вычитаем среднее значение из каждого элемента массива
        for (int i = 0; i < 5; i++)
        {
            a[i] -= x;
        }
        for (int i = 0; i < 5; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
    }
}
// задача 5
using System;

class Program
{
    static void Main()
    {
        int[] v1 = { 1, 2, 3, 4 };
        int[] v2 = { 5, 6, 7, 8 };

        int s = 0;

        for (int i = 0; i < 4; i++)
        {
            s += v1[i] * v2[i];
        }

        Console.WriteLine("Скалярное произведение: " + s);


        Console.WriteLine();
    }
}
// задача 6
using System;

class Program
{
    static void Main()
    {
        int[] v = { 1, 2, 3, 4, 5 };
        double l = 0;

        for (int i = 0; i < 5; i++)
        {
            l += Math.Pow(v[i], 2);
        }

        l = Math.Sqrt(l);

        Console.WriteLine("Длина вектора: " + l);

        Console.WriteLine();
    }
}
// задача 7
using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 5, 4, 9, 8, 2, 7 };
        int sum = 0;
        int c = 0;

        // Вычисляем среднее значение элементов массива
        for (int i = 0; i < 7; i++)
        {
            sum += a[i];
            c++;
        }

        double s = (double)sum / c;

        // Заменяем элементы, большие среднего значения, на 0
        for (int i = 0; i < 7; i++)
        {
            if (a[i] > s)
            {
                a[i] = 0;
            }
        }

        // Выводим массив после замены
        Console.WriteLine("Массив после замены:");
        for (int i = 0; i < 7; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}
// задача 8
using System;

class Program
{
    static void Main()
    {
        int[] a = { -1, 2, -3, 4, -5, 6 };
        int c= 0;

        foreach (var x in a)
        {
            if (x < 0)
            {
                c++;
            }
        }

        Console.WriteLine("Количество отрицательных элементов: " + c);
    }
}
// задача 9
using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int sum = 0;
        int c = 0;

        foreach (var x in a)
        {
            sum += x;
        }

        double e = (double)sum / 8;

        foreach (var x in a)
        {
            if (x > e)
            {
                c++;
            }
        }

        Console.WriteLine("Количество элементов, больших среднего значения: " + c);
    }
}
// задача 10
using System;

class Program
{
    static void Main()
    {
        // Создаем одномерный массив размера 10
        int []a = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Вводим два числа P и Q
        int P = 3;
        int Q = 8;
        int n = 0;
        for (int i = 0; i < 10; i++)
        {
            if (a[i] > P && a[i] < Q)
            {
                n++;
            }
        }

        Console.WriteLine($"Количество элементов между P и Q: {n}");
        Console.ReadKey();
    }
}
// задача 11
using System;

class Program
{
    static void Main()
    {
        double[] a = { -1, 2, -3, 4, -5, 6, -7, 8, -9, 10 };
        double[] b = new double[10]; // создаем новый массив с той же длиной
        int c = 0;
        foreach (double x in a)
        {
            if (x > 0) // проверяем, является ли элемент положительным
            {
                b[c] = x; // добавляем положительный элемент в новый массив
                          //Console.WriteLine(b[c]);
                c++;
            }
        }
        for (int i = 0; i < c; i++)
        {
            Console.Write("{0} ", b[i]);
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
// задача 12
using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, -2, 3, -4, 5, 6, -7, 8 };
        int x = 0; // переменная для хранения последнего отрицательного элемента
        int y = -1; // переменная для хранения индекса последнего отрицательного элемента

        for (int i = 0; i < 8; i++)
        {
            if (a[i] < 0)
            {
                x = a[i]; // обновляем значение последнего отрицательного элемента
                y = i; // обновляем индекс последнего отрицательного элемента
            }
        }

        // выводим результат
        Console.WriteLine("Значение последнего отрицательного элемента: " + x);
        Console.WriteLine("Номер последнего отрицательного элемента: " + y);

        }
    }
// задача 13
using System;

class Program
{
    static void Main()
    {
        int[] o= new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] e= new int[5];
        int[] A = new int[5];

        // Заполнение массивов четными и нечетными элементами
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                e[i / 2] = o[i];
            }
            else
            {
                A[i / 2] = o[i];
            }
        }

        // Вывод элементов массивов
        Console.WriteLine("Массив с четными индексами:");
        foreach (int x in e)
        {
            Console.WriteLine(x);
        }

        Console.WriteLine("Массив с нечетными индексами:");
        foreach (int x in A)
        {
            Console.WriteLine(x);
        }
    }
}
// задача 14
using System;

class Program
{
    static void Main()
    {
        int[] a = { 2, 3, 4, -1, 5, 6, -2, 7, 8, 9, 10 };
        int S = 0;

        for (int i = 0; i < 10; i++)
        {
            if (a[i] < 0)  // найдено первое отрицательное число
                break;

            S += a[i] * a[i];
        }

        Console.WriteLine("Сумма квадратов элементов до первого отрицательного: " + S);
    }
}
// задача 15
using System;

class Program
{
    static void Main()
    {
        double[] x = new double[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        double[] y = new double[10];

        for (int i = 0; i < 10; i++)
        {
            y[i] = 0.5 * Math.Log(x[i]);
        }

        Console.WriteLine("x\t\t  y");
        Console.WriteLine(" ");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(x[i] + "\t\t" + y[i]);
        }
    }
}
// Задания второго уровня
// задача 1
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
        int min = 0;
        int min1 = a[0];

        // Находим индекс и значение минимального элемента в массиве
        for (int i = 1; i < q; i++)
        {
            if (a[i] < min1)
            {
                min = i;
                min1 = a[i];
            }
        }

        // Увеличиваем минимальный элемент в два раза
        a[min] *= 2;
        // Выводим полученный массив на экран
        Console.WriteLine("Новый массив: ");
        foreach (int n in a)
        {
            Console.WriteLine(n);
        }
    }
}
// задача 2
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
        int max1 = a[0];

        // Находим индекс и значение максимального элемента в массиве
        for (int i = 1; i < q; i++)
        {
            if (a[i] > max1)
            {
                max = i;
                max1 = a[i];
            }
        }

        int sum = 0;

        // Считаем сумму элементов до максимального элемента
        for (int i = 0; i < max; i++)
        {
            sum += a[i];
        }

        Console.WriteLine("Сумма элементов до максимального элемента: " + sum);
    }
}
// задача 3
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

        int m = 0;
        int min = a[0];

        // Находим индекс и значение минимального элемента в массиве
        for (int i = 1; i < q; i++)
        {
            if (a[i] < min)
            {
                m = i;
                min = a[i];
            }
        }

        // Увеличиваем в два раза все элементы до минимального элемента
        for (int i = 0; i < m; i++)
        {
            a[i] *= 2;
        }

        Console.WriteLine("Модифицированный массив:");
        for (int i = 0; i < q; i++)
        {
            Console.Write(a[i] + " ");
        }
    }
}
// задача 4
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

        // Находим максимальный элемент массива и его индекс
        int max = a[0];
        int m1 = 0;
        for (int i = 1; i < q; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
                m1= i;
            }
        }

        // Вычисляем среднее значение элементов массива
        int sum = 0;
        for (int i = 0; i < q; i++)
        {
            sum += a[i];
        }
        int av = sum / q - 1;

        // Заменяем элементы после максимального на среднее значение
        for (int i = m1 + 1; i < q; i++)
        {
            a[i] = av;
        }

        // Выводим измененный массив на экран
        Console.WriteLine("Новый массив: ");
        for (int i = 0; i < q; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}
// задача 5
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
        int min = 0;

        // Находим индексы максимального и минимального элементов в массиве
        for (int i = 0; i < q; i++)
        {
            if (a[i] > a[max])
            {
                max = i;
            }

            if (a[i] < a[min])
            {
                min = i;
            }
        }

        // Создаем новый массив из отрицательных элементов между максимальным и минимальным
        int[] n = new int[Math.Abs(max - min) - 1];
        int y = 0;

        if (min < max)
        {
            for (int i = min + 1; i < max; i++)
            {
                if (a[i] < 0)
                {
                    n[y] = a[i];
                    y++;
                }
            }
        }
        else
        {
            for (int i = max + 1; i < min; i++)
            {
                if (a[i] < 0)
                {
                    n[y] = a[i];
                    y++;
                }
            }
        }

        // Выводим новый массив на консоль
        Console.WriteLine("Новый массив из отрицательных элементов:");
        for (int i = 0; i < n.Length; i++)
        {
            Console.Write(n[i] + " ");
        }
    }
}
// задача 6
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
Console.WriteLine("Введите значение P: ");
        int P = Convert.ToInt32(Console.ReadLine()); // заданное число P

        // Находим среднее значение элементов массива
        int sum = 0;
        for (int i = 0; i < q; i++)
        {
            sum += a[i];
        }
        double x = (double)sum / q;

        // Находим индекс элемента, наиболее близкого к среднему значению
        int t= 0;
        int c = Math.Abs(a[0] - (int)x);
        for (int i = 1; i < q; i++)
        {
            int d = Math.Abs(a[i] - (int)x);
            if (d < c)
            {
                c = d;
                t = i;
            }
        }

        // Создаем новый массив с увеличенной длиной и вставляем элемент P после найденного индекса
        int[] n = new int[8 + 1];
        Array.Copy(a, 0, n, 0, t + 1);
        n[t + 1] = P;
        Array.Copy(a, t + 1, n, t + 2, 8 - t - 1);

        // Выводим новый массив на консоль
        for (int i = 0; i < n.Length; i++)
        {
            Console.WriteLine("Новый массив: ");
            Console.Write(n[i] + " ");
        }
    }
}
// задача 7 
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
        // Находим максимальный элемент и его индекс
        int max = a[0];
        int m = 0;
        for (int i = 1; i < q; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
                m = i;
            }
        }

        // Увеличиваем элемент после максимального в 2 раза
        if (m < q - 1)
        {
            a[m + 1] *= 2;
        }

        // Выводим результат
        for (int i = 0; i < q; i++)
        {
            Console.WriteLine("Вывод увеличенного элемента: ");
            Console.WriteLine(a[i]);
        }
    }
}
// задача 8
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
        // Находим максимальный элемент
        int v = a[0];
        int I = 0;
        for (int i = 1; i < q; i++)
        {
            if (a[i] > v)
            {
                v = a[i];
                I = i;
            }
        }

        // Находим минимальный элемент после максимального
        int v1 = a[I + 1];
        int I1 = I + 1;
        for (int i = I + 2; i < q; i++)
        {
            if (a[i] < v1)
            {
                v1 = a[i];
                I1 = i;
            }
        }

        // Меняем местами максимальный и минимальный элементы
        int temp = a[I];
        a[I] = a[I1];
        a[I1] = temp;

        // Выводим измененный массив
        Console.WriteLine("Новый массив: ");
        foreach (int e in a)
        {
            Console.Write(e + " ");
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}
// задача 9
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
        int min = 0;
        int max = 0;

        // Находим индексы минимального и максимального элементов массива
        for (int i = 1; i < q; i++)
        {
            if (a[i] < a[min])
                min = i;

            if (a[i] > a[max])
                max = i;
        }

        // Находим среднее арифметическое значение элементов между минимальным и максимальным элементами
        int sum = 0;
        int c = 0;
        int n = 0;
        for (int i = 0; i < q; i++)
        {
            if (a[i] > a[min] && a[i] < a[max])
            {
                n++;
            }
        }

        for (int i = 0;i > a[min] && i < a[max]; i++)
        {
            sum += a[i];
            c++;
        }
        double z = (double)sum / c;
        Console.WriteLine("Среднее арифметическое значение элементов: " + z);
        Console.ReadKey();
    }
}
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
            //Определение индекса минимального положительного элемента
            int mi = 0;            //индекс
            int min = a[0];                  //пусть первый элемент минимальный
            for (int i = 0; i < q; i++)                   //начинаем перебор со второго элемента массива
            {
                if ((a[i] > 0) && (a[i] < min))
                {
                    min = a[i];                        //присваиваем переменной значение элемента массива
                    mi = i;
                }
                Console.WriteLine("минимальный положительный элемент {0} и индекс {1}", min, mi);
            }                               //присваиваем переменной значение индекса элемента
            q = q - 1;                               //уменьшаем размер нового массива
            for (int i = mi; i < q; i++)                                //элемент с минимальным индексом пропускаем
            {
                a[i] = a[i + 1];
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
            for (int i = f - 1; i >= 0; i--)
            {
                if (a[i] > 0)
                {
                    k = i;
                    break;
                }
            }
            for (int i = f - k; i >= k + 1; i--)
            {
                a[i + 1] = a[i];
            }
            a[k + 1] = p;
            for (int i = 0; i < f; i++)
            {
                Console.Write("{0:d} ", a[i]);
                Console.WriteLine();
            }
        Console.ReadKey();
        }
    }
}
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
                for (int j = i + 1; j < q; j++)
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
// задача 13
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

        int max = int.MinValue;
        int I = -1;

        for (int i = 0; i < q; i += 2)
        {
            if (a[i] > max)
            {
                max = a[i];
                I = i;
            }
        }

        if (I != -1)
        {
            a[I] = I;
        }

        Console.WriteLine("Массив после замены:");
        foreach (int n in a)
        {
            Console.Write(n + " ");
            Console.ReadKey();
        }
    }
}
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
for (int n = 0; n < q; n++)
{
    Console.Write("Введите " + n + "элемент массива: ");
    a[n] = Convert.ToInt32(Console.ReadLine());
}

        int max = -1;
        int n = -1;

        for (int i = 0; i < q; i++)
        {
            if (a[i] > max && a[max]< i)
            {
                max = i;
            }

            if (a[i] < 0 && n == -1)
            {
                n = i;
            }
        }

        if (max != -1 && n != -1)
        {
            int t = a[max];
            a[max] = a[n];
            a[n] = t;
        }

        Console.WriteLine("Массив после замены:");
        foreach (int nu in a)
        {
            Console.Write(nu + " ");
        }
    }
}
// задача 15
using System;

class Program
{
   static void Main(string[] args)
  {
     Console.WriteLine("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите массив: ");
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            a[i] = int.Parse(s);
        }
        Console.WriteLine("Введите m: ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите массив: ");
        int[] b = new int[m];
        for (int i = 0; i < m; i++)
        {
            string s1 = Console.ReadLine();
            b[i] = int.Parse(s1);
        }
        int[] c = new int[n + m];
        Console.WriteLine("Введите k: ");
        int k = int.Parse(Console.ReadLine());
        for (int i = 0; i <= k; i++)
        {
            c[i] = a[i];
        }
        for (int i = 0;i < m; i++)
        {
            c[k + i + 1] = b[i];
        }
        for (int i = k + m + 1; i < m + n; i++)
        {
           c[i] = a[i - m];
        }
        Console.WriteLine("Получившийся массив: ");
        for (int i = 0; i < m+n; i++)
        {
            Console.WriteLine(c[i]);
      }
    }
}
// задача 16
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите массив: ");
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            a[i] = int.Parse(s);
        }
        double sum = 0;
        int m = 0;
        for (int i = 0; i < n; i++)
        {
            sum = sum + a[i];
            m += 1;
        }
        double sr = sum / m;
        Console.WriteLine("среднее значение: ");
        Console.WriteLine(sr);
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            if (a[i] < sr)
            {
                count++;
            }
        }
        Console.WriteLine(count);
        int j = 0;
        int[] b = new int[count];
        for (int i = 0;i < n;i++)
        {
            if (a[i] < sr)
            {
                b[j] = i;
                j++;
            }
        }
        Console.WriteLine("Получившийся массив: ");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(b[i]);
        }
    }
}
// задача 17
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите массив: ");
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            a[i] = int.Parse(s);
        }
        int amax = a[0];
        int imax = 0;
        int amin = a[0];
        int imin = 0;
        for (int i = 0;i < n;i++)
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
        double sum = 0;
        int m = 0;
        double sr = 0;
        for (int i = 0; i < n; i++)
        {
            if (imax < imin)
            {
                if (a[i]>0)
                {
                    sum += a[i];
                    m += 1;
                }
                 sr = sum / m;
            }
            else if (imax > imin)
            {
                if (a[i]<0)
                {
                    sum += a[i];
                    m += 1;
                }
                sr = sum / m;
            }
        }
        Console.WriteLine("среднее значение: ");
        Console.WriteLine(sr);
    }
}
// задача 18
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите массив: ");
        int[] a = new int[n];


        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            a[i] = int.Parse(s);
        }
        int amax1 = a[0];
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0 && a[i] > amax1)
            {
                amax1 = a[i];
            }
        }
        Console.WriteLine("Максимальный элемент массива с чётными индексами: ");
        Console.WriteLine(amax1);
        int amax2 = a[0];
        for (int i = 0; i < n; i++)
        {
            if (i % 2 != 0 && a[i] > amax2)
            {
                amax2 = a[i];
            }
        }
        Console.WriteLine("Максимальный элемент массива с нечётными индексами: ");
        Console.WriteLine(amax2);
            if (amax1 > amax2)
            {
                for (int i=0; i<n/2; i++ )
                {
                    a[i] = 0;
                }
            }
            if (amax1 < amax2)
            {
                for (int i=n/2; i <n; i++ )
                {
                    a[i] = 0;
                }
            }
        Console.WriteLine("Получившийся массив: ");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}
// задача 19
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите массив: ");
        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            a[i] = int.Parse(s);
        }
        int amax = a[0];
        int imax = 0;
        for (int i = 1; i < n; i++)
        {
            if (a[i] > amax)
            {
                amax = a[i];
                imax = i;   
            }
        }
        Console.WriteLine("Максимальный элемент массива: ");
        Console.WriteLine(amax);
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += a[i];
        }
        Console.WriteLine("Сумма элементов массива: ");
        Console.WriteLine(sum);
            if (amax > sum)
            {
            a[imax] = 0;
            }
            if (amax < sum)
            {
                a[imax] *= 2;
            }
        Console.WriteLine("Получившийся массив: ");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}
// задача 20
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите массив: ");
        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            a[i] = int.Parse(s);
        }
        int amin = a[0];
        int imin = 0;
        for (int i = 0;i < n; i++)
        {
            if (a[i] < amin)
            {
                amin = a[i];
                imin = i;
            }
        }
        int k = -1;
        for (int i = 0; i < n; i++)
        {
            if (a[i] < 0)
            {
                k = i;
                break;
            }
        }
        if (k>imin)
        {
            int sum = 0;
            for (int i = 0; i < n ; i += 2)
            {
                sum += a[i];
            }
            Console.WriteLine("Сумма элементов с четными индексами: " + sum);
        }
        if (k<imin)
        {
            int sum = 0;
            for (int i = 1; i < n; i += 2)
            {
                sum += a[i];
            }
            Console.WriteLine("Сумма элементов с нечетными индексами: " + sum);
        }
    }
}
// 3 уровень
// 5 задание 
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
 
        // Цикл для обхода элементов с четными индексами
        for (int i = 0; i < q; i += 2)
        {
            // Вложенный цикл для сравнения и упорядочивания элементов
            for (int j = i + 2; j < q; j += 2)
            {
                if (a[i] > a[j])
                {
                    // Обмен элементов
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
 
        // Вывод отсортированного массива
        Console.WriteLine("Новый массив: ");
        foreach (int u in a)
        {
            Console.Write(u + " ");
        }
        Console.ReadKey();
    }
}
// 3 задание
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
        //Находим максимальный элемент
        int max = a[0];
        int m = 0;
        for (int i = 1; i < q; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
                m = i;
            }
        }
        //Меняем соседние элементы местами
        for (int i = 0; i < m - 1; i++)
        {
            int t = a[i];
            a[i] = a[i + 1];
            a[i + 1] = t;
            i++;
        }
                          
        // Выводим полученный массив на экран
        Console.WriteLine("Новый массив: ");
        foreach (int e in a)
        {
            Console.Write(e + " ");
        }
        Console.ReadKey();
    }
 
}
// 10 задание
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
        int s = q;
        int[] A = new int[s * 2];
 
        // Переносим элементы из исходного массива в новый массив, дублируя их
        for (int i = 0; i < s; i++)
        {
            A[i * 2] = a[i];
            A[i * 2 + 1] = a[i];
        }
 
        // Выводим полученный массив на экран
        Console.WriteLine("Новый массив: ");
        foreach (int e in A)
        {
            Console.Write(e + " ");
        }
        Console.ReadKey();
    }
 
}
// 8 задание
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
 
        // Отображаем исходный массив
        Console.WriteLine("Исходный массив:");
        foreach (var num in a)
        {
            Console.Write(num + " ");
            Console.WriteLine();
        }
 
        // Сортируем отрицательные элементы по убыванию
        for (int i = 0; i < q - 1; i++)
        {
            if (a[i] < 0)
            {
                for (int j = i + 1; j < q; j++)
                {
                    if (a[j] < 0 && a[j] > a[i])
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
        }
 
        // Отображаем упорядоченный массив
        Console.WriteLine("Упорядоченный массив:");
        foreach (var num in a)
        {
            Console.Write(num + " ");
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}