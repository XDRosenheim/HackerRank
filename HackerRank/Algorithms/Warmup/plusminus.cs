using System;

namespace HackerRank.Algorithms.Warmup {
    public class Plusminus {
        public static void Solution() {
            int n = Convert.ToInt32( Console.ReadLine() );
            string[] arrTemp = Console.ReadLine().Split( ' ' );
            int[] arr = Array.ConvertAll( arrTemp, int.Parse );
            decimal positive = 0, negative = 0, zero = 0;
            const int decimals = 6;
            foreach(var i in arr) {
                if(i == 0) zero++;
                else if(i > 0) positive++;
                else if(i < 0) negative++;
            }
            Console.WriteLine( Math.Round( Convert.ToDecimal( positive / n ), decimals ) );
            Console.WriteLine( Math.Round( Convert.ToDecimal( negative / n ), decimals ) );
            Console.WriteLine( Math.Round( Convert.ToDecimal( zero / n ), decimals ) );
        }
    }
}
