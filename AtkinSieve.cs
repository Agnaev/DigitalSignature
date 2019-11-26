using System;
using System.Collections.Generic;
using System.Text;

namespace RSA
{
    class AtkinSieve
    {
        private int Limit { get; set; }
        public bool[] IsPrimes { get; set; }

        public AtkinSieve(int Limit)
        {
            this.Limit = Limit;
            IsPrimes = new bool[Limit];
            FindPrimes();
        }

        private void FindPrimes()
        {
            double sqrt = Math.Sqrt(Limit);
            for (int x = 1; x <= sqrt; x++)
            {
                for (int y = 1; y <= sqrt; y++)
                {
                    int x2 = x * x;
                    int y2 = y * y;
                    int n = 4 * x2 + y2;
                    if (n <= Limit && (n % 12 == 1 || n % 12 == 5))
                    {
                        IsPrimes[n] ^= true;
                    }

                    n -= x2;
                    if (n <= Limit && n % 12 == 7)
                    {
                        IsPrimes[n] ^= true;
                    }

                    n -= 2 * y2;
                    if (x > y && n <= Limit && n % 12 == 11)
                    {
                        IsPrimes[n] ^= true;
                    }
                }
            }
        }
    }
}
