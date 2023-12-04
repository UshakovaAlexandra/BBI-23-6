// 4 лаба
// первый уровень
// 1
using System;
class Program
{
    static void Main()
    {
        int N, n, M, m;
        Console.WriteLine("Введите число строк и столбцов матрицы");
        Console.Write("Число строк N="); // Введите N
        N = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов M="); // Введите M
        M = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random rnd = new Random(); // Для случайных чисел
        int[,] a = new int[N, M]; // Матрица a[N,M] типа int 
        for (n = 0; n < N; n++)
        {
            for (m = 0; m < M; m++)
            {
                int Mm = rnd.Next(0, 100); // Генерация случайного числа 
                a[n, m] = Mm;
            }
        }
        Console.WriteLine("Начальная матрица:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write("{0} ", a[i,j]);
            }
            Console.WriteLine();
        }
 
        int s = 0;
 
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                s += a[i, j];
            }
        }
 
        Console.WriteLine("Сумма элементов матрицы А: " + s);
        Console.ReadKey();
    }
}
//  5
using System;
class Program
{
    static void Main()
    {
        int N, n, M, m, P;
        Console.WriteLine("Введите число строк и столбцов матрицы");
        Console.Write("Число строк N="); // Введите N
        N = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов M="); // Введите M
        M = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random rnd = new Random(); // Для случайных чисел
        int[,] a = new int[N, M]; // Матрица a[N,M] типа int 
        for (n = 0; n < N; n++)
        {
            for (m = 0; m < M; m++)
            {
                int Mm = rnd.Next(-100, 100); // Генерация случайного числа 
                a[n, m] = Mm;
            }
        }
        do
        {
            Console.WriteLine("Задайте номер столбца для поиска отрицательного элемента: ");// ввод заданного столбца
         P = int.Parse(Console.ReadLine());
            if (P > M) Console.WriteLine("введите другое значение");
        } while (P > M);
 
        Console.WriteLine("Начальная матрица:");// вывод начальной матрицы
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write("{0} ", a[i, j]);
            }
            Console.WriteLine();
        }
 // номер заданного столбца (отсчет с нуля)
        int x = 0;
        int r= -1;
 
        for (int i = 0; i < N; i++)
        {
            if (a[i,P] < 0)
            {
                x = a[i,P];
                r = i;
                break;
            }
        }
 
        Console.WriteLine("Значение первого отрицательного элемента в столбце " + P + ": " + x);
        Console.WriteLine("Номер строки, в которой находится первый отрицательный элемент: " + r);
        Console.ReadKey();
    }
}
// 9
using System;
class Program
{
    static void Main()
    {
        int N, n, M, m, P;
        Console.WriteLine("Введите число строк и столбцов матрицы");
        Console.Write("Число строк N="); // Введите N
        N = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов M="); // Введите M
        M = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random rnd = new Random(); // Для случайных чисел
        int[,] a = new int[N, M]; // Матрица a[N,M] типа int 
        for (n = 0; n < N; n++)
        {
            for (m = 0; m < M; m++)
            {
                int Mm = rnd.Next(-100, 100); // Генерация случайного числа 
                a[n, m] = Mm;
            }
        }
 
        Console.WriteLine("Начальная матрица: ");// вывод начальной матрицы
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write("{0} ", a[i, j]);
            }
            Console.WriteLine();
        }
 
        for (int i = 0; i < a.GetLength(0); i++)
        {
            // Найдем индекс максимального элемента в текущей строке
            int I = 0;
            int max = a[i, 0];
 
            for (int j = 1; j < a.GetLength(1); j++)
            {
                if (a[i, j] > max)
                {
                    I = j;
                    max = a[i, j];
                }
            }
 
            // Поменяем местами максимальный и первый элементы текущей строки
            int t = a[i, 0];
            a[i, 0] = a[i,I];
            a[i,I] = t;
        }
 
        // Вывод матрицы после замены
        Console.WriteLine("Новая матрица: ");
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
 
}
// 13
using System;
class Program
{
    static void Main()
    {
        int N, n, M, m;
        Console.WriteLine("Введите число строк и столбцов матрицы");
        Console.Write("Число строк N="); // Введите N
        N = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов M="); // Введите M
        M = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random rnd = new Random(); // Для случайных чисел
        int[,] a = new int[N, M]; // Матрица a[N,M] типа int 
        for (n = 0; n < N; n++)
        {
            for (m = 0; m < M; m++)
            {
                int Mm = rnd.Next(-100, 100); // Генерация случайного числа 
                a[n, m] = Mm;
            }
        }
 
        Console.WriteLine("Начальная матрица: ");// вывод начальной матрицы
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write("{0} ", a[i, j]);
            }
            Console.WriteLine();
        }
 
        int max = a[0, 0];
        int I = 0;
 
        // Находим индекс столбца, содержащего максимальный элемент на диагонали
        for (int i = 0; i < N; i++)
        {
            if (a[i, i] > max)
            {
                max = a[i, i];
                I = i;
            }
        }
 
        
        for (int i = 0; i < N; i++)
        {
            int t = a[i, i];
            a[i, i] = a[i,I];
            a[i,I] = t;
        }
 
        // Выводим измененную матрицу на экран
        Console.WriteLine("Новая матрица: ");
        for (int i = 0; i < N; i++)
        {
            for ( I = 0; I < M; I++)
            {
                Console.Write(a[i, I] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
// 17
using System;
class Program
{
    static void Main()
    {
        int N, n, M, m, P;
        Console.WriteLine("Введите число строк и столбцов матрицы");
        Console.Write("Число строк N="); // Введите N
        N = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов M="); // Введите M
        M = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random rnd = new Random(); // Для случайных чисел
        int[,] a = new int[N, M]; // Матрица a[N,M] типа int 
        for (n = 0; n < N; n++)
        {
            for (m = 0; m < M; m++)
            {
                int Mm = rnd.Next(-100, 100); // Генерация случайного числа 
                a[n, m] = Mm;
            }
        }
 
        Console.WriteLine("Начальная матрица: ");// вывод начальной матрицы
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write("{0} ", a[i, j]);
            }
            Console.WriteLine();
        }
 
        for (int i = 0; i < n; i++)
        {
            int min = a[i, 0];
            int I = 0;
 
            // Находим минимальный элемент в строке
            for (int j = 1; j < M; j++)
            {
                if (a[i, j] < min)
                {
                    min = a[i, j];
                    I = j;
                }
            }
 
            // Переставляем минимальный элемент в начало строки
            for (int j = I; j > 0; j--)
            {
                a[i, j] = a[i, j - 1];
            }
            a[i, 0] = min;
        }
 
        // Вывод результата
        Console.WriteLine("Новый массив: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
//21
using System;
class Program
{
    static void Main()
    {
        int N, n, M, m;
        Console.WriteLine("Введите число строк и столбцов матрицы");
        Console.Write("Число строк N="); // Введите N
        N = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов M="); // Введите M
        M = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random rnd = new Random(); // Для случайных чисел
        int[,] a = new int[N, M]; // Матрица a[N,M] типа int 
        for (n = 0; n < N; n++)
        {
            for (m = 0; m < M; m++)
            {
                int Mm = rnd.Next(-100, 100); // Генерация случайного числа 
                a[n, m] = Mm;
            }
        }
 
        Console.WriteLine("Начальная матрица: ");// вывод начальной матрицы
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M - 1; j++)
            {
                Console.Write("{0} ", a[i, j]);
            }
            Console.WriteLine();
        }
        // Находим максимальный элемент в каждой строке
        int c = 0;
        for (int i = 0; i < N; i++)
        {
            int max = a[i, 0];
            for (int j = 1; j < M - 1; j++)
            {
                if (a[i, j] > max)
                {
                    max = a[i, j];
                }
                 c = max;
            }
        }
 
        // Помещаем столбец с максимальными элементами перед последним столбцом
        for (int i = 0; i < N; i++)
        {
            a[i, M - 2] = c;
        }
 
        // Выводим полученную матрицу
        Console.WriteLine("Новая матрица: ");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
//25
using System;
class Program
{
    static void Main()
    {
        int N, n, M, m, P;
        Console.WriteLine("Введите число строк и столбцов матрицы");
        Console.Write("Число строк N="); // Введите N
        N = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов M="); // Введите M
        M = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random rnd = new Random(); // Для случайных чисел
        int[,] X = new int[N, M]; // Матрица a[N,M] типа int 
        for (n = 0; n < N; n++)
        {
            for (m = 0; m < M; m++)
            {
                int Mm = rnd.Next(-100, 100); // Генерация случайного числа 
                X[n, m] = Mm;
            }
        }

        Console.WriteLine("Начальная матрица: ");// вывод начальной матрицы
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write("{0} ", X[i, j]);
            }
            Console.WriteLine();
        }
        int[] max = new int[N];

        int minN = int.MaxValue;
        int maxN = int.MinValue;
        int z= -1;
        int I = -1;

        for (int i = 0; i < N; i++)
        {
            int c = 0;

            for (int j = 0; j < M; j++)
            {
                if (X[i, j] < 0)
                {
                    c++;
                }
            }

            if (c < minN)
            {
                minN = c;
                z = i;
            }

            if (c > maxN)
            {
                maxN = c;
                I = i;
            }
        }

        // Меняем местами строки с минимальным и максимальным количеством отрицательных элементов
        for (int j = 0; j < M; j++)
        {
            int t = X[z, j];
            X[z, j] = X[I, j];
            X[I, j] = t;
        }

        // Вывод матрицы X после перестановки строк
        Console.WriteLine("Новая матрица: ");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write(X[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
// 29
using System;
class Program
{
    static void Main()
    {
        int N, n, M, m, P;
        Console.WriteLine("Введите число строк и столбцов матрицы");
        Console.Write("Число строк N="); // Введите N
        N = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов M="); // Введите M
        M = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random rnd = new Random(); // Для случайных чисел
        int[,] A = new int[N, M]; // Матрица a[N,M] типа int 
        for (n = 0; n < N; n++)
        {
            for (m = 0; m < M; m++)
            {
                int Mm = rnd.Next(-100, 100); // Генерация случайного числа 
                A[n, m] = Mm;
            }
        }

        Console.WriteLine("Начальная матрица: ");// вывод начальной матрицы
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write("{0} ", A[i, j]);
            }
            Console.WriteLine();
        }
        int x = 0;
        int min = Math.Abs(A[1, 0]);

        // Находим столбец с минимальным по модулю элементом во 2-й строке
        for (int j = 1; j < M; j++)
        {
            int e = Math.Abs(A[1, j]);
            if (e < min)
            {
                min = e;
                x = j;
            }
        }

        int[,] newF = new int[N,M - 1];

        // Копируем элементы до столбца с минимальным элементом
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < x; j++)
            {
                newF[i, j] = A[i, j];
            }
        }

        // Копируем элементы после столбца с минимальным элементом
        for (int i = 0; i < N; i++)
        {
            for (int j = x + 1; j < M; j++)
            {
                newF[i, j - 1] = A[i, j];
            }
        }

        // Выводим полученную матрицу
        Console.WriteLine("Матрица без столбца после столбца с минимальным элементом во 2-й строке:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M - 1; j++)
            {
                Console.Write("{0} ", newF[i, j]);
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
// 33
using System;
class Program
{
    static void Main()
    {
        int N, n, M, m, P;
        Console.WriteLine("Введите число строк и столбцов матрицы");
        Console.Write("Число строк N="); // Введите N
        N = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов M="); // Введите M
        M = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random rnd = new Random(); // Для случайных чисел
        int[,] A = new int[N, M]; // Матрица a[N,M] типа int 
        for (n = 0; n < N; n++)
        {
            for (m = 0; m < M; m++)
            {
                int Mm = rnd.Next(-100, 100); // Генерация случайного числа 
                A[n, m] = Mm;
            }
        }

        Console.WriteLine("Начальная матрица: ");// вывод начальной матрицы
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write("{0} ", A[i, j]);
            }
            Console.WriteLine();
        }
        int[] ne = new int[N * M];

        int c = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                if (A[i, j] < 0)
                {
                    ne[c] = A[i, j];
                    c++;
                }
            }
        }

        // Вывод отрицательных элементов массива
        Console.WriteLine("Отрицательные элементы матрицы:");

        for (int i = 0; i < c; i++)
        {
            Console.Write(ne[i] + " ");
        }
        Console.ReadKey();
    }
}
// второй уровень
// 1
using System;
class Program
{
    static void Main()
    {
        int N, n, M, m;
        Console.WriteLine("Введите число строк и столбцов матрицы");
        Console.Write("Число строк N="); // Введите N
        N = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов M="); // Введите M
        M = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random rnd = new Random(); // Для случайных чисел
        int[,] A = new int[N, M]; // Матрица a[N,M] типа int 
        for (n = 0; n < N; n++)
        {
            for (m = 0; m < M; m++)
            {
                int Mm = rnd.Next(-100, 100); // Генерация случайного числа 
                A[n, m] = Mm;
            }
        }

        Console.WriteLine("Начальная матрица: ");// вывод начальной матрицы
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write("{0} ", A[i, j]);
            }
            Console.WriteLine();
        }
        for (int i = 0; i < N; i++)
        {
            int I = 0;
            int max = A[i, I];

            // Находим индекс максимального элемента в строке
            for (int j = 1; j < M; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    I = j;
                }
            }

            // Увеличиваем соседние элементы
            if (I == 0)
            {
                A[i, I + 1] *= 2;
            }
            else if (I == M - 1)
            {
                A[i, I - 1] *= 2;
            }
            else
            {
                if (A[i, I - 1] < A[i, I + 1])
                {
                    A[i, I - 1] *= 2;
                }
                else
                {
                    A[i, I + 1] *= 2;
                }
            }
        }

        // Вывод измененной матрицы
        Console.WriteLine("Измененная матрица:");

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
// 5
using System;
class Program
{
    static void Main()
    {
        int N, n, M, m;
        Console.WriteLine("Введите число строк и столбцов матрицы");
        Console.Write("Число строк N="); // Введите N
        N = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов M="); // Введите M
        M = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random rnd = new Random(); // Для случайных чисел
        int[,] A = new int[N, M]; // Матрица a[N,M] типа int 
        for (n = 0; n < N; n++)
        {
            for (m = 0; m < M; m++)
            {
                int Mm = rnd.Next(-100, 100); // Генерация случайного числа 
                A[n, m] = Mm;
            }
        }

        Console.WriteLine("Начальная матрица: ");// вывод начальной матрицы
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write("{0} ", A[i, j]);
            }
            Console.WriteLine();
        }
        // находим максимальные элементы столбцов и заменяем их
        for (int j = 0; j < M; j++)
        {
            int max = A[0, j];
            int s = (A[0, j] + A[M - 1, j] )/ 2;
            int I = 0;
            for (int i = 1; i < N; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    I = i;
                }
            }
            if (max < s)
            {
                A[I, j] = s;
            }
            else
            {
                A[I, j] = I;
            }
        }

        // выводим результаты
        Console.WriteLine("Новая матрица: ");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
