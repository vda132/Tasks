namespace Task8;

public abstract class Animal
{
    protected int food;
    protected string location = string.Empty;

    public int Food
    {
        get => food;
        set
        {
            if (value <= 0)
                return;
            food = value;
        }
    }

    public string Location
    {
        get => location;
        set
        {
            if (string.IsNullOrEmpty(value))
                return;
            location = value;
        }
    }

    protected virtual string Noise => string.Empty;

    public Animal(int food, string location)
    {
        Food = food;
        Location = location;
    }

    public virtual void MakeNoise() =>
        Console.WriteLine("Издать звук");

    public virtual void Eat() =>
        Console.WriteLine("Животное кушает");

    public virtual void Sleep() =>
        Console.WriteLine("Животное спит");
}
