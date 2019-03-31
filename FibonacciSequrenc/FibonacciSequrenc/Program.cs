using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FibonacciSequrenc
{
    
   public class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<BigInteger> sequence = Fibonacci();

            foreach (var item in sequence.Skip(0).Take(8))            {

                Console.WriteLine(item);

            }

        }

        public static IEnumerable<BigInteger> Fibonacci()
        {
            BigInteger frste =new BigInteger(0);
            BigInteger last = new BigInteger(1);
            BigInteger res = new BigInteger(0);
           while(true)
            {
                yield return res;
                res = frste + last;
                frste = last;
                last  =  res;

            }   

        }

    }
}
