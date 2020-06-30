using System.Numerics;

namespace lab_9
{
    class GCD
    {
        public static BigInteger GetNOD(BigInteger a, BigInteger b)
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

        public static BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            a = a % m;
            for (int x = 1; x < m; x++)
                if ((a * x) % m == 1)
                    return x;
            return 1;
        }
    }
}
