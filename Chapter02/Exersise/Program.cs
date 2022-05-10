using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersise {
    class Program {
        static void Main (string[] args) {

            var songs = new Song[] {
                new Song("a","f",1),
                new Song("b","g",2),
                new Song("c","h",3),
                new Song("d","i",4),
                new Song("e","j",5),
            };

            PrintSongs (songs);

        }

        private static void PrintSongs (Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine ("{0} {1}", song, songs);
            }
        }
    }
}
