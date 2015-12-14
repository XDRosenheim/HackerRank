using System;

namespace HackerRank.Algorithms.Warmup {
    public class Timeconversion {
        public static void Solution() {
            Console.WriteLine( DateTime.Parse( Console.ReadLine() ).ToString( "HH:mm:ss" ) );
        }
    }
}
