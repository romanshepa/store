namespace Store;
public class Book
{
    public int Id { get; }

    public string Isbn { get; }

    public string Autor { get; }

    public string Title { get; }

    public Book(int id, string isbn, string autor, string title)
    {
        Id = id;

        Isbn = isbn;

        Autor = autor;

        Title = title;
    }
}
