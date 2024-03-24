using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Enums;

namespace Library.Entities
{
    public class Member : IMember
    {
        public int MemberId { get; set; }
        public string Name { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public List<Book> BooksBorrowed { get; set; } = new();

        public void BorrowBook(Book book) { }
        public void ReturnBook(Book book) { }
    }
}
