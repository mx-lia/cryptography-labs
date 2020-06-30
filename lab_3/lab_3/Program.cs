using System;

namespace lab_3
{
    class Program
    {
        private static int GetNOD (int a , int b)
        {
            while (true)
            {
                if (a > b)
                    a -= b;
                else if (a < b)
                    b -= a;
                else
                    return a;
            }
        }

        private static int gcd(int a, int b, out int x, out int y)
        {
            if (a == 0)
            {
                x = 0; y = 1;
                return b;
            }
            int d = gcd(b % a, a, out int x1, out int y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return d;
        }

        private static bool IsSimple(int N)
        {
            for (int i = 2; i <= (int)(N / 2); i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }

        private static void Calculate(int m, int n)
        {
            int count = 0;
            Console.WriteLine($"Simple numbers in [{m}, {n}]: ");
            for (int i = m; i <= n; i++)
            {
                if (IsSimple(i))
                {
                    Console.Write(i.ToString() + "\t");
                    count++;
                }
            }
            Console.WriteLine($"\nCount of simple numbers in [{m}, {n}]: {count}");
            double val = n / Math.Log(n);
            Console.WriteLine($"n/ln(n) = {val}");
            Console.WriteLine("-------------------");
        }

        private static void GetCanonicalForm(int num)
        {
            Console.Write($"{num} = 1");
            for (; num % 2 == 0; num /= 2)
            {
                Console.Write(" * {0}", 2);
            }
            for (int i = 3; i <= num;)
            {
                if (num % i == 0)
                {
                    Console.Write(" * {0}", i);
                    num /= i;
                }
                else
                {
                    i += 2;
                }
            }
            Console.WriteLine("\n-------------------");
        }

        static void Main(string[] args)
        {
            Calculate(2, 591);
            Calculate(555, 591);
            GetCanonicalForm(555);
            GetCanonicalForm(591);
            Console.WriteLine($"Is simple m||n = 555591? {IsSimple(555591)}");
            Console.WriteLine("-------------------");
            Console.WriteLine($"NOD(555, 591) = {GetNOD(555, 591)}");
            Console.WriteLine("-------------------");
            Console.Write("Enter a = ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Enter m = ");
            int.TryParse(Console.ReadLine(), out int m);
            if(gcd(a, m, out int x, out int y) == 1)
            {
                Console.WriteLine($"The inverse of {a} modulo {m} = {x}");
            }
            else
            {
                Console.WriteLine($"The inverse of {a} modulo {m} = not exist");
            }
            
        }
    }
}
