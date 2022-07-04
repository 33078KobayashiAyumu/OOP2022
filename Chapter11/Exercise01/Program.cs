using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main (string[] args) {

            var file = "sample.xml";
            Exercise1_1 (file);
            Console.WriteLine ();
            Exercise1_2 (file);
            Console.WriteLine ();
            Exercise1_3 (file);
            Console.WriteLine ();

            var newfile = "sports.xml";
            Exercise1_4 (file, newfile);
        }

        private static void Exercise1_1 (string file) {
            var xdoc = XDocument.Load ("Sample.xml");
            var novelists = xdoc.Root.Elements ()
                .Select (x => new{
                Name = (string)x.Element ("name"),
                Member = (int)x.Element ("teammembers")});
            foreach (var item in novelists) {
                Console.WriteLine ("競技名：{0} 人数：{1}",item.Name,item.Member);
            }
        }

        private static void Exercise1_2 (string file) {
            var xdoc = XDocument.Load ("Sample.xml");
            var novelists = xdoc.Root.Elements ().Select (x => new {
                Year = (int)x.Element ("firstplayed"),
                kanji = x.Element("name").Elements("kanji")
        });
            
            foreach (var item in novelists) {
                Console.WriteLine ("{0}",item);
            }
        }

        private static void Exercise1_3 (string file) {
            
        }

        private static void Exercise1_4 (string file, string newfile) {
            
        }
    }
}