// 9
using System;
class Program
{
    static void Main()
    {
        int N, n, M, m;
        Console.WriteLine("Введите число строк и столбцов матрицы");
        Console.Write("Число строк N="); // Введите N
        N = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов M="); // Введите M
        M = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random rnd = new Random(); // Для случайных чисел
        int[,] A = new int[N, M]; // Матрица a[N,M] типа int 
        for (n = 0; n < N; n++)
        {
            for (m = 0; m < M; m++)
            {
                int Mm = rnd.Next(-100, 100); // Генерация случайного числа 
                A[n, m] = Mm;
            }
        }

        Console.WriteLine("Начальная матрица: ");// вывод начальной матрицы
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write("{0} ", A[i, j]);
            }
            Console.WriteLine();
        }
        int r = N;
        int c = M;

        int[,] a = new int[r, c];

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                a[i, j] = A[r - i - 1, j];
            }
        }

        // Выводим элементы обратной матрицы
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.WriteLine(a[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
// третий уровень
// 1
using System;
class Program
{
    static void Main()
    {
        int N, n, M, m;
        Console.WriteLine("Введите число строк и столбцов матрицы");
        Console.Write("Число строк N="); // Введите N
        N = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов M="); // Введите M
        M = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random rnd = new Random(); // Для случайных чисел
        int[,] A = new int[N, M]; // Матрица a[N,M] типа int 
        for (n = 0; n < N; n++)
        {
            for (m = 0; m < M; m++)
            {
                int Mm = rnd.Next(-100, 100); // Генерация случайного числа 
                A[n, m] = Mm;
            }
        }

        Console.WriteLine("Начальная матрица: ");// вывод начальной матрицы
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write("{0} ", A[i, j]);
            }
            Console.WriteLine();
        }
        int r = N;
        int c = M;

        int[] min = new int[r];
        int[] s = new int[r];

        for (int i = 0; i < r; i++)
        {
            int I = FindMinElementIndex(A, i);
            min[i] = A[I, 0];
            s[i] = I;
            SwapRows(A, i, I);
        }

        Console.WriteLine("Матрица после перестановки строк:");
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Минимальные элементы строк в порядке убывания:");
        for (int i = 0; i < r; i++)
        {
            Console.WriteLine("Строка {0}: {1}", s[i], min[i]);
        }
        Console.ReadKey();
    }

    static int FindMinElementIndex(int[,] A, int row)
    {
        int c = A.GetLength(1);
        int I = row;

        for (int i = row + 1; i < A.GetLength(0); i++)
        {
            if (A[i, 0] < A[I, 0])
            {
                I = i;
            }
        }

        return I;
    }

    static void SwapRows(int[,] A, int row1, int row2)
    {
        int c = A.GetLength(1);

        for (int j = 0; j < c; j++)
        {
            int t = A[row1, j];
            A[row1, j] = A[row2, j];
            A[row2, j] = t;
        }
    }
}
// 9
using System;
class Program
{
    static void Main()
    {
        int N, n, M, m;
        Console.WriteLine("Введите число строк и столбцов матрицы");
        Console.Write("Число строк N="); // Введите N
        N = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов M="); // Введите M
        M = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random rnd = new Random(); // Для случайных чисел
        int[,] A = new int[N, M]; // Матрица a[N,M] типа int 
        for (n = 0; n < N; n++)
        {
            for (m = 0; m < M; m++)
            {
                int Mm = rnd.Next(-100, 100); // Генерация случайного числа 
                A[n, m] = Mm;
            }
        }

        Console.WriteLine("Начальная матрица: ");// вывод начальной матрицы
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write("{0} ", A[i, j]);
            }
            Console.WriteLine();
        }
        // Создаем массив, в котором будем хранить количество отрицательных элементов в каждом столбце
        int[] C = new int[M];

        // Подсчитываем количество отрицательных элементов в каждом столбце
        for (int j = 0; j < M; j++)
        {
            for (int i = 0; i < N; i++)
            {
                if (A[i, j] < 0)
                {
                    C[j]++;
                }
            }
        }

        // Создаем массив индексов столбцов
        int[] c = new int[M];
        for (int i = 0; i < c.Length; i++)
        {
            c[i] = i;
        }

        // Сортируем массив индексов столбцов в порядке возрастания количества отрицательных элементов
        Array.Sort(c, (a, b) => C[a].CompareTo(C[b]));

        // Создаем новую матрицу, в которую будем перемещать столбцы
        int[,] a = new int[N, M];

        // Переносим столбцы в новую матрицу в соответствии с отсортированными индексами
        for (int j = 0; j < c.Length; j++)
        {
            for (int i = 0; i < N; i++)
            {
                a[i, j] = A[i, c[j]];
            }
        }

        // Выводим полученную матрицу на консоль
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
// 12
using System;
class Program
{
    static void Main()
    {
        int N, n, M, m;
        Console.WriteLine("Введите число строк и столбцов матрицы");
        Console.Write("Число строк N="); // Введите N
        N = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов M="); // Введите M
        M = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random rnd = new Random(); // Для случайных чисел
        double[,] A = new double[N, M]; // Матрица a[N,M] типа int 
        for (n = 0; n < N; n++)
        {
            for (m = 0; m < M; m++)
            {
                int Mm = rnd.Next(-100, 100); // Генерация случайного числа 
                A[n, m] = Mm;
            }
        }


        Console.WriteLine("Исходная матрица:");
        PrintMatrix(A);

        for (int j = 0; j < M - 1; j++)
        {
            for (int k = j + 1; k < M; k++)
            {
                double p = A[k, j] / A[j, j];
                for (int x = j; x < M; x++)
                {
                    A[k, x] -= A[j, x] * p;
                }
            }
        }

        Console.WriteLine("Преобразованная матрица:");
        PrintMatrix(A);
    }

    static void PrintMatrix(double[,] A)
    {
        int n = A.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}
