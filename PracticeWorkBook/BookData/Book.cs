using Utilities;

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

        /// <summary>
        /// Greedy Constructor
        /// Will throw an exception if any of the params are invalid.
        /// The parameters here represent essential data required to create a  valid 'Book' object.
        /// </summary>
        public Book(string bookTitle, string bookAuthor, string bookDescription, 
                    int pageCount, DateOnly datePublished)
        {
            // parameters are assigned to corresponding Properties of the 'Book' class
            BookTitle = bookTitle;
            BookAuthor = bookAuthor;
            BookDescription = bookDescription;
            PageCount = pageCount;
            Published = datePublished;
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Book()
        {
            _bookTitle = string.Empty;
            _bookAuthor = string.Empty;
            _bookDescription = string.Empty;
            _pageCount = 1;
            _datePublished = new DateOnly();
            BookGenre = BookGenre.Adventure; // underlying feild is unnecessary, just use the defined property below
        }

        // Properties
        public string BookTitle
        {
            get // getter retrives the value from the private Field associated with the given Property (BookTitle).
            { 
                return _bookTitle; 
            } 
            
            private set // setter checks if value is valid 
            {
                if (Utils.IsNullEmptyOrWhiteSpace(value)) // checks for Null, Whitespace, or Empty value
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

            private set
            {
                if (Utils.IsNullEmptyOrWhiteSpace(value))
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

            private set
            {
                if (Utils.IsNullEmptyOrWhiteSpace(value))
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

            private set
            {
                // checks if the page count is greater than 0
                if (!Utils.IsPositive(value))
                {
                    throw new ArgumentException("Page count must be a positive number.");
                }
                
                _pageCount = value;
            }
        }

        public DateOnly Published
        {
            get
            {
                return _datePublished;
            }

            private set
            {
                // checks if the published date is in the future or not
                if (Utils.IsInTheFuture(value))
                {
                    throw new ArgumentException($"Published date cannot be in the future.");
                }

                _datePublished = value;
            }
        }

        // Age property

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
        /*  defines the properties without explicit backing fields, system automatically generates a private 
            field to store the value of the property, as well as the getter and setter methods.*/
        public BookGenre BookGenre { get; private set; }

        // create book age as a derived property 

        // Methods

        // override is used here to change the behaviour of the ToString() method
        /// <summary>
        /// This method provides the string representation of a Book object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{BookTitle},{BookAuthor},{BookDescription},pages: {PageCount},date: {Published}";
        }
    }
}
