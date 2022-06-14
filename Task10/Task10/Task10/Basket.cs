namespace Task10;

public class Basket
{
    private Tovar[] tovars;

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

    public Basket(Tovar[] tovars) =>
        this.Tovars = tovars;
}
