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
        int[] a = new int[] { 5, 1, 9, 3, 7, 2, 8, 4, 6 };

        int min = 0;
        int min1 = a[0];

        // Находим индекс и значение минимального элемента в массиве
        for (int i = 1; i < 9; i++)
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
        int[] a = new int[] { 5, 1, 9, 3, 7, 2, 8, 4, 6 };

        int max = 0;
        int max1 = a[0];

        // Находим индекс и значение максимального элемента в массиве
        for (int i = 1; i < 9; i++)
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
        int[] a = new int[] { 5, 1, 9, 3, 7, 2, 8, 4, 6 };

        int m = 0;
        int min = a[0];

        // Находим индекс и значение минимального элемента в массиве
        for (int i = 1; i < 9; i++)
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
        for (int i = 0; i < 9; i++)
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
        // Исходный одномерный массив
        int[] a = { 1, 5, 3, 9, 2, 7 };

        // Находим максимальный элемент массива и его индекс
        int max = a[0];
        int m1 = 0;
        for (int i = 1; i < 6; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
                m1= i;
            }
        }

        // Вычисляем среднее значение элементов массива
        int sum = 0;
        for (int i = 0; i < 6; i++)
        {
            sum += a[i];
        }
        int av = sum / 5;

        // Заменяем элементы после максимального на среднее значение
        for (int i = m1 + 1; i < 6; i++)
        {
            a[i] = av;
        }

        // Выводим измененный массив на экран
        for (int i = 0; i < 6; i++)
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
        int[] a= { 7, -5, -2, 9, -4, 6, -8, 3 };
        int max = 0;
        int min = 0;

        // Находим индексы максимального и минимального элементов в массиве
        for (int i = 0; i < 8; i++)
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
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // заданный массив
        int P = 10; // заданное число P

        // Находим среднее значение элементов массива
        int sum = 0;
        for (int i = 0; i < 9; i++)
        {
            sum += a[i];
        }
        double x = (double)sum / 9;

        // Находим индекс элемента, наиболее близкого к среднему значению
        int t= 0;
        int c = Math.Abs(a[0] - (int)x);
        for (int i = 1; i < 9; i++)
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
        int[] a = { 5, 10, 15, 20, 25 };

        // Находим максимальный элемент и его индекс
        int max = a[0];
        int m = 0;
        for (int i = 1; i < 5; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
                m = i;
            }
        }

        // Увеличиваем элемент после максимального в 2 раза
        if (m < 5 - 1)
        {
            a[m + 1] *= 2;
        }

        // Выводим результат
        for (int i = 0; i < 5; i++)
        {
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
        // Исходный массив
        int[] a= { 5, 1, 10, 3, 7, 8 };

        // Находим максимальный элемент
        int v = a[0];
        int I = 0;
        for (int i = 1; i < 6; i++)
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
        for (int i = I + 2; i < 6; i++)
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
    static void Main(string[] args)
    {
        int[] a = { 10, 5, 7, 15, 3, 8, 12 };

        int min = 0;
        int max = 0;

        // Находим индексы минимального и максимального элементов массива
        for (int i = 1; i < 7; i++)
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
        for (int i = 0; i < 10; i++)
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

class Program
{
    static void Main()
    {
        int[] array = { 1, -2, 3, -4, 5 };
        int P = 10;
        
        // Вызываем функцию и передаем в нее массив и элемент P
        int[] result = InsertAfterLastPositive(array, P);
        
        // Выводим результат
        Console.WriteLine(string.Join(", ", result));
    }

    static int[] InsertAfterLastPositive(int[] arr, int P)
    {
        // Ищем последний положительный элемент
        int lastPositiveIndex = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                lastPositiveIndex = i;
            }
        }

        // Если в массиве нет положительных элементов,
        // добавляем P в конец массива
        if (lastPositiveIndex == -1)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = P;
        }
        else
        {
            Array.Resize(ref arr, arr.Length + 1);

            // Сдвигаем элементы после lastPositiveIndex
            for (int i = arr.Length - 1; i > lastPositiveIndex + 1; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[lastPositiveIndex + 1] = P;
        }

        return arr;
    }
}
// задача 11

// задача 12
using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, -5, 4, 5, -6, 7, 8, 9 };
        int max = 0;
        int sum = 0;

        for (int i = 0; i < 10; i++)
        {
            if (a[i] < 0)
            {
                for (int j = i + 1; j < 10; j++)
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

        foreach (int n in a)
        {
            Console.Write(n + " ");
        }

        Console.ReadLine();
        Console.ReadKey();
\    }
}
// задача 13
using System;

class Program
{
    static void Main()
    {
        int[] a= { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int max = int.MinValue;
        int I = -1;

        for (int i = 0; i < 10; i += 2)
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

// задача 15

// задача 16

// задача 17

// задача 18

// задача 19

// задача 20