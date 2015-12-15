using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

// ReSharper disable CompareOfFloatsByEqualityOperator

namespace HackerRank {
    internal class Program {
        private static void Main( string[] args ) {
            #region Warmup
            #region 1. Solve Me First
            //SolveMeFirst();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
            #region 2. Simple Array Sum
            //SimpleArraySum();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
            #region 3. A Very Big Number
            //AVeryBigNumber();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
            #region 4. Diagonal Difference
            //DiagonalDifference();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
            #region 5. Plus Minus
            //PlusMinus();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
            #region 6. Staircase
            //Staircase();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
            #region 7. Time Conversion
            //TimeConversion();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
            #endregion
            #region Implementation
            #region 1. Angry Professor
            //angryProfessor();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
            #region 3. The Utopian Tree
            //UtopianTree();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
            #region 4. Find Digits
            //FindDigits();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
            #region 5. Sherlock and Squares
            //SherlockAndSquares();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
            #endregion
            #region Strings
            #region 1. Pangrams
            Pangrams();
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region 2. Funny String
            FunnyString();
            Console.ReadKey();
            Console.Clear();
            #endregion
            #endregion
            #region
            //();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
        }
        #region Warmup
        #region 1. Solve Me First
        private static void SolveMeFirst() {
            var val1 = Convert.ToInt32( Console.ReadLine() );
            var val2 = Convert.ToInt32( Console.ReadLine() );
            var sum = SolveMeFirst( val1, val2 );
            Console.WriteLine( sum );
        }
        private static int SolveMeFirst( int a, int b ) {
            // Solution
            return a + b;
        }
        #endregion
        #region 2. Simple Array Sum
        private static void SimpleArraySum() {
            int n = Convert.ToInt32( Console.ReadLine() );
            var arrTemp = Console.ReadLine().Split( ' ' );
            var arr = Array.ConvertAll( arrTemp, int.Parse );
            // Solution
            Console.WriteLine( arr.Sum() );
        }
        #endregion
        #region 3. A Very Big Number
        private static void AVeryBigNumber() {
            var arrTemp = Console.ReadLine().Split( ' ' );
            // Solution - Changeint to long & Int32 to Int64
            //int[] arr = Array.ConvertAll( arrTemp, Int32.Parse );
            long[] arr = Array.ConvertAll( arrTemp, Int64.Parse );
            long sum = arr.Sum();
            Console.Write( sum );
        }
        #endregion
        #region 4. Diagonal Difference
        private static void DiagonalDifference() {
            int n = Convert.ToInt32( Console.ReadLine() );
            int[][] a = new int[n][];
            for(int i = 0; i < n; i++) {
                string[] a_temp = Console.ReadLine().Split( ' ' );
                a[i] = Array.ConvertAll( a_temp, Int32.Parse );
            }
            // Solution
            int dia1 = 0;
            int dia2 = 0;
            for(int i = 0; i < n; i++) dia1 += a[i][i];
            for(int i = 1; i <= n; i++) dia2 += a[n - i][i - 1];
            Console.Write( Math.Abs( dia1 - dia2 ) );
        }
        #endregion
        #region 5. Plus Minus
        private static void PlusMinus() {
            int n = Convert.ToInt32( Console.ReadLine() );
            string[] arr_temp = Console.ReadLine().Split( ' ' );
            int[] arr = Array.ConvertAll( arr_temp, Int32.Parse );
            decimal positive = 0, negative = 0, zero = 0;
            int decimalplaces = 6;
            foreach(var i in arr) {
                if(i == 0) zero++;
                else if(i > 0) positive++;
                else if(i < 0) negative++;
            }
            Console.WriteLine( Math.Round( Convert.ToDecimal( positive / n ), decimalplaces ) );
            Console.WriteLine( Math.Round( Convert.ToDecimal( negative / n ), decimalplaces ) );
            Console.WriteLine( Math.Round( Convert.ToDecimal( zero / n ), decimalplaces ) );
        }
        #endregion
        #region 6. Staircase
        private static void Staircase() {
            int n = Convert.ToInt32( Console.ReadLine() );
            // Solution - Build a staircase
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n - ( i + 1 ); j++) { Console.Write( "G" ); }
                for(int j = n - i; j <= n; j++) { Console.Write( "#" ); }
                Console.WriteLine( "" );
            }
        }
        #endregion
        #region 7. Time Conversion
        private static void TimeConversion() {
            Console.WriteLine( DateTime.Parse( Console.ReadLine() ).ToString( "HH:mm:ss" ) );
        }
        #endregion
        #endregion
        #region Implementation
        #region 1. Angry Professor
        private static void angryProfessor() {
            int t = Convert.ToInt32( Console.ReadLine() );
            for(int a0 = 0; a0 < t; a0++) {
                string[] tokens_n = Console.ReadLine().Split( ' ' );
                int n = Convert.ToInt32( tokens_n[0] );
                int k = Convert.ToInt32( tokens_n[1] );
                string[] a_temp = Console.ReadLine().Split( ' ' );
                int[] a = Array.ConvertAll( a_temp, Int32.Parse );
                bool classIsCancled = true;
                int arrivedToLate = 0, arrivedOnTime = 0;
                foreach(int t1 in a) {
                    if(t1 <= 0) {
                        arrivedOnTime++;
                    } else {
                        arrivedToLate++;
                    }
                }
                if(arrivedOnTime >= k) classIsCancled = false;
                Console.WriteLine( classIsCancled ? "YES" : "NO" );
            }
        }
        #endregion
        #region 3. The Utopian Tree
        private static void UtopianTree() {
            var t = Convert.ToInt32( Console.ReadLine() );
            for(var a0 = 0; a0 < t; a0++) {
                var cycles = Convert.ToInt32( Console.ReadLine() );
                var height = 1;
                for(var i = 0; i < cycles; i++) {
                    if(i % 2 != 0 || i == 0) {
                        height++;
                    } else {
                        height *= 2;
                    }
                }
                Console.WriteLine( height );
            }
        }
        #endregion
        #region 4. Find Digits
        private static void FindDigits() {
            var t = Convert.ToInt32( Console.ReadLine() );
            for(var a0 = 0; a0 < t; a0++) {
                var Ns = Console.ReadLine();
                var n = Convert.ToInt32( Ns );
                var result = Ns.Select( t1 => Convert.ToInt32( "" + t1 ) ).Count( x => x != 0 && n % x == 0 );
                Console.WriteLine( result );
            }
        }
        #endregion
        #region 5. Sherlock and Squares
        private static void SherlockAndSquares() {
            var t = Convert.ToInt32( Console.ReadLine() );
            for(var a0 = 0; a0 < t; a0++) {
                var readLine = Console.ReadLine();
                if(readLine == null) continue;
                var tokens = readLine.Split( ' ' );
                var a = Convert.ToInt32( tokens[0] );
                var b = Convert.ToInt32( tokens[1] );
                if(Math.Sqrt( a ) % 1 != 0) Console.WriteLine( ( (int)Math.Sqrt( a ) - (int)Math.Sqrt( b ) ) * -1 );
                else Console.WriteLine( (int)Math.Sqrt( a ) - Math.Sqrt( b ) - 1 );
            }
        }

        #endregion
        #region
        private static void temp() {

        }
        #endregion
        #endregion
        #region Strings
        #region 1. Pangrams
        private static void Pangrams() {
            var s = Console.ReadLine().ToLower().Replace( " ", string.Empty ).Replace( ".", string.Empty ).Replace( ",", string.Empty ).Replace( "-", string.Empty );
            var a = new List<string>();
            if(s.Length >= 26) {
                for(var i = 0; i < s.Length; i++) {
                    if(!a.Contains( s.Substring( i, 1 ) )) {
                        a.Add( s.Substring( i, 1 ) );
                    }
                }
                Console.WriteLine( a.Count == 26 ? "pangram" : "not pangram" );
            } else {
                Console.WriteLine( "not pangram" );
            }
        }
        #endregion
        #region 2. Funny String
        private static void FunnyString() {
            var t = Convert.ToInt32( Console.ReadLine() );
            for(var tLoop = 0; tLoop < t; tLoop++) {
                var s = Console.ReadLine();
                for(var i = 0; i < s.Length; i++) {
                }
            }
        }
        #endregion
        #endregion
    }
}
