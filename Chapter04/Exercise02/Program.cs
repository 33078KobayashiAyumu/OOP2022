using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main (string[] args) {
            //4-2-1
            var ymCollection = new YearMonth[] { 
                new YearMonth(1999,8),
                new YearMonth(2000,12),
                new YearMonth(2001,7),
                new YearMonth(2022,5),
                new YearMonth(2101,1),//(P103)最後のカンマはつけておく
            };


            //4-2-2
            Exercise2_2 (ymCollection);
            Console.WriteLine ("-------");

            //4-2-4
            Exercise2_4 (ymCollection);
            Console.WriteLine ("-------");

            //4-2-5
            Exercise2_5 (ymCollection);
            Console.WriteLine ("-------");

            //4-2-6
            Exercise2_6 (ymCollection);
        }

        private static void Exercise2_6 (YearMonth[] ymCollection) {
            //①月昇順 foreach (var ym in ymCollection.OrderBy(ym => ym.Month)) {
            //②偶数年昇順 foreach (var ym in ymCollection.Where (ym => ym.Year %2 == 0).OrderBy(ym => ym.Year )) {
            //③閏年
            foreach (var ym in ymCollection.Where(ym => DateTime.IsLeapYear(ym.Year))) {
                Console.WriteLine (ym);
            }
            // ④　12月に一番近い月
            var date = ymCollection.Max (ym => ym.Month);
            Console.WriteLine (date);
        }
        

        //4-2-3
        //最初に見つかった21世紀のおぶじぇくとを返す
        //見つからない場合はnullを返す
        static YearMonth FindFirst21C(YearMonth[] yms) {

            foreach (var ym in yms) {
                if (ym.Is21Century) {
                    return ym;
                }
            }
            return null;
        }


        private static void  Exercise2_2 (YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) {
                Console.WriteLine (ym);
            }

        }

        private static void Exercise2_4 (YearMonth[] ymCollection) {
            var yearmonth = FindFirst21C (ymCollection);

            if(yearmonth != null) {
                Console.WriteLine (yearmonth);
            }else {
                Console.WriteLine ("21世紀のデータはありません");
            }
        }

        private static void Exercise2_5 (YearMonth[] ymCollection) {
            var array =  ymCollection.Select (ym => ym.AddOneMonth ()).ToArray();
            foreach (var ym in array) {
                Console.WriteLine (ym);
            }
        }
    }
}
