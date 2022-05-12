using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3 {
    class Program {
        static void Main (string[] args) {
            int select = 0;
            var sales = new SalesCounter ("sales.csv");
            IDictionary<string, int> amountPerStore = null;

            while (true) {
                Console.WriteLine ("売上高の表示選択");
                Console.WriteLine ("店舗別");
                Console.WriteLine ("商品カテゴリ別");
                Console.Write (">");

                select = int.Parse (Console.ReadLine ());

                switch (select) {
                    case 1:
                        amountPerStore = sales.GetPerStoreSales ();
                        break;
                    case 2:
                        Output (sales.GetPerCategorySales ());
                        break;

                    case 999:
                        return;
                }

                
            }
        }

        private static void Output (IDictionary<string, int> amountPerStore) {
            foreach (var obj in amountPerStore) {
                Console.WriteLine ("{0} {1}", obj.Key, obj.Value);
            }
        }
    }
}
