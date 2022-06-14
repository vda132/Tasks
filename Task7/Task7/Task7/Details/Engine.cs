namespace Task7.Details;

public class Engine
{
    private int power;
    private string company;

    public int Power
    {
        get => power;
        set
        {
            if (value > 0)
                power = value;
        }
    }

    public string Company
    {
        get => company;
        set
        {
            if (string.IsNullOrEmpty(value))
                return;
            company = value;
        }
    }

    public Engine(int power, string company)
    {
        Power = power;
        Company = company;
    }

    public override string ToString() =>
        $"Двигатель с мощностью: {power.ToString()}, сделан: {company}";
}
