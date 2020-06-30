﻿using System;
using System.Linq;
using System.Numerics;

namespace lab_9
{
    public static class GFG
    {
        public static BigInteger[] GenerateSequence(int z)
        {
            BigInteger[] sequence = new BigInteger[z];
            Random random = new Random();

            int count = 0;
            while(count != z)
            {
                var rnd = random.Next((int)BigInteger.Add(sequence.Aggregate(BigInteger.Add), 20));
                if(sequence.Aggregate(BigInteger.Add) < rnd)
                {
                    sequence[count] = rnd;
                    count++;
                }

            }
            return sequence;
        }
    }
}
