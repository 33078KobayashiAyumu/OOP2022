using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main (string[] args) {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 17 };

            Exercise01 (numbers);
            Console.WriteLine ("-----------");

            Exercise01_2 (numbers);
            Console.WriteLine ("-----------");

            Exercise01_3 (numbers);
            Console.WriteLine ("-----------");

            Exercise01_4 (numbers);
            Console.WriteLine ("-----------");
        }

        

        private static void Exercise01 (List<int> numbers) {
            var exists = numbers.Exists (n => n % 8 == 0 || n % 9 == 0);
            if (exists) {
                Console.WriteLine ("存在している");
            }
            else {
                Console.WriteLine ("存在していない");
            }
        }

        private static void Exercise01_2 (List<int> numbers) {
            numbers.ForEach (n => Console.WriteLine (n / 2.0));
        }

        private static void Exercise01_3 (List<int> numbers) {
            foreach (var n in numbers.Where(n => n >= 50)) {
                Console.WriteLine (n);
            }
        }

        private static void Exercise01_4 (List<int> numbers) {
            var list = numbers.Select (n => n * 2);
            numbers[5] = 5000;
            foreach (var n in list) {
                Console.WriteLine (n);
            }
        }
    }
}
