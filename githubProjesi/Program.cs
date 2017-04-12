



using System;

namespace githubProjesi
{
    class Program
    {
        static int Fact(int n)
        {
            if (n == 0)
                return 1;
            return n * Fact(n - 1);
        }

        static void Main()
        {
            while (true)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Fact(sayi));
            }
        }
    }
}
