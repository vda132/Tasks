namespace Task1;

public class Phone
{
    private string number = string.Empty;
    private string model = string.Empty;
    private double weight;

    public string Number
    {
        get => number;
        set
        {
            if (value.Length != 13)
                return;

            number = value;
        }
    }

    public string Model
    {
        get => model;
        set
        {
            if (string.IsNullOrEmpty(value))
                return;

            model = value;
        }
    }

    public Phone()
    {
        Number = "+380957145975";
        Model = "IPhone";
        Weight = 21.3;
    }

    public Phone(string number, string model)
    {
        Number = number;
        Model = model;
    }

    public Phone(string number, string model, double weight) : this(number, model)
    {
        Weight = weight;
    }

    public double Weight
    {
        get => weight;

        set
        {
            if (value < 0)
                return;

            weight = value;
        }
    }

    public void ReceiveCall(string name) =>
        Console.WriteLine($"Звонит {name}");

    public void ReceiveCall(string name, string callingNumber) =>
        Console.WriteLine($"Звонит {name} с номера {callingNumber}");

    public void SendMessage(params string[] phoneNumbers)
    {
        foreach (var phoneNumber in phoneNumbers)
            Console.WriteLine(phoneNumber);
    }
}
