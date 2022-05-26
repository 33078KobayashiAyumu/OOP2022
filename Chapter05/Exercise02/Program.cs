using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main (string[] args) {
            var inp = Console.ReadLine ();

            if (int.TryParse(inp,out var parse)) {

                Console.WriteLine ("{0:N}",parse);
            }else {
                Console.WriteLine ("失敗");
            }
        }
    }
}
