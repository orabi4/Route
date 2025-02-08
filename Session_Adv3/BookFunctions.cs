namespace TaskSession_Adv3;

public static class BookFunctions
{
    public static string GetTitle(Book book)
    {
        return book.Title;
    }

    public static string GetAuthors(Book book)
    {
        
        return string.Join(", ",book.Author);
    }

    public static string GetPrice(Book book)
    {
        return book.Price.ToString();
    }
}