using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            //確認
            var text = File.ReadAllText (newfile);
            Console.WriteLine (text);
        }

        private static void Exercise1_1 (string file) {
            var xdoc = XDocument.Load (file);
            var sport = xdoc.Root.Elements ()
                .Select (x => new{
                Name = (string)x.Element ("name"),
                Member = (int)x.Element ("teammembers")});
            foreach (var item in sport) {
                Console.WriteLine ("競技名：{0} 人数：{1}",item.Name,item.Member);
            }
        }

        private static void Exercise1_2 (string file) {
            var xdoc = XDocument.Load (file);
            var sport = xdoc.Root.Elements ().Select (x => new {
                Firstplayed = x.Element ("firstplayed").Value,
                Name = x.Element ("name").Attribute ("kanji").Value
            }).OrderBy (x => int.Parse (x.Firstplayed));
            
            foreach (var item in sport) {
                Console.WriteLine ("{0}{1}", item.Name, item.Firstplayed);
            }
        }

        private static void Exercise1_3 (string file) {
            var xdoc = XDocument.Load (file);
            var sport = xdoc.Root.Elements ().Select (x => new {
                Name = x.Element ("name").Value,
                Menber = x.Element ("teammembers").Value
            })  .OrderByDescending (x => int.Parse(x.Menber)).First();
                Console.WriteLine ("{0}{1}",sport.Name,sport.Menber);
        }

        private static void Exercise1_4 (string file, string newfile) {
            var element = new XElement ("ballsport",
                          new XElement ("name", "サッカー", new XAttribute ("kanji", "蹴球")),
                          new XElement ("teammembers", "11"),
                          new XElement ("firstplayed", "1863"));
            var xdoc = XDocument.Load (file);
            xdoc.Root.Add (element);
            xdoc.Save (newfile);
        }
    }
}
