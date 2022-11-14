using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MainShared;
using System.Linq;

namespace WpfApp
{
    public partial class MainWindow : Window
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

        public MainWindow()
        {
            InitializeComponent();
            foreach (var res in book)
            {
                AllElem.AppendText("\nНаименование: " + res.Name + " Автор: " + res.Author 
                    + " Цена: " + res.Price + " Страницы: " + res.Pages + " Дата релиза: " + res.ReleaseDate);
            }
        }
        

        //Buttons
        private void button_q1(object sender, EventArgs a)
        {
            clear_query();
            q1(book);
        }
        private void button_q2(object sender, EventArgs a)
        {
            clear_query();
            q2(book);
        }
        private void button_q3(object sender, EventArgs a)
        {
            clear_query();
            q3(book);
        }
        private void button_q4(object sender, EventArgs a)
        {
            clear_query();
            q4(book);           
        }
        private void button_q5(object sender, EventArgs a)
        {
            clear_query();
            q5(book);
        }
        private void button_q6(object sender, EventArgs a)
        {
            clear_query();
            q6(book);
        }
        private void button_q7(object sender, EventArgs a)
        {
            clear_query();
            q7(book, store);
        }




        //Methods
        private void clear_query()
        {
            QueryElems.Document.Blocks.Clear();
        }
        private void q1(Books[] book)
        {
            string s = TBAuthor.Text;
            var q = from b in book
                    where b.Author == s
                    select b;
            foreach (var res in q)
            {
                QueryElems.AppendText("\nНаименование: " + res.Name + " Автор: " + res.Author
                    + " Цена: " + res.Price + " Страницы: " + res.Pages + " Дата релиза: " + res.ReleaseDate);
            }
        }
        private void q2(Books[] book)
        {
            string s = TBDate.Text;
            var q = from b in book
                    where b.ReleaseDate == s
                    select b;
            foreach (var res in q)
            {
                QueryElems.AppendText("\nНаименование: " + res.Name);
            }
        }
        private void q3(Books[] book)
        {
            int begin = Convert.ToInt32(TBPriceStart.Text);
            int end = Convert.ToInt32(TBPriceEnd.Text);
            var q = from b in book
                    where (b.Price >= begin) && (b.Price <= end)
                    select b;
            int res = q.Count();
            QueryElems.AppendText("\n Количество: " + res);
        }
        private void q4(Books[] book)
        {
            int pages = Convert.ToInt32(TBPages.Text);
            var q = from b in book
                    where b.Pages > pages
                    select b;
            foreach (var res in q)
            {
                QueryElems.AppendText("\nАвтор: " + res.Author + " Наименование: " + res.Name);
            }
        }
        private void q5(Books[] book)
        {
            string s = TBAuthor.Text;
            var q = from b in book
                    where b.Author == s
                    select b.Price;
            var res = q.Average();
            QueryElems.AppendText("\n Стоимость книг в среднем: " + res);
        }
        private void q6(Books[] book)
        {
            var q = from b in book
                    group b by b.StoreID;
            foreach (var group in q)
            {
                foreach (var res in group)
                {
                    //MessageBox.Show("\nНаименование: " + res.Name + " Автор: " + res.Author + " Цена: " + res.Price + " Магазин: " + res.StoreID);
                    QueryElems.AppendText("\nНаименование: " + res.Name + " Автор: " + res.Author + " Цена: " + res.Price + " Магазин: " + res.StoreID);
                }
            }
        }
        private void q7(Books[] book, Store[] store)
        {
            var q = from b in book
                    join s in store on b.StoreID equals s.ID
                    select new
                    {
                        BookName = b.Name
                        ,
                        StorePower = s.Power
                    };
            foreach (var res in q)
            {
                QueryElems.AppendText("\nНаименование: " + res.BookName + " Количество полок: " + res.StorePower);
            }
        }
    }
}
