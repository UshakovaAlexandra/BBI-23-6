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
            double s = 0; for (int i = 1; i <= 113; i++ ) 
            for (int k = 2; k <= 112; k++ )
            { s += (double)k / i; 
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
// Задача 4
namespace Program
{

    class Program
    {
        public static void Main()
        {
            Console.Write("Enter the value of x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double sum = 0;
            for (int i = 1; i <= 9; i++)
            {
                sum += Math.Cos(i * x) / Math.Pow(x, i - 1);
            }

            Console.WriteLine($"s = {sum}");
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
 // Задача 10

// Задачи второго уровня
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










