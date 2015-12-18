using System;
using System.Linq;

namespace HackerRank.Algorithms.Sorting {
    public class Correctnessandtheloopinvariant {
        public static void Solution() {
            Console.ReadLine();
            var _ar = ( from s in Console.ReadLine().Split() select Convert.ToInt32( s ) ).ToArray();
            CorreectnessAndTheLoopInvariantFunction( _ar );
        }

        private static void CorreectnessAndTheLoopInvariantFunction( int[] A ) {
            Array.Sort( A ); // Why all the hassle?
            Console.WriteLine( string.Join( " ", A ) );
        }
    }
}
