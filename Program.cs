// лаба 4 защита
using System;
using System.Runtime.CompilerServices;

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
        int[] C = new int[A.GetLength(1)];
        for (int j = 0; j < A.GetLength(1); j++)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] < 0) C[j]++;
            }
        }
        Console.WriteLine();
        int d;
        for (int k = 0; k < n; k++)
        {
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (C[j] < C[j - 1])
                {
                    d = C[j - 1];
                    C[j - 1] = C[j];
                    C[j] = d;
                    for (int i = 0; i < A.GetLength(0); i++)
                    {
                        d = A[i, j - 1];
                        A[i, j - 1] = A[i, j];
                        A[i, j] = d;

                    }
                }
            }
        }
        Console.WriteLine("Матрица в виде двумерного массива:");
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        int[] sortedA = new int[A.GetLength(0) * A.GetLength(1)];
        for (int j = 0; j < A.GetLength(1); j++)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                sortedA[i * A.GetLength(1) + j] = A[i, j];
            }
        }
        sortedA = GnomeSort(sortedA);
        Console.WriteLine("Матрица в виде одномерного массива:");
        for (int i = 0; i < sortedA.Length; i++)
        {
            Console.Write(sortedA[i] + " ");
        }
        Console.WriteLine();
    }
    static int[] GnomeSort(int[] arr)
    {
        int d = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            for (int j = i; j > 0 && arr[j] < arr[j - 1]; j--)
            {
                d = arr[j];
                arr[j] = arr[j - 1];
                arr[j - 1] = d;
            }
        }
        return arr;
    }
}