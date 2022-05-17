using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercose02 {
    class Program {
        static void Main (string[] args) {
            var names = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            Exercise01 (names);
            Console.WriteLine ("-----------");

            Exercise01_2 (names);
            Console.WriteLine ("-----------");

            Exercise01_3 (names);
            Console.WriteLine ("-----------");

            Exercise01_4 (names);
            Console.WriteLine ("-----------");

        }
        private static void Exercise01 (List<string> names) {
            Console.WriteLine ("都市名を入力。空行で終了");

            do {
                var line = Console.ReadLine (); //入力
                if (string.IsNullOrEmpty (line)) {
                    
                    int index = names.FindIndex (n => n == line);
                    Console.WriteLine (index);
                    break;
                }
            } while (true);
        }
        private static void Exercise01_2 (List<string> names) {
            
        }
        private static void Exercise01_3 (List<string> names) {
            throw new NotImplementedException ();
        }

        private static void Exercise01_4 (List<string> names) {
            throw new NotImplementedException ();
        }
    }
}
