using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    internal class BookLibrary
    {
        public class Book
        {
            internal int Book_Id;

            public int Book_id { get; set; }
            public string Title { get; set; }
            public int Price { get; set; }
        }
       public class BookCRUD
        {
            private List<Book> books;
            public BookCRUD()
            {
                books = new List<Book>();
            }
            public void AddBook(Book bk)
            {
                books.Add(bk);
            }
            public void UpdateBook(Book bk)
            {
                foreach (Book b in books)
                {
                    if(b.Book_id==bk.Book_id)
                    {
                        b.Title = bk.Title;
                        b.Price = bk.Price;
                    }
                }
            }
            public List<Book> GetBooks()
            {
                return books;
            }
            public Book GetBookById(int id)
            {
                Book bk = new Book();
                foreach(Book b in books)
                {
                    if(b.Book_id==id)
                    {
                        bk = b;
                        break;
                    }
                }
                return bk;
            }
        }
    }
}
