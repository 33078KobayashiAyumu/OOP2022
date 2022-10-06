using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
    class Program {
        static void Main (string[] args) {

            //var years = new int[] { 2013, 2016 };
            var years = new List<int>();

            var books = Library.Books.Where (b => years.Contains (b.PublishedYear));
            Console.WriteLine ("西暦を入力 (終了-1)");
            for ( ; ; ) {
                int i = int.Parse (Console.ReadLine ());
                
                if (i == -1) {
                    Console.WriteLine ("昇順：1　降順：2　");
                    i = int.Parse (Console.ReadLine ());
                    if (i == 1) {
                        foreach (var book in books.OrderBy (b => b.PublishedYear)) {

                            Console.WriteLine (book);

                        }
                    } 
                    else if(i == 2){
                        foreach (var book in books.OrderByDescending (b => b.PublishedYear)) {

                            Console.WriteLine (book);

                        }
                    } else {
                        break;
                    }

                    Console.WriteLine ();
                    var selected = Library
                        .Books.Where (b => years.Contains (b.PublishedYear))
                        .OrderBy (b => b.PublishedYear)
                        .ThenBy (b => b.CategoryId)
                        .Join (Library.Categories,//結合する2番目のシーケンス
                             book => book.CategoryId,//対象シーケンスの結合キー
                             category => category.Id,//２番目のシーケンスの結合キー
                             (book, category) => new {
                                 Title = book.Title,
                                 Category = category.Name,
                                 PublichedYear = book.PublishedYear,
                                 price = book.Price
                             }); 

                    foreach (var book in selected .OrderByDescending(x=>x.PublichedYear).ThenBy(x=>x.Category)){
                        //Console.Write ($"{book.PublichedYear}年");
                        //var category = Library.Categories.Where (b => b.Id == book.CategoryId).First ();
                        Console.WriteLine ($"出版年：{book.PublichedYear} タイトル：{book.Title} カテゴリ：{book.Category} {book.price}円 ");
                    }
                    Console.WriteLine ($"書籍の金額の合計 {selected.Sum(b=>b.price)}円");
                    break;
                }
                years.Add (i);
            } 
        }
    }
}
