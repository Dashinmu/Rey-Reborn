using System;
using System.Collections.Generic;
using System.Text;

namespace MainShared
{
    public class Books
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
        public string ReleaseDate { get; set; }
        public string StoreID { get; set; }
        public Books()
        {
            ID = "";
            Name = "";
            Author = "";
            Price = 0;
            Pages = 0;
            ReleaseDate = "";
            StoreID = "";
        }
    }
}
