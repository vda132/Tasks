using Task7.Details;
using Task7.Professions;

namespace Task7.Vehicles;

public class SportCar : Car
{
    private double speed;

    public double Speed
    {
        get => speed;
        set
        {
           if(speed >= 0)
                speed = value;
        }
    }

    public SportCar(string carClass, Engine engine, Driver driver, string marka, double speed) : base(carClass, engine, driver, marka)
    {
        Speed = speed;
    }

    public override string ToString() =>
        base.ToString() + $"со скоростью: {speed.ToString()}";
}
