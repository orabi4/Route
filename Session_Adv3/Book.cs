namespace TaskSession_Adv3;

public class Book
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string []Author { get; set; }
    public DateTime PublicationDate { get; set; }
    public decimal Price { get; set; }

    public Book(string _isbn, string _title, string [] _author, DateTime _publicationDate, decimal _price)
    {
        ISBN = _isbn;
        Title = _title;
        Author = _author;
        PublicationDate = _publicationDate;
        Price = _price;
    }

    public override string ToString()
    {
        return $"ISBN: {ISBN}, Title: {Title}, Author: {string.Join(", ", Author)}, PublicationDate: {PublicationDate}, Price: {Price}";
    }
}