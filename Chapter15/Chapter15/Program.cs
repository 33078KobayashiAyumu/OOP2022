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
                    foreach (var group in books.GroupBy(b=>b.PublishedYear).OrderBy(b=>b.Key)) {
                        Console.WriteLine ($"{group.Key}年");
                        foreach (var book in group) {
                            var category = Library.Categories.Where (b => b.Id == book.CategoryId).First ();
                            Console.WriteLine ($"   タイトル：{book.Title} 値段：{book.Price} カテゴリ：{category.Name}");
                        }
                    }

                    break;
                }
                years.Add (i);
            } 
        }
    }
}
