using Book.Data;
using FluentAssertions;

namespace BookTestProject
{
    public class BookTest
    {
        // Constants for a test Book
        const string BookTitle = "The Last Wish";
        const string BookAuthor = "Andrzej Sapkowski";
        const string BookDescription = "A story about a witcher named Geralt";
        const int PageCount = 359;
        // Published August 28, 1993
        const int Year = 1993;
        const int Month = 08;
        const int Day = 28;
        const BookGenre ReadingGenre = BookGenre.Adventure;



        /// <summary>
        /// Test for Greedy constructor of Book class.
        /// Creates and should return a valid Book.
        /// </summary>
        [Fact]
        public void Book_GreedyConstructor_ReturnsBook()
        {
            // Given - Arrange
            Book.Data.Book actual; // create (initialize) Book reference called actual

            // When - Act
            // actual will be assigned the constructor for testing
            // pass in the constants as arguments for the constructor
            actual = new Book.Data.Book(BookTitle, BookAuthor,
                BookDescription, PageCount, new DateOnly(Year, Month, Day), ReadingGenre);

            // Then - Assert
            // checks if not null and checks if the constant values match
            actual.Should().NotBeNull();
            actual.BookTitle.Should().Be(BookTitle);
            actual.BookAuthor.Should().Be(BookAuthor);
            actual.BookDescription.Should().Be(BookDescription);
            actual.PageCount.Should().Be(PageCount);
            actual.Published.Should().Be(new DateOnly(Year, Month, Day)); // publish date
            actual.BookGenre.Should().Be(ReadingGenre); // book genre
        }

        [Theory]
        // BookTitle cases
        [InlineData("", BookAuthor,BookDescription, PageCount, Year, Month, Day, ReadingGenre, "Book title cannot be null or empty.")]
        [InlineData(" ", BookAuthor, BookDescription, PageCount, Year, Month, Day, ReadingGenre, "Book title cannot be null or empty.")]
        [InlineData(null, BookAuthor, BookDescription, PageCount, Year, Month, Day, ReadingGenre, "Book title cannot be null or empty.")]
        // BookAuthor cases
        [InlineData(BookTitle, "", BookDescription, PageCount, Year, Month, Day, ReadingGenre, "Book author name cannot be null or empty.")]
        [InlineData(BookTitle, " ", BookDescription, PageCount, Year, Month, Day, ReadingGenre, "Book author name cannot be null or empty.")]
        [InlineData(BookTitle, null, BookDescription, PageCount, Year, Month, Day, ReadingGenre, "Book author name cannot be null or empty.")]
        // BookDescription cases
        [InlineData(BookTitle, BookAuthor, "", PageCount, Year, Month, Day, ReadingGenre, "Book description cannot be null or empty.")]
        [InlineData(BookTitle, BookAuthor, " ", PageCount, Year, Month, Day, ReadingGenre, "Book description cannot be null or empty.")]
        [InlineData(BookTitle, BookAuthor, null, PageCount, Year, Month, Day, ReadingGenre, "Book description cannot be null or empty.")]
        // PageCount cases
        [InlineData(BookTitle, BookAuthor, BookDescription, 0, Year, Month, Day, ReadingGenre, "Page count cannot be 0 or negative.")]
        [InlineData(BookTitle, BookAuthor, BookDescription, -1, Year, Month, Day, ReadingGenre, "Page count cannot be 0 or negative.")]
        public void Book_GreedyConstructor_ThrowsException(string bookTitle, string bookAuthor, string bookDescription,
            int pageCount, int year, int month, int day, BookGenre bookGenre, string errorMessage) // final paramter is the error message 
        {
            // Arrange
            Action act = () => new Book.Data.Book(bookTitle, bookAuthor, bookDescription, pageCount, 
                new DateOnly(year, month, day), bookGenre);

            // Act/Assert
            act.Should().Throw<ArgumentException>().WithMessage(errorMessage);
        }










        //[Fact] // attribute for a single test
        //public void Book_DefaultConstructor_CreatesGoodBook()
        //{
        //    // Arrange
        //    // Here we initialize a Book object for testing
        //    Book.Data.Book book;

        //    // Act
        //    // Here we call the default constructor for testing on 'book'
        //    book = new Book.Data.Book();

        //    // Assert
        //    // the book variable should be of the Book object type
        //    book.Should().BeOfType<Book.Data.Book>();

        //}

        //[Fact]
        //public void Book_PageCount_GoodSet()
        //{
        //    // Arrange
        //    // creates a new instance of the 'Book' class to test PageCount property
        //    Book.Data.Book book = new Book.Data.Book();
        //    // this variable will be set to the PageCount property
        //    int pageCount = 400;
        //    // this variable will hold the actual value retrieved from the PageCount property
        //    int actual;

        //    // Act
        //    //book.PageCount = pageCount; wont work due to private Property 'sets'
        //    actual = book.PageCount;

        //    // Assert
        //    actual.Should().Be(pageCount);
        //}
    }
}