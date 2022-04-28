﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelesCalculator {
    class Program {
        static void Main (string[] args) {

            var sales = new SalesCounter ("sales.csv");
            var amountPerStpre = sales.GetPerStoreSales ();
            foreach (var obj in amountPerStpre) {
                Console.WriteLine ("{0} {1}",obj.Key, obj.Value);
            }
        }


    }
}
