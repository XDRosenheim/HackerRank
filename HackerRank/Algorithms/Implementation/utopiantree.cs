using System;

namespace HackerRank.Algorithms.Implementation {
    public class Utopiantree {
        public static void UtopianTree() {
            var t = Convert.ToInt32( Console.ReadLine() );
            for(var a0 = 0; a0 < t; a0++) {
                var cycles = Convert.ToInt32( Console.ReadLine() );
                var height = 1;
                for(var i = 0; i < cycles; i++) {
                    if(i % 2 != 0 || i == 0) height++;
                    else height *= 2;
                }
                Console.WriteLine( height );
            }
        }
    }
}
