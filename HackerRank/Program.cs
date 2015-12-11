using System;
using System.Linq;

// ReSharper disable PossibleNullReferenceException
// ReSharper disable SuggestVarOrType_BuiltInTypes
// ReSharper disable ConvertToConstant.Local
// ReSharper disable SuggestVarOrType_Elsewhere
// ReSharper disable InconsistentNaming
// ReSharper disable BuiltInTypeReferenceStyle

namespace HackerRank {
    internal class Program {
        private static void Main( string[] args ) {
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
            TimeConversion();
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region Temp
            //();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
        }
        #region Easy
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
            string time = Console.ReadLine();
            string convertMe = "";
            for(int i = 0; i < 2; i++) {
                convertMe += time[i];
            }
            int hour = Convert.ToInt32( time.Substring( 0, 2 ) );
            string amORpm = time.Substring( time.Length - 2, 2 );
            if(amORpm == "PM" && convertMe != "12") {
                convertMe = ( hour + 12 ).ToString();
            }
            if(amORpm == "AM" && convertMe == "12") {
                convertMe = "00";
            }
            time = convertMe + time.Substring( 2, time.Length - 4 );
            Console.Write( time );
        }
        #endregion
        #endregion
    }
}
