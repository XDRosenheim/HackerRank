using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation {
    class Angryprofessor {
        public static void Solution() {
            int t = Convert.ToInt32( Console.ReadLine() );
            for(int a0 = 0; a0 < t; a0++) {
                string[] tokens_n = Console.ReadLine().Split( ' ' );
                int n = Convert.ToInt32( tokens_n[0] );
                int k = Convert.ToInt32( tokens_n[1] );
                string[] a_temp = Console.ReadLine().Split( ' ' );
                int[] a = Array.ConvertAll( a_temp, Int32.Parse );
                bool classIsCancled = true;
                int arrivedToLate = 0, arrivedOnTime = 0;
                for(int i = 0; i < a.Length; i++) {
                    if(a[i] <= 0) {
                        arrivedOnTime++;
                    } else {
                        arrivedToLate++;
                    }
                }
                if(arrivedOnTime >= k) classIsCancled = false;
                Console.WriteLine( classIsCancled ? "YES" : "NO" );
            }
        }
    }
}
