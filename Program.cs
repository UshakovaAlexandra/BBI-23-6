// 7
using System;

class Program
{
    static void Main(string[] args)
    {
        // Инициализация исходных массивов
        int E, e, Q, q;
        Console.WriteLine("Введите число строк и столбцов матрицы");
        Console.Write("Число строк E="); // Введите E
        E = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов Q="); // Введите Q
        Q = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random r = new Random(); // Для случайных чисел
        int[,] B = new int[E, Q]; // Матрица B[E,Q] типа int 
        for (e = 0; e < E; e++)
        {
            for (q = 0; q < Q; q++)
            {
                int Qq = r.Next(-100, 100); // Генерация случайного числа 
                B[e, q] = Qq;
            }
        }
        int F, f, Z, z;
        Console.WriteLine("Введите число строк и столбцов матрицы");
        Console.Write("Число строк F= "); // Введите F
        F = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов Z= "); // Введите Z
        Z = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random rnd = new Random(); // Для случайных чисел
        int[,] C = new int[F, Z]; // Матрица C[F,Z] типа int 
        for (f = 0; f < F; f++)
        {
            for (z = 0; z < Z; z++)
            {
                int Zz = rnd.Next(-100, 100); // Генерация случайного числа 
                C[f, z] = Zz;
            }
        }
        Console.WriteLine("Начальная матрица B: ");// вывод начальной матрицы
        for (int i = 0; i < E; i++)
        {
            for (int j = 0; j < Q; j++)
            {
                Console.Write("{0, 4} ", B[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Начальная матрица C: ");// вывод начальной матрицы
        for (int i = 0; i < F; i++)
        {
            for (int j = 0; j < Z; j++)
            {
                Console.Write("{0, 4} ", C[i, j]);
            }
            Console.WriteLine();
        }

        // Поиск строки с максимальным количеством положительных элементов
        int maxPositiveCountRow = FindRowWithMaxPositiveCount(B);

        // Поиск столбца с максимальным количеством положительных элементов
        int maxPositiveCountColumn = FindColumnWithMaxPositiveCount(C);

        // Вставка столбца C после строки с максимальным количеством положительных элементов
        int[,] result = InsertColumnAfterRow(B, C, maxPositiveCountRow, maxPositiveCountColumn);

        // Вывод результата
        Console.WriteLine("Вывод результата: ");
        PrintArray(result);

        int[] onedimensionalArray = ConvertToOnedimensionalArray(result);
        SortArray(onedimensionalArray);

        Console.WriteLine("Отсортированный одномерный массив:");
        foreach (int element in onedimensionalArray)
        {
            Console.Write($"{element} ");
        }
        Console.ReadKey();
}
    static int FindRowWithMaxPositiveCount(int[,] array)
    {
        int maxPositiveCount = 0;
        int maxPositiveCountRow = -1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int positiveCount = 0;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] > 0)
                {
                    positiveCount++;
                }
            }

            if (positiveCount > maxPositiveCount)
            {
                maxPositiveCount = positiveCount;
                maxPositiveCountRow = i;
            }
        }

        return maxPositiveCountRow;
    }

    static int FindColumnWithMaxPositiveCount(int[,] array)
    {
        int maxPositiveCount = 0;
        int maxPositiveCountColumn = -1;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            int positiveCount = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, j] > 0)
                {
                    positiveCount++;
                }
            }

            if (positiveCount > maxPositiveCount)
            {
                maxPositiveCount = positiveCount;
                maxPositiveCountColumn = j;
            }
        }

        return maxPositiveCountColumn;
    }

    static int[,] InsertColumnAfterRow(int[,] arrayB, int[,] arrayC, int row, int column)
    {
        int rowsB = arrayB.GetLength(0);
        int columnsB = arrayB.GetLength(1);
        int rowsC = arrayC.GetLength(0);
        int columnsC = arrayC.GetLength(1);

        int[,] result = new int[rowsB + 1, columnsB];

        // Копирование массива B до строки с максимальным количеством положительных элементов
        for (int i = 0; i <= row; i++)
        {
            for (int j = 0; j < columnsB; j++)
            {
                result[i, j] = arrayB[i, j];
            }
        }

        // Вставка столбца C после строки с максимальным количеством положительных элементов
        for (int i = 0, j = 0; j < columnsB; i++, j++)
        {
            //for (int j = 0; j < columnsC; j++)
            //{
            result[row + 1, j] = arrayC[i, column];
            //}
        }

        // Копирование оставшейся части массива B
        for (int i = row + 2; i <= rowsB; i++)
        {
            for (int j = 0; j < columnsB; j++)
            {
                result[i, j] = arrayB[i - 1, j];
            }
        }

        return result;
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
   }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }


    static int[] ConvertToOnedimensionalArray(int[,] array)
    {
        int[] onedimensionalArray = new int[array.GetLength(0) * array.GetLength(1)];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                onedimensionalArray[i * array.GetLength(1) + j] = array[i, j];
            }
        }

        return onedimensionalArray;
    }

    static void SortArray(int[] array)
    {
        MergeSort(array, 0, array.Length - 1);
    }

    static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSort(array, left, middle);
            MergeSort(array, middle + 1, right);

            Merge(array, left, middle, right);
        }
    }

    static void Merge(int[] array, int left, int middle, int right)
    {
        int[] tempArray = new int[right - left + 1];

        int i = left;
        int j = middle + 1;
        int k = 0;

        while (i <= middle && j <= right)
        {
            if (array[i] <= array[j])
            {
                tempArray[k] = array[i];
                i++;
            }
            else
            {
                tempArray[k] = array[j];
                j++;
            }

            k++;
        }

        while (i <= middle)
        {
            tempArray[k] = array[i];
            i++;
            k++;
        }

        while (j <= right)
        {
            tempArray[k] = array[j];
            j++;
            k++;
        }

        for (k = 0; k < tempArray.Length; k++)
        {
            array[left + k] = tempArray[k];
        }
    }
}

