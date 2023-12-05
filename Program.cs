// 4 лаба
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
                a[i, j] = A[i,c - j - 1];
            }
        }

        // Выводим элементы обратной матрицы
        Console.WriteLine("Новая матрица: ");
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(a[i,j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}