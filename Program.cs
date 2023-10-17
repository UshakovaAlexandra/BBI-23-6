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
                Console.Write("Введите значение x: ");              //ввод числа x
                x = Convert.ToDouble(Console.ReadLine());           //конвертация символа в значение переменной
                y = Math.Abs(x);
                if (y >= 1) Console.WriteLine("Введите другое значение!");  //проверка условия ввода (x>1, согласно условия задания)
            } while (y >= 1);
            double sum = 1;             //начальная сумма, согласно условия задания  (S=1+...)
            //double i = 2;
            double a, p;
            //a = Math.Pow(x, i);     //суммируемый член
            a = x * x;
            p = a;
            Console.WriteLine("Первое слагаемое " + a);
            while (a > 0.0001)        //проверка условия суммирования
            {
                sum += a;
                Console.WriteLine("текущая сумма  " + sum);
                //i += 2;                 //иттерация, согласно условия задания (шаг увеличения степени)
                // a = Math.Pow(x, i);     //вычисление очередного суммируемого члена
                a = a * p;
                Console.WriteLine("Следующее слагаемое " + a);
            }
            Console.WriteLine("Результат вычисления S = " + sum);
            Console.ReadKey();
        }
    }
}