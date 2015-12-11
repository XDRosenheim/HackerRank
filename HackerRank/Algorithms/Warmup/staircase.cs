using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup {
    public class Staircase {
        public static void Solution() {
            int n = Convert.ToInt32( Console.ReadLine() );
            // Solution - Build a staircase
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n - ( i + 1 ); j++) { Console.Write( "G" ); }
                for(int j = n - i; j <= n; j++) { Console.Write( "#" ); }
                Console.WriteLine( "" );
            }
        }
    }
}
