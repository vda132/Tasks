namespace Task2;

public class Person
{
    private string fullname = string.Empty;
    private int age;

    public string Fullname
    {
        get => fullname;

        set
        {
            if (string.IsNullOrEmpty(value))
                return;

            fullname = value;
        }
    }

    public int Age
    {
        get => age;
        set
        {
            if (value > 0 && value < 100)
                age = value;
        }
    }

    public Person()
    {
        Fullname = "John";
        Age = 30;
    }

    public Person(string fullname, int age)
    {
        Fullname = fullname;
        Age = age;
    }

    public void Move() =>
        Console.WriteLine($"{this.Fullname} идет");

    public void Talk() =>
        Console.WriteLine($"{this.Fullname} говорит");
}
