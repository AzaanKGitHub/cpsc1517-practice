using Book.Data;
using FluentAssertions;

namespace BookTestProject
{
    public class BookTest
    {
        [Fact] // attribute for a single test
        public void Book_DefaultConstructor_CreatesGoodBook()
        {
            // Arrange
            // Here we initialize a Book object for testing
            Book.Data.Book book;

            // Act
            // Here we call the default constructor for testing on 'book'
            book = new Book.Data.Book();
            
            // Assert
            // the book variable should be of the Book object type
            book.Should().BeOfType<Book.Data.Book>();

        }

        [Fact]
        public void Book_PageCount_GoodSet()
        {
            // Arrange
            // creates a new instance of the 'Book' class to test PageCount property
            Book.Data.Book book = new Book.Data.Book();
            // this variable will be set to the PageCount property
            int pageCount = 400;
            // this variable will hold the actual value retrieved from the PageCount property
            int actual;

            // Act
            book.PageCount = pageCount;
            actual = book.PageCount;

            // Assert
            actual.Should().Be(pageCount);
        }
    }
}