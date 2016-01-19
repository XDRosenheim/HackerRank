using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank {
    internal class Program {
        private static void Main( string[] args ) {
            #region Algorythms -- WIP
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
            #region Implementation -- WIP
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
            #region 17. The Time in Words
            //theTimeInWords();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
            #region 19. Encryption -- WIP
            Encryption();
            Console.ReadKey();
            Console.Clear();
            #endregion
            #endregion
            #region Strings
            #region 1. Pangrams
            //Pangrams();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
            #region 2. Funny String
            //FunnyString();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
            #endregion
            #region Sorting
            #region Intro to Tutorial Challenges
            //IntrotoTutorialChallenges();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
            #region Insertion Sort - Part 1
            //InsertionSort();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
            #region Correctness and the Loop Invariant
            //CorrectnessAndTheLoopInvariant();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
            #endregion
            #endregion
            #region Data Structures
            #region Arrays
            #region Arrays-DS
            //ArraysDs();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
            #region 2D Arrays - DS
            //TwoDArrayDs();
            //Console.ReadKey();
            //Console.Clear();
            #endregion
            #endregion
            #endregion
        }
        #region Algorythms -- WIP
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
        #region Implementation -- WIP
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
        #region 17. The Time in Words
        private static void theTimeInWords() {
            dynamic h = Convert.ToInt32( Console.ReadLine() );
            var m = Convert.ToInt32( Console.ReadLine() );
            var singles = new[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "one" };
            var newh = singles[h - 1];
            var newhplus = singles[h];
            const string onTime = " o' clock";
            const string past = " past ";
            const string to = " to ";
            const string quater = "quater";
            const string half = "half";
            var output = "";
            switch(m) {
                case 00: output = newh + onTime; break;
                case 15: output = quater + past + newh; break;
                case 30: output = half + past + newh; break;
                case 45:
                newh = singles[h];
                output = quater + to + newh;
                break;
                case 01: output = "one minute" + past + newh; break;
                case 02: output = "two minutes" + past + newh; break;
                case 03: output = "three minutes" + past + newh; break;
                case 04: output = "four minutes" + past + newh; break;
                case 05: output = "five minutes" + past + newh; break;
                case 06: output = "six minutes" + past + newh; break;
                case 07: output = "seven minutes" + past + newh; break;
                case 08: output = "eight minutes" + past + newh; break;
                case 09: output = "nine minutes" + past + newh; break;
                case 10: output = "ten minutes" + past + newh; break;
                case 11: output = "eleven minutes" + past + newh; break;
                case 12: output = "twelve minutes" + past + newh; break;
                case 13: output = "thirteen minutes" + past + newh; break;
                case 14: output = "fourteen minutes" + past + newh; break;
                case 16: output = "sixteen minutes" + past + newh; break;
                case 17: output = "seventeen minutes" + past + newh; break;
                case 18: output = "eightteen minutes" + past + newh; break;
                case 19: output = "nineteen minutes" + past + newh; break;
                case 20: output = "twenty minutes" + past + newh; break;
                case 21: output = "twenty one minutes" + past + newh; break;
                case 22: output = "twenty two minutes" + past + newh; break;
                case 23: output = "twenty three minutes" + past + newh; break;
                case 24: output = "twenty four minutes" + past + newh; break;
                case 25: output = "twenty five minutes" + past + newh; break;
                case 26: output = "twenty six minutes" + past + newh; break;
                case 27: output = "twenty seven minutes" + past + newh; break;
                case 28: output = "twenty eight minutes" + past + newh; break;
                case 29: output = "twenty nine minutes" + past + newh; break;
                case 31: output = "twenty nine minutes" + to + newhplus; break;
                case 32: output = "twenty eight minutes" + to + newhplus; break;
                case 33: output = "twenty seven minutes" + to + newhplus; break;
                case 34: output = "twenty four minutes" + to + newhplus; break;
                case 35: output = "twenty five minutes" + to + newhplus; break;
                case 36: output = "thirty six minutes" + to + newhplus; break;
                case 37: output = "twenty three minutes" + to + newhplus; break;
                case 38: output = "twenty two minutes" + to + newhplus; break;
                case 39: output = "thirty nine minutes" + to + newhplus; break;
                case 40: output = "forthy minutes" + to + newhplus; break;
                case 41: output = "nineteen minutes" + to + newhplus; break;
                case 42: output = "eightteen minutes" + to + newhplus; break;
                case 43: output = "seventeen minutes" + to + newhplus; break;
                case 44: output = "sixteen minutes" + to + newhplus; break;
                case 46: output = "fourteen minutes" + to + newhplus; break;
                case 47: output = "thirteen minutes" + to + newhplus; break;
                case 48: output = "twelve minutes" + to + newhplus; break;
                case 49: output = "eleven minutes" + to + newhplus; break;
                case 50: output = "ten minutes" + to + newhplus; break;
                case 51: output = "nine minutes" + to + newhplus; break;
                case 52: output = "eight minutes" + to + newhplus; break;
                case 53: output = "seven minutes" + to + newhplus; break;
                case 54: output = "six minutes" + to + newhplus; break;
                case 55: output = "five minutes" + to + newhplus; break;
                case 56: output = "four minutes" + to + newhplus; break;
                case 57: output = "three minutes" + to + newhplus; break;
                case 58: output = "two minutes" + to + newhplus; break;
                case 59: output = "one minute" + to + newhplus; break;
            }
            Console.WriteLine( output );
        }
        #endregion
        #region 19. Encryption -- WIP
        private static void Encryption() {
            var input = Console.ReadLine().Replace( " ", string.Empty );
            var root = (int)Math.Sqrt( input.Length );
            var encryptedString = new string[root][];
            var counter = 0;
            for(var i = 0; i < root + 1; i++) {
                for(var j = 0; j < root; j++) {
                    encryptedString[i][j] = input.Substring( counter, 1 );
                    counter++;
                }
            }
            foreach(var s in encryptedString) {
                Console.WriteLine( s );
            }
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
        #region 2. Funny String - WIP
        private static void FunnyString() {
            var t = Convert.ToInt32( Console.ReadLine() );
            for(var tLoop = 0; tLoop < t; tLoop++) {
                var s = Console.ReadLine();
                var r_temp = s.ToCharArray();
                Array.Reverse( r_temp );
                var r = new string( r_temp );
                for(var i = 0; i < s.Length; i++) {

                }
            }
        }
        #endregion
        #endregion
        #region Sorting
        #region 1. Intro to Tutorial Challenges
        private static void IntrotoTutorialChallenges() {
            var v = Console.ReadLine();
            var n = Convert.ToInt32( Console.ReadLine() );
            var ar = Console.ReadLine().ToString().Split( ' ' );
            var index = Array.IndexOf( ar, v );
            Console.WriteLine( index );
        }
        #endregion
        #region 2. Insertion Sort - Part 1
        private static void InsertionSort() {
            int _ar_size;
            _ar_size = Convert.ToInt32( Console.ReadLine() );
            var _ar =new int[_ar_size];
            var elements = Console.ReadLine();
            var split_elements = elements.Split( ' ' );
            for(var _ar_i=0; _ar_i < _ar_size; _ar_i++) {
                _ar[_ar_i] = Convert.ToInt32( split_elements[_ar_i] );
            }
            InsertionSort( _ar );
        }

        private static void InsertionSort( int[] ar ) {
            // NOPE. This is stupid, I won't do it.
        }
        #endregion
        #region Correctness and the Loop Invariant
        private static void CorrectnessAndTheLoopInvariant() {
            Console.ReadLine();
            var _ar = ( from s in Console.ReadLine().Split() select Convert.ToInt32( s ) ).ToArray();
            CorreectnessAndTheLoopInvariantFunction( _ar );
        }

        private static void CorreectnessAndTheLoopInvariantFunction( int[] A ) {
            Array.Sort( A );
            Console.WriteLine( string.Join( " ", A ) );
        }

        #endregion
        #endregion
        #endregion
        #region Data Structures
        #region Arrays
        #region Arrays - DS
        private static void ArraysDs() {
            var n = Convert.ToInt32( Console.ReadLine() );
            var arrTemp = Console.ReadLine().Split( ' ' );
            var arr = Array.ConvertAll( arrTemp, int.Parse );
            for(var i = arr.Length - 1; i >= 0; i--) {
                Console.Write( arr[i] + " " );
            }
        }
        #endregion
        #region 2D Array - DS
        private static void TwoDArrayDs() {
            var arr = new int[6][];
            for(var arrI = 0; arrI < 6; arrI++) {
                var arrTemp = Console.ReadLine().Split( ' ' );
                arr[arrI] = Array.ConvertAll( arrTemp, int.Parse );
            }
            Console.WriteLine( CalcHourglass( arr ) );
        }

        private static int CalcHourglass( int[][] arr ) {
            var highest = 0;
            var first = false;
            var arrTemp = new int[7];
            for(var i = 0; i < 4; i++) {
                for(var j = 0; j < 4; j++) {
                    arrTemp[0] = arr[i][j];
                    arrTemp[1] = arr[i][j + 1];
                    arrTemp[2] = arr[i][j + 2];
                    arrTemp[3] = arr[i + 1][j + 1];
                    arrTemp[4] = arr[i + 2][j];
                    arrTemp[5] = arr[i + 2][j + 1];
                    arrTemp[6] = arr[i + 2][j + 2];
                    if(!first) {
                        first = true;
                        highest = arrTemp.Sum();
                    } else if(arrTemp.Sum() > highest) highest = arrTemp.Sum();
                }
            }
            return highest;
        }
        #endregion
        #endregion
        #endregion
    }
}
