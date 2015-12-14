using System;
using System.Linq;

namespace HackerRank.Algorithms.Implementation {
    public class Finddigits {
        public static void Solution() {
            var t = Convert.ToInt32( Console.ReadLine() );
            for(var a0 = 0; a0 < t; a0++) {
                var ns = Console.ReadLine();
                var n = Convert.ToInt32( ns );
                var result = ns.Select( t1 => Convert.ToInt32( "" + t1 ) ).Count( x => x != 0 && n % x == 0 );
                Console.WriteLine( result );
            }
        }
    }
}
