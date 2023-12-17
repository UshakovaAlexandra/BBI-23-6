// лаба 5
// 1
using System;

class Program
{
    static void Main()
    {
        int E, e, Q, q;
        Console.WriteLine("Введите число строк и столбцов матрицы A ");
        Console.Write("Число строк E="); // Введите E
        E = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов Q="); // Введите Q
        Q = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random r = new Random(); // Для случайных чисел
        int[,] A = new int[E, Q]; // Матрица A[E,Q] типа int 
        for (e = 0; e < E; e++)
        {
            for (q = 0; q < Q; q++)
            {
                int Qq = r.Next(-100, 100); // Генерация случайного числа 
                A[e, q] = Qq;
            }
        }
        int F, f, Z, z;
        Console.WriteLine("Введите число строк и столбцов матрицы B ");
        Console.Write("Число строк F= "); // Введите F
        F = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов Z= "); // Введите Z
        Z = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random rnd = new Random(); // Для случайных чисел
        int[,] B = new int[F, Z]; // Матрица B[F,Z] типа int 
        for (f = 0; f < F; f++)
        {
            for (z = 0; z < Z; z++)
            {
                int Zz = rnd.Next(-100, 100); // Генерация случайного числа 
                B[f, z] = Zz;
            }
        }
        Console.WriteLine("Начальная матрица A: ");// вывод начальной матрицы
        for (int i = 0; i < E; i++)
        {
            for (int j = 0; j < Q; j++)
            {
                Console.Write("{0} ", A[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Начальная матрица B: ");// вывод начальной матрицы
        for (int i = 0; i < F; i++)
        {
            for (int j = 0; j < Z; j++)
            {
                Console.Write("{0} ", B[i, j]);
            }
            Console.WriteLine();
        }

        int[] maxA = FindMaxElementIndices(A);
        int[] maxB = FindMaxElementIndices(B);

        SwapElements(A, maxA[0], maxA[1], B, maxB[0], maxB[1]);

        // Вывод матрицы А после обмена максимальных элементов
        Console.WriteLine("Матрица A после обмена максимальных элементов:");
        PrintMatrix(A);

        // Вывод матрицы B после обмена максимальных элементов
        Console.WriteLine("nМатрица B после обмена максимальных элементов:");
        PrintMatrix(B);
    }

    static int[] FindMaxElementIndices(int[,] matrix)
    {
        int max = int.MinValue;
        int r = -1;
        int c = -1;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    r = i;
                    c = j;
                }
            }
        }

        return new int[] { r, c };
    }

    static void SwapElements(int[,] A, int rA, int cA, int[,] B, int rB, int cB)
    {
        int t = A[rA, cA];
        A[rA, cA] = B[rB, cB];
        B[rB, cB] = t;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int r = matrix.GetLength(0);
        int c = matrix.GetLength(1);

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}
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
                Console.Write("{0} ", B[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Начальная матрица C: ");// вывод начальной матрицы
        for (int i = 0; i < F; i++)
        {
            for (int j = 0; j < Z; j++)
            {
                Console.Write("{0} ", C[i, j]);
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
        PrintArray(result);
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
 
        int[,] result = new int[rowsB + 1, columnsB + columnsC];
 
        // Копирование массива B до строки с максимальным количеством положительных элементов
        for (int i = 0; i <= row; i++)
        {
            for (int j = 0; j < columnsB; j++)
            {
                result[i, j] = arrayB[i, j];
            }
        }
 
        // Вставка столбца C после строки с максимальным количеством положительных элементов
        for (int i = 0; i < rowsC; i++)
        {
            for (int j = 0; j < columnsC; j++)
            {
                result[row + 1 + i, j + columnsB] = arrayC[i, j];
            }
        }
 
        // Копирование оставшейся части массива B
        for (int i = row + 1; i < rowsB; i++)
        {
            for (int j = 0; j < columnsB; j++)
            {
                result[i + rowsC, j] = arrayB[i, j];
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
}
// 13
using System;

class Program
{
    static void Main()
    {
        // Создаем исходную матрицу
        int E, e, Q, q;
        Console.WriteLine("Введите число строк и столбцов матрицы A ");
        Console.Write("Число строк E="); // Введите E
        E = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов Q="); // Введите Q
        Q = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random r = new Random(); // Для случайных чисел
        int[,] A = new int[E, Q]; // Матрица A[E,Q] типа int 
        for (e = 0; e < E; e++)
        {
            for (q = 0; q < Q; q++)
            {
                int Qq = r.Next(-100, 100); // Генерация случайного числа 
                A[e, q] = Qq;
            }
        }
        Console.WriteLine("Начальная матрица A: ");// вывод начальной матрицы
        for (int i = 0; i < E; i++)
        {
            for (int j = 0; j < Q; j++)
            {
                Console.Write("{0} ", A[i, j]);
            }
            Console.WriteLine();
        }

        int rowCount = A.GetLength(0); // получаем количество строк в матрице

        // находим максимальный и минимальный элементы в матрице
        int maxElement = int.MinValue;
        int minElement = int.MaxValue;

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > maxElement)
                    maxElement = A[i, j];

                if (A[i, j] < minElement)
                    minElement = A[i, j];
            }
        }

        // вызываем метод для удаления строк с максимальным и минимальным элементами
        A = RemoveRowsWithMinMaxElements(A, maxElement, minElement);

        // выводим полученную матрицу
        Console.WriteLine("Новая матрица: ");
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] RemoveRowsWithMinMaxElements(int[,] matrix, int maxElement, int minElement)
    {
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        int[] rowsToRemove = new int[row]; // массив для хранения индексов строк, которые нужно удалить
        int remove = 0; // количество строк, которые нужно удалить

        for (int i = 0; i < row; i++)
        {
            bool Max = false;
            bool Min= false;

            for (int j = 0; j < col; j++)
            {
                if (matrix[i, j] == maxElement)
                    Max = true;

                if (matrix[i, j] == minElement)
                    Min = true;
            }

            // если текущая строка содержит максимальный или минимальный элемент, добавляем ее индекс в массив rowsToRemove
            if (Max || Min)
            {
                rowsToRemove[remove] = i;
                remove++;
            }
        }

        // создаем новую матрицу с учетом удаленных строк
        int[,] newMatrix = new int[row - remove, col];
        int newRow = 0;

        for (int i = 0; i < row; i++)
        {
            // пропускаем удаленные строки
            if (Array.IndexOf(rowsToRemove, i) != -1)
                continue;

            for (int j = 0; j < col; j++)
            {
                newMatrix[newRow, j] = matrix[i, j];
            }

            newRow++;
        }

        return newMatrix;
    }
}
// 19
using System;

class Program
{
    static void Main()
    {
        // Создаем исходную матрицу
        int E, e, Q, q;
        Console.WriteLine("Введите число строк и столбцов матрицы A ");
        Console.Write("Число строк E="); // Введите E
        E = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов Q="); // Введите Q
        Q = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random r = new Random(); // Для случайных чисел
        int[,] A = new int[E, Q]; // Матрица A[E,Q] типа int 
        for (e = 0; e < E; e++)
        {
            for (q = 0; q < Q; q++)
            {
                int Qq = r.Next(-100, 100); // Генерация случайного числа 
                A[e, q] = Qq;
            }
        }

        // Выводим исходную матрицу
        Console.WriteLine("Исходная матрица:");
        PrintMatrix(A);

        // Удаляем строки с нулевыми элементами
        int[,] newMatrix = RemoveRowsWithZeros(A);

        // Выводим полученную матрицу после удаления строк
        Console.WriteLine("Матрица после удаления строк с нулевыми элементами:");
        PrintMatrix(newMatrix);

        Console.ReadLine();
    }

    // Метод для удаления строк с нулевыми элементами из матрицы
    static int[,] RemoveRowsWithZeros(int[,] A)
    {
        int r = A.GetLength(0);
        int c = A.GetLength(1);

        // Подсчитываем количество строк без нулевых элементов
        int newR = 0;
        for (int i = 0; i < r; i++)
        {
            bool Zero = false;
            for (int j = 0; j < c; j++)
            {
                if (A[i, j] == 0)
                {
                    Zero = true;
                    break;
                }
            }
            if (!Zero)
            {
                newR++;
            }
        }

        // Создаем новую матрицу с учетом полученного количества строк
        int[,] newMatrix = new int[newR, c];

        // Копируем строки без нулевых элементов в новую матрицу
        int Row = 0;
        for (int i = 0; i < r; i++)
        {
            bool nZero = false;
            for (int j = 0; j < c; j++)
            {
                if (A[i, j] == 0)
                {
                    nZero = true;
                    break;
                }
            }
            if (!nZero)
            {
                for (int j = 0; j < c; j++)
                {
                    newMatrix[Row, j] = A[i, j];
                }
                Row++;
            }
        }

        return newMatrix;
    }

    // Метод для вывода матрицы в консоль
    static void PrintMatrix(int[,] A)
    {
        int r = A.GetLength(0);
        int c = A.GetLength(1);

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
// 25
using System;

class Program
{
    static void Main()
    {
        int E, e, Q, q;
        Console.WriteLine("Введите число строк и столбцов матрицы A ");
        Console.Write("Число строк E="); // Введите E
        E = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов Q="); // Введите Q
        Q = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random r = new Random(); // Для случайных чисел
        int[,] A = new int[E, Q]; // Матрица A[E,Q] типа int 
        for (e = 0; e < E; e++)
        {
            for (q = 0; q < Q; q++)
            {
                int Qq = r.Next(-100, 100); // Генерация случайного числа 
                A[e, q] = Qq;
            }
        }
        int F, f, Z, z;
        Console.WriteLine("Введите число строк и столбцов матрицы B ");
        Console.Write("Число строк F= "); // Введите F
        F = int.Parse(Console.ReadLine());
        Console.Write("Число столбцов Z= "); // Введите Z
        Z = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random rnd = new Random(); // Для случайных чисел
        int[,] B = new int[F, Z]; // Матрица B[F,Z] типа int 
        for (f = 0; f < F; f++)
        {
            for (z = 0; z < Z; z++)
            {
                int Zz = rnd.Next(-100, 100); // Генерация случайного числа 
                B[f, z] = Zz;
            }
        }
        Console.WriteLine("Начальная матрица A: ");// вывод начальной матрицы
        for (int i = 0; i < E; i++)
        {
            for (int j = 0; j < Q; j++)
            {
                Console.Write("{0} ", A[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Начальная матрица B: ");// вывод начальной матрицы
        for (int i = 0; i < F; i++)
        {
            for (int j = 0; j < Z; j++)
            {
                Console.Write("{0} ", B[i, j]);
            }
            Console.WriteLine();
        }

        int rowWithMostNegativeElements1 = GetRowWithMostNegativeElements(A);
        int rowWithMostNegativeElements2 = GetRowWithMostNegativeElements(B);

        Console.WriteLine("Матрица 1:");
        PrintMatrix(A);
        Console.WriteLine("Строка с наибольшим количеством отрицательных элементов: " + rowWithMostNegativeElements1);
        Console.WriteLine();

        Console.WriteLine("Матрица 2:");
        PrintMatrix(B);
        Console.WriteLine("Строка с наибольшим количеством отрицательных элементов: " + rowWithMostNegativeElements2);

        Console.ReadLine();
    }

    static int GetNegativeElementCount(int[] row)
    {
        int c = 0;
        foreach (var e in row)
        {
            if (e < 0)
            {
                c++;
            }
        }
        return c;
    }

    static int GetRowWithMostNegativeElements(int[,] matrix)
    {
        int row = 0;
        int max = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int[] r = new int[matrix.GetLength(1)];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                r[j] = matrix[i, j];
            }

            int negative = GetNegativeElementCount(r);

            if (negative > max)
            {
                max = negative;
                row = i;
            }
        }

        return row;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}