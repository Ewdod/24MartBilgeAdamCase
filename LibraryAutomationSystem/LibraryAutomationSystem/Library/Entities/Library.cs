using Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Library
    {
        private List<Book> _books;
        private List<Member> _members;
        public Library()
        {
            _books = new List<Book>();
            _members = new List<Member>();
        }

        public void BookBorrow(Member member, int bookId)
        {
            Book book = _books.Find(x => x.BookId == bookId);

            if (book != null && book.Status == Status.Available)
            {
                member.BooksBorrowed.Add(book);
                book.Status = Status.Borrowed;

                Console.WriteLine("Kitap başarıyla ödünç alındı!");
            }
            else
            {
                if (book == null)
                {
                    Console.WriteLine("Kitap bulunamadı!");
                }
                else if (book.Status != Status.Available)
                {
                    Console.WriteLine("Kitap ödünç alınamaz durumda!");
                }
            }
        }

        public void BookRefund(Member member, int bookId)
        {
            Book book = _books.Find(x => x.BookId == bookId);

            if (book != null && member.BooksBorrowed.Contains(book))
            {
                member.BooksBorrowed.Remove(book);
                book.Status = Status.Available;

                Console.WriteLine("Kitap başarıyla iade edildi!");
            }
            else
            {
                if (book == null)
                {
                    Console.WriteLine("Kitap bulunamadı!");
                }
                else
                {
                    Console.WriteLine("Kitap üye tarafından ödünç alınmamış!");
                }
            }
        }
    }
}
