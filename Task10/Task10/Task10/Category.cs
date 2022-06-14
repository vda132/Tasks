namespace Task10;

public class Category
{
    private string name;
    private Tovar[] tovars;

    public string Name { 
        get => name; 
        set
        {
            if (string.IsNullOrEmpty(value))
                return;
            name = value;
        }
    }

    public Tovar[] Tovars
    {
        get => tovars;
        set
        {
            if (value.Length == 0)
                return;
            tovars = value;
        }
    }

    public Category(string name, Tovar[] tovars)
    {
        Name = name;
        Tovars = tovars;
    }
}
