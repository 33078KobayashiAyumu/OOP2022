using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main (string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1 (text);
            Console.WriteLine ("-----");

            Exercise3_2 (text);
            Console.WriteLine ("-----");

            Exercise3_3 (text);
            Console.WriteLine ("-----");

            Exercise3_4 (text);
            Console.WriteLine ("-----");

            Exercise3_5 (text);
        }

        private static void Exercise3_1 (string text) {
            var spaces = text.Count (c => c == ' ');
            Console.WriteLine ("空白数：{0}", spaces);
        }

        private static void Exercise3_2 (string text) {
            var change = text.Replace ("big", "small");
            Console.WriteLine (change);
        }

        private static void Exercise3_3 (string text) {
            var words = text.Split (' ');
               Console.WriteLine("{0}",words.Length);
        }

        private static void Exercise3_4 (string text) {
            var words = text.Split (' ');
            foreach (var tx in words.Where(c => c.Length <= 4)) {
                Console.WriteLine (tx);
            }
        }

        private static void Exercise3_5 (string text) {
            var words = text.Split (' ');
            var sb = new StringBuilder ();

            foreach (var tx in words) {
                sb.Append (tx + " ");
            }
            Console.WriteLine (sb);
        }
    }
}
