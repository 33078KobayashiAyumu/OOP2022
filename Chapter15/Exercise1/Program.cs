using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main (string[] args) {
            Exercise1_2 ();
            Console.WriteLine ();
            Exercise1_3 ();
            Console.WriteLine ();
            Exercise1_4 ();
            Console.WriteLine ();
            Exercise1_5 ();
            Console.WriteLine ();
            Exercise1_6 ();
            Console.WriteLine ();
            Exercise1_7 ();
            Console.WriteLine ();
            Exercise1_8 ();

            Console.ReadLine ();
        }

        private static void Exercise1_2 () {
            var m = Library.Books.OrderByDescending(b=>b.Price).First();

            Console.WriteLine ($"{m}");
        }

        private static void Exercise1_3 () {

            var books = Library.Books.GroupBy(b=>b.PublishedYear).OrderBy(b=>b.Key);
            foreach (var i in books) {
                Console.Write ($"{i.Key}");
                foreach (var j in i) {
                    
                }
                Console.WriteLine ($": {i.Count ()}冊");
            }
        }

        private static void Exercise1_4 () {
            var books = Library.Books
                                .OrderByDescending (b => b.PublishedYear)
                                .ThenBy (b => b.Price)
                                .Join (Library.Categories,
                                    book => book.CategoryId,
                                    category => category.Id,
                                    (book, category) => new {
                                        Title = book.Title,
                                        Category = category.Name,
                                        PublishedYear = book.PublishedYear,
                                        Price = book.Price
                                    }
                                 );
            foreach (var book in books.OrderByDescending(b=>b.Price)) {
                Console.WriteLine ($"{book.PublishedYear} {book.Price} {book.Title} ({book.Category})");
            }
        }

        private static void Exercise1_5 () {
            var books = Library.Books
                              .Where (b => b.PublishedYear == 2016)
                              .Join (Library.Categories,
                                    book => book.CategoryId,
                                    category => category.Id,
                                    (book, category) => category.Name)
                              .Distinct ();
            foreach (var book in books) {
                Console.WriteLine (book);
            }
        }

        private static void Exercise1_6 () {
            var books = Library.Books
                                .OrderByDescending (b => b.Title)
                                .Join (Library.Categories,
                                    book => book.CategoryId,
                                    category => category.Id,
                                    (book, category) => new {
                                        Title = book.Title,
                                        Category = category.Name,
                                        PublishedYear = book.PublishedYear,
                                        Price = book.Price
                                    }
                                 );
            foreach (var i in books.GroupBy (b => b.Category).OrderBy (b => b.Key)) {
                Console.WriteLine ($"{i.Key}");
                foreach (var j in i) {
                    Console.WriteLine ($": {j.Title}");
                }
                
            }
        }

        private static void Exercise1_7 () {
            var books = Library.Books
                              .Where (b => b.CategoryId == 1)
                              .Join (Library.Categories,
                                    book => book.CategoryId,
                                    category => category.Id,
                                    (book, category) => new {
                                        Title = book.Title,
                                        PublishedYear = book.PublishedYear,
                                        category.Name });
            foreach (var i in books.GroupBy (b => b.PublishedYear).OrderBy (b => b.Key)) {
                Console.WriteLine ($"{i.Key}");
                foreach (var j in i) {
                    Console.WriteLine ($" {j.Title}");
                }

            }

        }

        private static void Exercise1_8 () {
            var groups = Library.Categories
                                .GroupJoin (Library.Books,
                                                c => c.Id,
                                                d => d.CategoryId,
                                                (c, books) => new {
                                                    Category = c.Name,
                                                    Count = books.Count (),
                                                });
            foreach (var obj in groups.Where(b=>b.Count>=4)) {
                Console.WriteLine ($"{obj.Category}");
            }

        }
    }
}
