using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

namespace WebAPIRc.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Self
        {
            get { return string.Format(CultureInfo.CurrentCulture, "api/books/{0}", this.Id); }
            set { }
        }
    }
}