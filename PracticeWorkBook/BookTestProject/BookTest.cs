using Book.Data;

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
            Assert.NotNull(book);

        }
    }
}