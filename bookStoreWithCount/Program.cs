using System;

namespace bookStore
{
    class Book
    {
        private static int _transactions = 0;
        private string _bookCount;

        public void SetTrans()
        {
            _transactions++;
        }
        public void SetBooks(String booCount)
        {
            _bookCount = booCount;
        }
        public int GetTrans()
        {
            return _transactions;
        }
        public string Getbooks()
        {
            return _bookCount;
        }

    //----------------------------------------------
        private int _Id;  
        private string _Title; 
        private string _Author;  

        //Default Constructor
        public Book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }

        //Parameterized Constructor
        public Book(int i, string Title, string Author)
        {
            _Id = i;
            _Title = Title;
            _Author = Author;
        }
        //Get Methods

        public int GetId()
        {
            return _Id;
        }
        public string GetTitle()
        {
            return _Title;
        }
        public string GetAuthor()
        {
            return _Author;
        }
        //Set Methods
        public void SetId(int identification)
        {
            _Id = identification;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }
    }

    class myStore
    {
        static void Main(string[] args)
        {
            //book object w/ default constructor
            Book book1 = new Book();
            book1.SetTrans();
            book1.SetId(1);
            book1.SetTitle("Midnight Library");
            book1.SetAuthor("Matt Haig");
            printTransaction(book1);
            
            //book object w/ default constructor (prompt user)
            Book book2 = new Book();
            book2.SetTrans();
            Console.WriteLine("Please enter the ID: ");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the title of the book:");
            book2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the author of the book:");
            book2.SetAuthor(Console.ReadLine());
            printTransaction(book2);

            //book object w/ parameterized constructor
            Book book3 = new Book(3, "Project Hail Mary", "Andy Weir");
            book3.SetTrans();
            printTransaction(book3);

            //book object w/ parameterized constructor (prompt user)
            Console.WriteLine("Please enter the ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the title of the book: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the author of the book: ");
            string tempAuthor = Console.ReadLine();
            Book book4 = new Book(tempID, tempTitle, tempAuthor);
            book4.SetTrans();
            printTransaction(book4);

            //Call books
            Console.WriteLine($"The book store has {book1.GetTrans()} new books");
            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);
            displayBooks(book4);
            Console.ReadKey();

        }
        //Name the method displayBooks

        static void displayBooks(Book book)
        {
            Console.WriteLine("Here's the book's information");
            Console.WriteLine($"Book ID: {book.GetId()}");
            Console.WriteLine($"Book Title: {book.GetTitle()}");
            Console.WriteLine($"Book Author: {book.GetAuthor()}");
            Console.WriteLine($"Press any key to see the next book...");
            Console.ReadKey();
        }
        static void printTransaction(Book b)
        {
            Console.WriteLine($"Transactions={b.GetTrans()}");
        }
    }
}
