using Book.Data;

/* The top-level namespace is the same as the class name.
   Therefore the full namespace path is delcared here to avoid ambiguity.*/
Book.Data.Book book;

book = new Book.Data.Book(); // default constuctor for Book class

try
{
    // Using the set of a property
    book.BookTitle = "The Last Wish"; // assignment invokes set
    book.BookAuthor = "Andrzej Sapkowski";
    book.BookDescription = "\"A story about a witcher named Geralt\"";
    book.PageCount = 504;
    book.Published = new DateOnly(2021, 01, 01);
    book.BookGenre = BookGenre.Mystery;
    // Using the get of property
    Console.WriteLine
    (
        "Book Info\n--------------\n" +
        $"Book Title: {book.BookTitle}\n" +
        $"Book Author: {book.BookAuthor}\n" +
        $"Book Description: {book.BookDescription}\n" +
        $"Page Count: {book.PageCount}\n" +
        $"Published: {book.BookTitle}\n" +
        $"Genre: {book.BookTitle}\n"

    ); // using the operator invokes get
}
catch(Exception e)
{
    // prints exception catch to the console
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ("Error: " + e.Message);
    Console.ResetColor();
}