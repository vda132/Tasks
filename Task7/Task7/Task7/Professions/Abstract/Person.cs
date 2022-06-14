namespace Task7.Professions.Abstract;

public class Person
{
    protected string fullname = string.Empty;
    protected int age;

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
            if (value > 0 && value <= 100)
                age = value;
        }
    }

    public Person(string fullname, int age)
    {
        Fullname = fullname;
        Age = age;
    }

    public override string ToString() =>
        $"Человек: {Fullname}, {Age.ToString()} лет";
}
