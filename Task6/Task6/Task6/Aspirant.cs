namespace Task6;

public class Aspirant : Student
{
    private string scienceWork = string.Empty;

    public string ScienceWork
    {
        get => scienceWork;
        set
        {
            if (string.IsNullOrEmpty(value))
                return;

            scienceWork = value;
        }
    }

    public Aspirant(string firstname, string lastname, string group, double avarageMark, string scienceWork) : base(firstname, lastname, group, avarageMark) =>
        ScienceWork = scienceWork;

    public override int GetScholarShip() =>
        AvarageMark == 5 ? 200 : 180;
}
