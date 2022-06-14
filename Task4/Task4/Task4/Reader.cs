namespace Task4;

public class Reader
{
    private string fio = string.Empty;
    private int readerTicketNumber;
    private string faculty = string.Empty;
    private string phone = string.Empty;

    public string FIO
    {
        get => fio;
        set
        {
            if (string.IsNullOrEmpty(value))
                return;

            fio = value;
        }
    }

    public int ReaderTicketNumber
    {
        get => readerTicketNumber;
        set
        {
            if (value > 0)
                readerTicketNumber = value;
        }
    }

    public string Faculty
    {
        get => faculty;
        set
        {
            if (string.IsNullOrEmpty(value))
                return;

            faculty = value;
        }
    }

    public string Phone
    {
        get => phone;
        set
        {
            if (value.Length != 13)
                return;

            phone = value;
        }
    }

    public Reader(string fio, int readerTicketNumber, string faculty, string phone)
    {
        FIO = fio;
        ReaderTicketNumber = readerTicketNumber;
        Faculty = faculty;
        Phone = phone;
    }

    public void TakeBook() =>
        Console.WriteLine($"{FIO} взял книгу");

    public void TakeBook(int bookAmmount) =>
        Console.WriteLine($"{FIO} взял {bookAmmount} книги");

    public void TakeBook(params string[] books)
    {
        var result = $"{FIO} взял книги: ";
        
        foreach (var book in books)
            result += book + " ";

        Console.WriteLine(result);
    }

    public void TakeBook(params Book[] books)
    {
        var result = $"{FIO} взял книги: ";

        foreach (var book in books)
            result += book.Name + " ";

        Console.WriteLine(result);
    }

    public void ReturnBook() =>
        Console.WriteLine($"{FIO} вернул книгу");

    public void ReturnBook(int bookAmmount) =>
        Console.WriteLine($"{FIO} вернул {bookAmmount} книги");

    public void ReturnBook(params string[] books)
    {
        var result = $"{FIO} вернул книги: ";

        foreach (var book in books)
            result += book + " ";

        Console.WriteLine(result);
    }

    public void ReturnBook(params Book[] books)
    {
        var result = $"{FIO} вернул книги: ";

        foreach (var book in books)
            result += book.Name + " ";

        Console.WriteLine(result);
    }
}
