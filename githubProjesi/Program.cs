



using System;

namespace githubProjesi
{
    class Program
    {
        static int Fibonacci(int n)
        {
            if (n == 0 || n==1)
                return 1;
            return Fibonacci(n-1) + Fibonacci(n-2);
        }

        static void Main()
        {
            
                int sayi = Convert.ToInt32(Console.ReadLine());
                for(int i = 0; i <= sayi; i++)
                Console.WriteLine(Fibonacci(i));
            }
        
        }
    }
}
