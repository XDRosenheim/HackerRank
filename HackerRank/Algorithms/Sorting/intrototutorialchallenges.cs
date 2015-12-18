using System;

namespace HackerRank.Algorithms.Sorting {
    public class Intrototutorialchallenges {
        public static void Solution()
        {
            var v = Console.ReadLine();
            var n = Convert.ToInt32( Console.ReadLine() ); // Used for nothing, as it is not needed.
            var ar = Console.ReadLine().ToString().Split( ' ' );
            var index = Array.IndexOf( ar, v );
            Console.WriteLine( index );
        }
    }
}
