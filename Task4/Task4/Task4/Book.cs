namespace Task4;

public class Book
{
    private string name = string.Empty;
    private string author = string.Empty;

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrEmpty(value))
                return;

            name = value;
        }
    }

    public string Author
    {
        get => author;
        set
        {
            if (string.IsNullOrEmpty(value))
                return;

            author = value;
        }
    }

    public Book(string name, string author)
    {
        Name = name;
        Author = author;
    }
}
