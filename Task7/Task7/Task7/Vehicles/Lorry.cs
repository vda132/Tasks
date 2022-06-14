using Task7.Details;
using Task7.Professions;

namespace Task7.Vehicles;

public class Lorry : Car
{
    private int carying;

    public int Carying
    {
        get => carying;
        set
        {
           if(value > 0)
                carying = value;
        }
    }
    public Lorry(string carClass, Engine engine, Driver driver, string marka, int carying) : base(carClass, engine, driver, marka)
    {
        Carying = carying;
    }

    public override string ToString() =>
        base.ToString() + $" с грузоподъемностью: {carying.ToString()}";
}
