using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Catergory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}