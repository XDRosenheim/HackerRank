using System;
using System.Linq;

namespace HackerRank.Data_Structures.Arrays {
    public class _2Darrayds {
        public static void Solution() {
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
    }
}
