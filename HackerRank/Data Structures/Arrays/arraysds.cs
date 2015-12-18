using System;

namespace HackerRank.Data_Structures.Arrays {
    public class Arraysds {
        public static void Solution() {
            var n = Convert.ToInt32( Console.ReadLine() );
            var arrTemp = Console.ReadLine().Split( ' ' );
            var arr = Array.ConvertAll( arrTemp, int.Parse );
            for(var i = arr.Length - 1; i >= 0; i--) {
                Console.Write( arr[i] + " " );
            }
        }
    }
}
