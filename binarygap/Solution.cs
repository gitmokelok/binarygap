using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarygap
{
    using System;
    // you can also use other imports, for example:
    // using System.Collections.Generic;

    // you can write to stdout for debugging purposes, e.g.
    // Console.WriteLine("this is a debug message");

    public class Solution
    {
        public int solution(int N)
        {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
            string binary = Convert.ToString(N, 2);
            string[] arrayOfZeros = binary.Split('1');
            if (arrayOfZeros.Length == 0)
                return 0;
            int counter = 0;
            foreach (var item in arrayOfZeros)
            {
                if (item.Length > counter)
                    counter = item.Length;
            }

            return counter;
        }
    }
}
