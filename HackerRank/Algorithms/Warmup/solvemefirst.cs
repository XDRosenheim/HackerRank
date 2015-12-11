using System;

namespace HackerRank.Algorithms.Warmup
{
    public class Solvemefirst {
        public static int SolveMeFirst( int a, int b ) {
            // Hint: Type return a+b; below  
            return a + b;
        }

        public static void Solution( String[] args ) {
            int val1 = Convert.ToInt32( Console.ReadLine() );
            int val2 = Convert.ToInt32( Console.ReadLine() );
            int sum = SolveMeFirst( val1, val2 );
            Console.WriteLine( sum );
        }
    }
}
