using System;

namespace HackerRank.Algorithms.Warmup {
    public class Timeconversion {
        public static void TimeConversion() {
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
    }
}
