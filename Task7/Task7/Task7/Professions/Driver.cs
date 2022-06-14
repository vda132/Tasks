using Task7.Professions.Abstract;

namespace Task7.Professions;

public class Driver : Person
{
    private int experience;

    public int Experience
    {
        get => experience;
        set
        {
            if (value > 0)
                experience = value;
        }
    }
    
    public Driver(string fullname, int age, int experience) : base(fullname, age) =>
        Experience = experience;

    public override string ToString() =>
        base.ToString() + $" с опытом: {experience.ToString()}";
}
