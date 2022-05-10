using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersise {
    class Program {
        static void Main (string[] args) {

            var songs = new Song[] {
                new Song("a","f",100),
                new Song("b","g",200),
                new Song("c","h",300),
                new Song("d","i",400),
                new Song("e","j",500),
            };

            PrintSongs (songs);

        }

        private static void PrintSongs (IEnumerable<Song> songs) {
            foreach (var song in songs) {
                Console.WriteLine ("{0} {1}　{2:m\\:ss}", song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));;
            }
        }
    }
}
