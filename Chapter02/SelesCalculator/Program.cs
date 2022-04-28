using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelesCalculator {
    class Program {
        static void Main (string[] args) {

            SalesCounter sales = new SalesCounter ("sales.csv");
            Dictionary<string, int> amountPerStpre = sales.GetPerStoreSales ();
            foreach (KeyValuePair<string,int> obj in amountPerStpre) {
                Console.WriteLine ("{0} {1}",obj.Key, obj.Value);
            }

        }


    }
}
