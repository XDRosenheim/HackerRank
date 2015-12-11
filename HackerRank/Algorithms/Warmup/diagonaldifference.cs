using System;

namespace HackerRank.Algorithms.Warmup {
    public class Diagonaldifference {
        public static void Solution() {
            int n = Convert.ToInt32( Console.ReadLine() );
            int[][] a = new int[n][];
            for(int i = 0; i < n; i++) {
                string[] aTemp = Console.ReadLine().Split( ' ' );
                a[i] = Array.ConvertAll( aTemp, Int32.Parse );
            }
            int dia1 = 0;
            int dia2 = 0;
            for(int i = 0; i < n; i++) dia1 += a[i][i];
            for(int i = 1; i <= n; i++) dia2 += a[n - i][i - 1];
            Console.Write( Math.Abs( dia1 - dia2 ) );
        }
    }
}
