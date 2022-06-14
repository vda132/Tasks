namespace Task6;

public class Student
{
    protected string firstname = string.Empty;
    protected string lastname = string.Empty;
    protected string group = string.Empty;
    protected double avarageMark;

    public string Firstname
    {
        get => firstname;
        set
        {
            if (string.IsNullOrEmpty(value))
                return;
            firstname = value;
        }
    }

    public string Lastname
    {
        get => lastname;
        set
        {
            if (string.IsNullOrEmpty(value))
                return;
            lastname = value;
        }
    }

    public string Group
    {
        get => group;
        set
        {
            if (string.IsNullOrEmpty(value))
                return;
            group = value;
        }
    }
    public double AvarageMark
    {
        get => avarageMark;
        set
        {
            if(value > 0 && value <=5)
                avarageMark = value;
        }
    }

    public Student(string firstname, string lastname, string group, double avarageMark)
    {
        Firstname = firstname;
        Lastname = lastname;
        Group = group;
        AvarageMark = avarageMark;
    }

    public virtual int GetScholarShip() =>
        avarageMark == 5 ? 100 : 80;
}
