﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelesCalculator {
    public class SalesCounter {
        private IEnumerable<Sale> _sales; // csvファイルから読み込んだデータ

        // こんすとらくた
        public SalesCounter (string filepath) {
            _sales = ReadSales(filepath);
        }
        
        //店舗別売り上げを求める
        public IDictionary<string,int> GetPerStoreSales () {
            Dictionary<string, int> dict = new Dictionary<string, int> ();
            foreach (Sale sale in _sales) {
                if (dict.ContainsKey (sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                    dict[sale.ShopName] = sale.Amount;
            }

            return dict;
        }

        //売り上げデータを読み込み、Saleオブジェクトのリストを返す
        public static IEnumerable<Sale> ReadSales (string filePath) {
            List<Sale> sales = new List<Sale> ();
            string[] lines = File.ReadAllLines (filePath);
            foreach (string line in lines) {
                String[] items = line.Split (',');
                Sale sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse (items[2])
                };
                sales.Add (sale);
            }

            return sales;
        }
    }
}
