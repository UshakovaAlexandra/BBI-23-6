// Задачи первого уровня
// Задача 1
using System;

namespace Program {

    class Program { 
    static void Main ()
        { int s = 0;
            int i;
         for (i=2; i<=35; i+=3) {
                s += i;
            }

            Console.WriteLine(s);
      }
    }
}
// Задача 2
using System;

namespace Program
{

    class Program
    {
        public static void Main()
        {
            double s = 0; for (int i = 1; i < 11; i++ ) 
            { s += (double)1 / i; 
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }  
    }
}
// Задача 3
using System;

namespace Program
{

    class Program
    {
        public static void Main()
        {
            double s = 0; for (int i = 1; i <= 112; i++ ) 
            
            {
                 s += (double) i / (i + 1); 
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
// Задача 4
using System;

namespace Program
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter the value of x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double p = 1;
            double sum = 0;
            for (int i = 1; i <= 8; i++)
            { 
                sum += Math.Cos(i * x) / p;
                p *= x;
            }

            Console.WriteLine($"s = {sum}");
            Console.ReadKey();
        }
    }
}

// Задача 5
using System;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значение для переменных p и h");
            double p = Double.Parse(Console.ReadLine());
            double h = Double.Parse(Console.ReadLine());
            double s = 0;
            for (int i = 0; i < 10; i++)
            {
                s += ((p + i * h) * (p + i * h));
            }
            Console.WriteLine("Сумма " + s);
            Console.ReadLine();
        }
    }
}

// Задача 6
using System;

namespace Program
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("{0,7} | {1,7}", "X", "Y");
            for (double x = -4; x <= 4; x += 0.5)
            {
                double y = 0.5 * x * x - 7 * x;
                Console.WriteLine($"{x,7:F3} | {y,7:F3}");
            }
        }
    }
}
// Задача 7
using System;

namespace Program {

    class Program { 
    static void Main ()
        {
            int n = 6;  
            int Factorial = 1;

            for (int i = 2; i <= n; i++) 
            {
                Factorial = Factorial * i;
            }
            Console.WriteLine(Factorial);
      }
    }
}
// Задача 8
using System;

namespace Program {

    class Program { 
    static void Main ()
        {
            int s = 0;
            int i = 0;
            int Factorial = 1;
            int n = 6;
            for (i = 1; i <= n; i++) 
            {
                Factorial = Factorial * i ;
                s = s + Factorial;
            }
            Console.WriteLine(s);
      }  
    }
}
 // Задача 9
 using System;
 
namespace ConsoleApp10
{
    class Program
    {
        static void Main()
        {
         
                int s = 0;
                int p1 = 1;
                int F = 1;
                int a = -1;
                int b = 5;
                int p2 = 1;
                
                for (int i = 1; i <= 6; i++)
                {
                    p1 *= a;
                    p2 *= b;
                    F = F * i;
                  //  Console.WriteLine("{0} , {1} , {2}", p1, p2, F);
                    s += p1 * p2 / F;
                }
                Console.WriteLine(s);
                Console.ReadKey();
        }
 
    }
}
// Задача 10
using System;

namespace Program
{
    class Program
    {
        static void Main()
        {

            int p = 1;
            int s = 3;
            for (int i = 1; i <= 7; i++) p *= s;

            Console.WriteLine(p);
            Console.ReadKey();

        }
    }
}
 // Задача 11
using System;

namespace Program {

    class Program {
        static void Main()
        {
            int s = 1;
          
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(s);
                s += 1;

            }
            Console.WriteLine(s );
        }
    
    }

}
// Задача 12
using System;

namespace Program
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter the value of x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double p = 1;
            double sum = 0;
            for (int i = 1; i <= 10; i++)
            { 
                sum += 1 / p;
                p *= x;
            }

            Console.WriteLine($"s = {sum}");
            Console.ReadKey();
        }
    }
}
// Задача 13
using System;

namespace Program
{

    class Program
    {
        static void Main()
        {
            for (double x = -1.5; x <= 1.5; x += 0.1)
            {
                if (x <= -1) Console.WriteLine(x + " | " + 1);
                if (-1 < x & x <= 1) Console.WriteLine(x + " | " + -x);
                if (x > 1) Console.WriteLine(x + "| -1");
            }
            Console.WriteLine();
        }
        }
    }
// Задача 14
using System;
 
namespace Program
{
    class Program
    {
        static void Main()
        {
            int s = 0;
            int s1 = 1;
            int t;
            for (int i = 0; i < 8; i++)
            {
                t = s;
                s = s1;
                s1 += t;
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
 
    }
}
// Задача 15
using System;
 
namespace Program
{
    class Program
    {
        static void Main()
        {
            double a = 0;
            double b = 1;
            double t;
            double a1 = 1;
            double b1 = 1;
            double t1;
            double s = 0;
            for (double i = 0; i < 5; i++)
            {
                t = a;
                a = b;
                b += t;
                t1 = a1;
                a1 = b1;
                b1 += t1;
                s = a1 / a;
               
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
 
    }
}
// Задачи второго уровня
// Задача 1
using System;

namespace Program
{
    class Program
    {
        static void Main()
        {
            double s = 0;
            double n = 1;
            Console.Write("Enter the value of x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            const double e = 0.0001;
            s = Math.Cos(x) + Math.Cos(2 * x) / 2 * 2 + Math.Cos(n * x) / n * n;
         while (Math.Cos(n * x) / n * n >= e)
            {
                s = s + Math.Cos(n * x) / n * n;
                n = n + 1;
            }
            Console.WriteLine(s);
        }

    }
}
// Задача 2
using System;

namespace Program {

