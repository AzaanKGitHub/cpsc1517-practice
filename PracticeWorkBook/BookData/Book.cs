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
        //private BookGenre _bookGenre; 
        /* using the BookGenre enumeration type in the BookGenre.cs file, this field is not needed when using an
         * auto-implemented property. */

        // Constructors
        public Book()
        {
            _bookTitle = string.Empty;
            _bookAuthor = string.Empty;
            _bookDescription = string.Empty;
            _pageCount = 0;
            _datePublished = new DateOnly();
            BookGenre = BookGenre.Adventure; // underlying feild is unnecessary, just use the defined property below
        }

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

        public DateOnly Published
        {
            get
            {
                return _datePublished;
            }
        }

        //public BookGenre BookGenre
        //{
        //    get
        //    {
        //        return _bookGenre;
        //    }

        //    set
        //    {
        //        _bookGenre= value;
        //    }
        //}
        //  Auto-implemented property can be used here since all members in the enum are valid
        public BookGenre BookGenre { get; set; }

        // create book age as a derived property 

        // Methods
    }
}
