using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Book
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        //Creating constructor to initialize BookName and AuthorName
        public Book(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }
        //Method to display name of the book and their author
        public void Display()
        {
            Console.WriteLine("Name of the book is:" + BookName);
            Console.WriteLine("Name of the Auther is:" + AuthorName);
        }
    }
    class BookSelf
    {
        //Creating List to store books
        private List<Book> books = new List<Book>();

        //Method to add a book to the list
        public void AddBook( Book book)
        {
            books.Add(book);
        }
        //Method to Display the Details of all Books in the list
        public void DisplayBooks()
        {
            int i = 1;
            foreach (var book in books) 
                {
                    Console.WriteLine($"Book:{i}");
                    book.Display();
                    i++;
                    Console.WriteLine();
                }
        }
    }
    class Program_Books
    {
        static void Main(string[] args)
        {
            BookSelf b = new BookSelf();
            
            //Loop for taking user input of book details and add them to the bookself
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter the details for books {i+1}:");
                Console.WriteLine("Enter the Book name:");
                string bookName = Console.ReadLine();
                Console.WriteLine("Enter the Auther name:");
                string authorName = Console.ReadLine();
                
                //Create a new book object and add it to the bookself
                Book book = new Book(bookName, authorName);
                b.AddBook(book);
            }
            //Displaying all the Boooks....
            Console.WriteLine("Contents of Bookself are: ");
            b.DisplayBooks();
            Console.ReadLine();
        }
    }
}
