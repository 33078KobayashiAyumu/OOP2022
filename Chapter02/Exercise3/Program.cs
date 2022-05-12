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
            Console.WriteLine ("売上高の表示選択");
            Console.WriteLine ("店舗別");
            Console.WriteLine ("商品カテゴリ別");
            Console.Write (">");

            select = int.Parse (Console.ReadLine ());
            IDictionary<string, int> amountPerStore = null;
            switch (select) {
                case 1:
                    amountPerStore = sales.GetPerStoreSales ();
                    break;
                case 2:
                    amountPerStore = sales.GetPerStoreSales ();
                    break;
            }

            foreach (var obj in amountPerStore) {
                Console.WriteLine ("{0} {1}", obj.Key, obj.Value);
            }
        }
    }
}
