// Задачи первого уровня
// Задача 1_1
using System;

namespace ConsoleApp2_4
{
    class Program
    {
        static void Main()
        {
            double r = 2;
            double x, y;
            Console.Write("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());
            bool n = Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3);
          
            if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10,-3))
            {
                Console.WriteLine("Данная точка лежит на окружности.");
            }
            else
            {
                Console.WriteLine("Данная точка не лежит на окружности.");
            }
            Console.ReadKey();
        }
}
}
// Задача 1_4
using System;

namespace ConsoleApp2_4
{
    class Program
    {
        static void Main()
        {
            double z = 0;
            double a, b, c;
            Console.Write("Введите значение a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение c: ");
            c = Convert.ToDouble(Console.ReadLine());
            double n = 0;
            if(a > b)
            {
                n = b;
            } 
            else
            {
                n = a;
            }
            if(n > c)
            {
                z = n;
            }
            else
            {
                z = c;
            }
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
// Задача 1_7
using System;

namespace ConsoleApp2_4
{
    class Program
    {
        static void Main()
        {
            double y = 0;
            double x;
            Console.Write("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());
            if (Math.Abs(x) > 1) y = 1;
            if (Math.Abs(x) <= 1) y = Math.Abs(x);
            Console.WriteLine("При значении аргумента x {0} значение функции y {1} " , x, y);
            Console.ReadKey();
        }
    }
}
// Задачи второго уровня
// Задача 2_1
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество учеников: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int boysHeight = 0;
        int girlsHeight = 0;
        int n1 = 0;
        int n2 = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Введите рост ученика {0}: ", i + 1);
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите пол ученика (М или Ж): ");
            char gender = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

            if (gender == 'М')
            {
                boysHeight = height;
            }
            else if (gender == 'Ж')
            {
                girlsHeight = height;
            }
            else
            {
                Console.WriteLine("Некорректный ввод пола, используйте 'М' или 'Ж'.");
                i--;
            }
        }

        double boysAverageHeight = CalculateAverageHeight(boysHeight);
        double girlsAverageHeight = CalculateAverageHeight(girlsHeight);

        Console.WriteLine("Средний рост мальчиков: {0}", boysAverageHeight);
        Console.WriteLine("Средний рост девочек: {0}", girlsAverageHeight);
    }

    static double CalculateAverageHeight(int[] heights)
    {
        int sum = 0;
        int count = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            if (heights[i] > 0)
            {
                sum += heights[i];
                count++;
            }
        }

        if (count > 0)
        {
            return (double)sum / count;
        }
        else
        {
            return 0;
        }
    }
}

// Задача 2_4
using System;
 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество точек:");
        int n = int.Parse(Console.ReadLine());
 
        Console.WriteLine("Введите внутренний радиус кольца:");
        double r1 = double.Parse(Console.ReadLine());
 
        Console.WriteLine("Введите внешний радиус кольца:");
        double r2 = double.Parse(Console.ReadLine());
 
        int counter = 0;
 
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите координаты точки {i + 1}:");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
 
            //double distance = Math.Sqrt(x * x + y * y);
            double d = x * x + y * y;       //d можно убрать и переместить формулу в условие if
            if (d >= r1 * r1)
            {
                if (d <= r2 * r2) counter++;
            }
 
            //if (distance >= r1 && distance <= r2)
            //{
            //    counter++;
            //}
        }
 
        Console.WriteLine($"Количество точек, попадающих в кольцо: {counter}");
        Console.ReadKey();
    }
}
// Задача 2_7
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество точек: ");
        int n = int.Parse(Console.ReadLine());

        int q1 = 0;
        int q2 = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите координаты точки {i + 1}: ");
            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine($"Точка лежит в 1-м квадранте.");
                q1++;
            }
            else if (x < 0 && y < 0) 
            {
                Console.WriteLine($"Точка лежит в 3-м квадранте.");
                q2++;
            }
            else
            {
                Console.WriteLine($"Точка не лежит ни в 1-м, ни в 3-м квадранте.");
            }
        }

        Console.WriteLine($"Количество точек, лежащих в 1-м квадранте: {q1}");
        Console.WriteLine($"Количество точек, лежащих в 3-м квадранте: {q2}");

        Console.ReadLine();
    }
}





