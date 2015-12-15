using System;
using System.Collections.Generic;

namespace HackerRank.Algorithms.strings {
    public class Pangrams {
        public static void Solution() {
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
    }
}
