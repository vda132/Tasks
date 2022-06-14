namespace Task10;

public class Tovar
{
    private string name = string.Empty;
    private double price;
    private int rate;

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

    public double Price
    {
        get => price;
        set
        {
            if (value <= 0)
                return;
            price = value;
        }
    }

    public int Rate
    {
        get=> rate;
        set
        {
            if(rate > 0 && rate <=5)
                rate = value;
        }
    }

    public Tovar(string name, double price, int rate)
    {
        Name = name;
        Price = price;
        Rate = rate;
    }
}
