using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IMember
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        List<Book> BooksBorrowed { get; set; }

        void BorrowBook(Book book);
        void ReturnBook(Book book);
    }
}
