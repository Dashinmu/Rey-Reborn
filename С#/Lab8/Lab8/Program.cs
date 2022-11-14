using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using MainShared;

namespace Lab8
{
    class Program
    {
        static void q1 (Books[] book)
        {
            Console.WriteLine("Query 1");
            string s = "Kaban";
            var q = from b in book
                     where (b.Author == s)
                     select b;
            foreach (var res in q)
            {
                Console.WriteLine("ID: {0}\n + Наименование: {1}\n + Автор: {2}\n + Цена: {3}\n + Страницы: {4}\n Дата релиза: {5}\n + Магазин: {6}\n"
                                    , res.ID, res.Name, res.Author, res.Price, res.Pages, res.ReleaseDate, res.StoreID);
            }
            Console.WriteLine("--------------------------------------------------------------");
        }

        static void q2 (Books[] book)
        {
            Console.WriteLine("Query 2");
            string s = "19.10.2022";
            var q = from b in book
                    where (b.ReleaseDate == s)
                    select b;
            foreach (var res in q)
            {
                Console.WriteLine("Наименование: {0}\n", res.Name);
            }
            Console.WriteLine("--------------------------------------------------------------");
        }

        static void q3 (Books[] book)
        {
            Console.WriteLine("Query 3");
            int begin = 100;
            int end = 1000;
            var q = from b in book
                    where (b.Price >= begin) && (b.Price <= end)
                    select b;
            int res = q.Count();
            Console.WriteLine(res);
            Console.WriteLine("--------------------------------------------------------------");
        }
        
        static void q4 (Books[] book)
        {
            Console.WriteLine("Query 4");
            int pages = 100;
            var q = from b in book
                    where (b.Pages > pages)
                    select b;
            foreach (var res in q)
            {
                Console.WriteLine("Автор: {0}  -  Наименование: {1}\n", res.Author, res.Name);
            }
            Console.WriteLine("--------------------------------------------------------------");
        }

        static void q5 (Books[] book)
        {
            Console.WriteLine("Query 5");
            string s = "Kaban";
            var q = from b in book
                    where (b.Author == s)
                    select b.Price;
            Console.WriteLine(q.Average());
            Console.WriteLine("--------------------------------------------------------------");
        }

        static void q6 (Books[] book)
        {
            Console.WriteLine("Query 6");
            //string id = "01";
            var q = from b in book
                    group b by b.StoreID;
            foreach (var group in q)
            {
                foreach (var res in group)
                {
                    Console.WriteLine("ID: {0}\n + Наименование: {1}\n + Автор: {2}\n + Цена: {3}\n + Страницы: {4}\n Дата релиза: {5}\n + Магазин: {6}\n"
                                       , res.ID, res.Name, res.Author, res.Price, res.Pages, res.ReleaseDate, res.StoreID);
                }
            }
            Console.WriteLine("--------------------------------------------------------------");
        }

        static void q7 (Books[] book, Store[] store)
        {
            Console.WriteLine("Query 7");
            var q = from b in book
                    join s in store on b.StoreID equals s.ID
                    select new
                    {
                        BookName = b.Name
                        , StorePower = s.Power
                    };
            foreach (var res in q)
            {
                Console.WriteLine("Наименование: {0}  -  Количество полок: {1}\n", res.BookName, res.StorePower);
            }
            Console.WriteLine("--------------------------------------------------------------");
        }

        static void Main(string[] args)
        {
            Books[] book = new[]
            {
                new Books
                {
                    ID = "01"
                    , Name = "How to play Path Of Exile?"
                    , Author = "Kaban"
                    , Price = 500
                    , Pages = 500
                    , ReleaseDate = "19.08.2022"
                    , StoreID = "01"
                }
                , new Books
                {
                    ID = "02"
                    , Name = "Fallout76 is shit?"
                    , Author = "Yzpoo&Dashinmu"
                    , Price = 5000
                    , Pages = 6
                    , ReleaseDate = "19.10.2022"
                    , StoreID = "01"
                }
                , new Books
                {
                    ID = "10"
                    , Name = "Apple & Pen"
                    , Author = "Кореец"
                    , Price = 100
                    , Pages = 2
                    , ReleaseDate = "19.08.2019"
                    , StoreID = "02"
                }
                , new Books
                {
                    ID = "777"
                    , Name = "Как не умирать в Fallout3, если мобы титановые"
                    , Author = "Kaban"
                    , Price = 200
                    , Pages = 500
                    , ReleaseDate = "19.10.2022"
                    , StoreID = "01"
                }
            };

            Store[] store = new[]
            {
                new Store
                {
                    ID = "01"
                    , Power = 100
                    , Name = "Vesta"
                }
                , new Store
                {
                    ID = "02"
                    , Power = 100
                    , Name = "Jeta"
                }
            };

            q1(book);
            q2(book);
            q3(book);
            q4(book);
            q5(book);
            q6(book);
            q7(book, store);

            Console.ReadKey();
        }
    }
}
