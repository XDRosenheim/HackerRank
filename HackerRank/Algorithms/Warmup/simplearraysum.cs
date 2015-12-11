using System;
using System.Linq;

namespace HackerRank.Algorithms.Warmup
{
    public class Simplearraysum {
        public static void Solution() {
            int n = Convert.ToInt32( Console.ReadLine() );
            var arrTemp = Console.ReadLine().Split( ' ' );
            var arr = Array.ConvertAll( arrTemp, int.Parse );
            // Solution
            Console.WriteLine( arr.Sum() );
        }
    }
}
