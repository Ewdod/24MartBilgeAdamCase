using Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public abstract class Book
    {
        public int BookId { get; set; }
        public string ISBN { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public DateTime ReleaseDate { get; set; }
        public abstract Status Status { get; set; }
    }
}
