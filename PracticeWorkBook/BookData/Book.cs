namespace Book.Data
{
    public class Book
    {
        // Fields
        private string _bookTitle;
        private string _bookAuthor;
        private string _bookDescription;
        private int _pageCount;
        private DateOnly _datePublished;
        private BookGenre _bookGenre; //using the BookGenre enumeration type in the BookGenre.cs file

        

        // Properties
        public string BookTitle
        {
            get 
            { 
                return _bookTitle; 
            } 
            
            set
            {
                if (string.IsNullOrEmpty(value)) // checks for Null, Whitespace, or Empty value
                {
                    // returns error if the statement string.IsNullOrEmpty(value) is true
                    throw new ArgumentNullException("Book title cannot be empty.");
                }
                _bookTitle = value;

            }
        }

        public string BookAuthor
        {
            get 
            { 
                return _bookAuthor;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Book author name cannot be empty.");
                }
                _bookAuthor = value;
            }
        }

        public string BookDescription
        {
            get
            {
                return _bookDescription;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Book description cannot be empty");
                }
                _bookDescription = value;
            }
        }

        public int PageCount
        {
            get 
            {
                return _pageCount;
            }

            set
            {

                
            }
        }
        // create book age as a derived property 

        // Methods
    }
}
