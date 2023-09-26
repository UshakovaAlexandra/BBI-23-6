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
