using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebAPIRc.Models
{
    public class BookInitializer : DropCreateDatabaseIfModelChanges<BookStore>
    {
        protected override void Seed(BookStore storeContext)
        {
            storeContext.Books.Add(new Book() { Name = "MVC4 RC Early Release", Price = 220 });
            storeContext.Books.Add(new Book() { Name = "Entity FrameWork", Price = 350M });
            storeContext.Books.Add(new Book() { Name = "Azure Getting Started", Price = 540M });
            
        }
    }
}