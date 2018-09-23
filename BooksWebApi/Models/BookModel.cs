using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksWebApi.Models
{
    public class BookModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int Edition { get; set; }
        public int Year { get; set; }
        public decimal? Price { get; set; }
        public string ISBN { get; set; }
    }
}