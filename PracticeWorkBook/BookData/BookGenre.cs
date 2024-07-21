namespace Book.Data
{
    // BookGenre Enum
    // By default, the underlying type of each enum member is 'int', starting from 0
    public enum BookGenre // should be public for access to change book genre when creating a book
    {
        Adventure = 1,// starts incrementing from 1 instead of 0
        Biography,
        Comic,
        Crime,
        Drama,
        Fantasy,
        Fiction,
        Historical,
        Horror,
        Mystery,
        NonFiction,
        Poetry,
        ScienceFiction,
        Thriller,
    }
}