    class Program {
        static void Main()
        {
            int p = 1;
            for (int n = 1; p * n < 30000; n += 3)
            {
                p *= n;
            }
            Console.WriteLine(p);
            Console.ReadKey();
        }
          
        }
    
    }
    // Задача 3
    using System;
 
namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            double a, h, p, s;
            int i = 1;
            int n = 0;
            Console.Write("Введите значение a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение h: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение p: ");
            p = Convert.ToDouble(Console.ReadLine());
            s = a;
            while (s <= p)        
            {
                s += (a + i * h);
                Console.WriteLine("текущая сумма прогрессии " + s);
                i = i + 1;               
                n = i - 1;
            }
            Console.WriteLine("Количество членов арифметической прогрессии {0}, сумма которых не превышает {1} ", n, p);
            Console.ReadKey();
            }
    }
}
    // Задача 4
    using System;
 
namespace ConsoleApp2_4
{
    class Program
    {
        static void Main()
        {
            double x, y;
            do
            {
                Console.Write("Введите значение x: ");              
                x = Convert.ToDouble(Console.ReadLine());           
                y = Math.Abs(x);
                if (y >= 1) Console.WriteLine("Введите другое значение!");  
            } while (y >= 1);
            double sum = 1;             
            double i = 2;
            double a;
            a = Math.Pow(x, i);     
            Console.WriteLine("Первое слагаемое " + a);
            while (a > 0.0001)        
                sum += a;
                Console.WriteLine("Степень {0}  текущая сумма {1} ", i, sum);
                i += 2;                 
                Console.WriteLine("Следующее слагаемое " + a);
            }
            Console.WriteLine("Результат вычисления S = " + sum);
            Console.ReadKey();
        }
    }
}

// Задача 5
using System;
namespace Program {

    class Program {
        static void Main(string[] args)
        {
            int N, M;
            int result = 1;
            N = Int32.Parse(Console.ReadLine());
            M = Int32.Parse(Console.ReadLine());
            while (N >= M)
            {
                N -= M;
                result++;
            }
            Console.WriteLine($"Частное: {result}, Остаток: {N}");
            Console.ReadKey();
        }
      }
    }
    // Задача 6
    using System;
 
namespace ConsoleApp2_7
{
    class Program
    {
        static void Main()
        {
            int a = 0;
            int d = 0;
            int s = 10;       
            while (s < 100000)
            {
                a = 2 * s;
                s = a;
                d += 3;
            
            }
            Console.WriteLine("100000 амеб будет через " + d + " часов");
            Console.ReadKey();
        }
    }
}
    // Задача 7
    using System;
 
namespace ConsoleApp2_7
{
    class Program
    {
        static void Main()
        {
            int d1 = 1;
            double s1 = 10;
            double s = 10;
            for (int i = 2; i <= 7; i++)
            {
                s1 += 0.1 * s1;
                d1 = i;
                //Console.WriteLine("Расстояние {0}  день {1} ", s1, d1);
                s += s1;
            }
            Console.WriteLine("Суммарный путь за 7 дней " + s + " км");
            int d2 = 1;
            double s2 = 10;
            double s3 = 10;
            while (s3 <= 100)
            {
                s2 += 0.1 * s2;
                d2 = d2 + 1;
                //Console.WriteLine("Расстояние {0}  день {1} ", s2, d2);
                s3 += s2;
            }
            //Console.WriteLine("Расстояние " + s3);
            Console.WriteLine("Расстояние 100 км пробежит за " + d2 + " дней");
            int d3 = 1;
            double s4 = 10;
            while (s4 <= 20)
            {
                s4 += 0.1 * s4;
                d3 = d3 + 1;
                //Console.WriteLine("Расстояние {0}  день {1} ", s4, d3);
            }
            Console.WriteLine("В день больше 20 км пробежит через " + d3 + " дней ");
            Console.ReadKey();
        }
    }
}
// задача 8
using System;

namespace Program {

    class Program {
        public static void Main()
        {
            double A, B;
            int k = 0;
            A = 1000;
            B = 2 * A;
            while (B >= A) k++;
            A *= 1.08;
            
            Console.WriteLine("k = {0}, A = {1:f2}, ", k, A );
            Console.ReadKey();
        }
    }
}

// Задачи третьего уровня
// Задача 6
using System;
 
namespace ConsoleApp3_6
{
    class Program
    {
        static void Main()
        {
            double x, s, y, d;
            int i;
            for (x = 0.1; x <= 1; x += 0.1)         //изменение x на отрезке a-b с шагом h
            {
                s = 0;
                i = 1;
                do
                {
                    d = (Math.Pow(-1, i + 1)) * (Math.Pow(x, 2 * i + 1) / (4 * i * i - 1));     //цикл do для вычисления суммы ряда
                    s = s + d;
                    i = i + 1;
                } while (Math.Abs(d) >= 0.0001);
                y = ((1 + x * x) * Math.Atan(x) / 2) - (x / 2);     //y вычисляется для каждого x для проверки суммы ряда, т.е. y должно быть равно s
                Console.WriteLine($"x = {x,7:F4} | s = {s,7:F4} | y = {y,7:F4}");
                }
            Console.ReadKey();
        }
    }
}








