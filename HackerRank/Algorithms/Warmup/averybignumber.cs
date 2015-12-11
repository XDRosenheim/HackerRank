using System;
using System.Linq;

namespace HackerRank.Algorithms.Warmup {
    public class Averybignumber {
        public static void Solution() {
            int n = Convert.ToInt32( Console.ReadLine() );
            string[] arrTemp = Console.ReadLine().Split( ' ' );
            // Solution - Changeint to long & Int32 to Int64(long)
            //int[] arr = Array.ConvertAll( arrTemp, Int32.Parse );
            long[] arr = Array.ConvertAll( arrTemp, long.Parse );
            long sum = arr.Sum();
            Console.Write( sum );
        }
    }
}
