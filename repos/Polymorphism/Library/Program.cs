using System;


public class Book: IBorrowable
{
    private string title;
    private string author;
    private bool isAvailable = true;

    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; }

    public Book(string title, string author, bool isAvailable=true)
    {
        Title = title;
        Author = author;
        IsAvailable = isAvailable;
    }

    public virtual void DisplayDetails()
    {
        string avaiable = IsAvailable ? "Yes" : "No";
        Console.WriteLine("Title:{0}, Author:{1}, Available:{2}", Title, Author, avaiable);
    }
    public void Borrow()
    {
        if(isAvailable)
        {
            Console.WriteLine("The book - {0} can be borrowed", Title);
            IsAvailable = false;
        }
        else
        {
            Console.WriteLine("The book - {0} is not available", Title);
           
        }
        
    }

    public void Return()
    {
        if(IsAvailable==false)
        {
            Console.WriteLine("Thankyou for returning the book");
            IsAvailable = true;
        }
        else
        {
            Console.WriteLine("The book - {0} was never borrowed", Title);
        }
    }
    

}

public interface IBorrowable
{
     void Borrow();
     void Return();

}
public class LibraryItem: Book
{
    public LibraryItem(string title, string author, bool isAvailable): base(title, author,isAvailable)
    { }
    public void DisplayDetails()
    {
        Console.WriteLine("Title:{0}, Author:{1}, Available:{2}", Title, Author, IsAvailable);
    }
}

public class Program
{
   
    public static LibraryItem AddBook()
    {
        Console.Write("Enter book title:");
        string t = Console.ReadLine().ToLower();

        Console.Write("Enter book author:");
        string a = Console.ReadLine().ToLower();
        LibraryItem b=new LibraryItem(t, a, true);
        return b;
    }

    static void Main(string[] args)
    {
        List<LibraryItem> books = new List<LibraryItem>();
        string ch= "y";
        do
        {
            Console.WriteLine("Welcome to the Library System");
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. View All Books");
            Console.WriteLine("3. Borrow a Book");
            Console.WriteLine("4. Return a Book");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice:");
            int input = Convert.ToInt32(Console.ReadLine());


            switch (input)
            {
                case 1:
                    books.Add(AddBook());
                    break;

                case 2:
                    Console.WriteLine("Books in the Libarary");
                    int count = 1;
                    foreach (Book b in books)
                    {
                        Console.Write(count + ".");
                        b.DisplayDetails();
                        Console.WriteLine("---------------------------------------");
                        count++;
                    }
                    break;

                case 3:
                    Console.Write("Enter the book you want to borrow:");
                    string borrowBook = null;
                    borrowBook = Console.ReadLine().ToLower();
                    if (borrowBook != null)
                    {
                        Book bookAvailable = books.Find(x => x.Title == borrowBook);
                        if (bookAvailable != null)
                        {
                            bookAvailable.Borrow();
                        }
                    }
                    else
                    {
                        Console.WriteLine("title not entered");
                        return;
                    }


                    break;

                case 4:
                    Console.Write("Enter the book you want to return:");
                    string returnBook = null;
                    returnBook = Console.ReadLine().ToLower();
                    if (returnBook != null) 
                    { 
                        Book bookBorrowed = books.Find(x => x.Title == returnBook);
                        if (bookBorrowed != null)
                        {
                            bookBorrowed.Return();
                        }
                    }
                    else
                    {
                        Console.WriteLine("title not entered");
                        return;
                    }
                    break;

                case 5:
                    return;

                default:
                    throw new Exception("Invalid entry");
                    



            }

            Console.WriteLine("Do you want to continue?:y/n");
            ch= Console.ReadLine();
        }
        while (ch=="y");



    }
}