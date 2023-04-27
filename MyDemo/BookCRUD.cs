using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyDemo.BookLibrary;

namespace MyDemo
{
    internal class BookCRUD
    {
        public class Program
        {
            static void Main(String[] args)
            {
                BookCRUD db=new BookCRUD();
                int op = 0;
                do
                {
                    Console.WriteLine("1.Add Book");
                    Console.WriteLine("2.Update Book");
                    Console.WriteLine("3.Delete Book");
                    Console.WriteLine("4.View All");
                    Console.WriteLine("5.View by Book_id");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                              Book b=new Book();
                              Console.WriteLine("Enter BookId");
                              b.Book_Id = Convert.ToInt32(Console.ReadLine());
                              Console.WriteLine("Enter Title");
                             b.Title = Console.ReadLine();
                             Console.WriteLine("Enter Price");
                            b.Price=Convert.ToInt32(Console.ReadLine());
                            db = AddBook(b);
                            break;

                        case 2:
                            Book b1 = new Book();
                            Console.WriteLine("Enter Bookid");
                            b1.Book_Id=Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Title");
                            b1.Title = Console.ReadLine();
                            Console.WriteLine("Enter price");
                            b1.Price=Convert.ToInt32(Console.ReadLine());
                            db.UpdateBook(b1);
                            break;
                        case 3:
                            Console.WriteLine("Ente BookId");
                            int book_id=Convert.ToInt32(Console.ReadLine());
                            db.DeleteBook(book_id);
                            break;

                        case 4:
                            List<Book> list = db.GetBooks();
                            Console.WriteLine("Book_id \t Title \t Price");
                            foreach(Book item in list)
                            {
                                Console.WriteLine($"{item.Book_Id} \t {item.Title} \t {item.Price}");
                            }
                            break;

                        case 5:
                            Console.WriteLine("Enrter Book id");
                            int book_id2=Convert.ToInt32(Console.ReadLine());
                            Book item2 = db.GetBookById(book_id2);
                            Console.WriteLine("Book_Id \t Title \t price");
                            Console.WriteLine($"{item2.Book_Id} \t {item2.Title} \t {item2.Price}");
                            break;
                        default:
                            Console.WriteLine("No option available");
                            break;
                    }   
                }while(op == 1);
            }

            private static BookCRUD AddBook(Book b)
            {
                throw new NotImplementedException();
            }
        }

        private Book GetBookById(int book_id2)
        {
            throw new NotImplementedException();
        }

        private List<Book> GetBooks()
        {
            throw new NotImplementedException();
        }

        private void DeleteBook(int book_id)
        {
            throw new NotImplementedException();
        }

        private void UpdateBook(Book b1)
        {
            throw new NotImplementedException();
        }
    }
}
