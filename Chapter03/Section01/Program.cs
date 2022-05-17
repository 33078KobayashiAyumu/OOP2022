using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main (string[] args) {
            var list = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 17 };


            var removeCount = list.RemoveAll (s => s.Contains("on"));
            Console.WriteLine (removeCount);
            list.ForEach (s => Console.WriteLine (s));
            // foreach(var s in names) {
            //Console.WriteLine (s);
            //}




            //foreach (var item in numbers.Where (n => n > 50)) ;
           // Console.WriteLine ();
        }
    }
}
