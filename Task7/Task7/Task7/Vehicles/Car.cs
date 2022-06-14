using Task7.Details;
using Task7.Professions;

namespace Task7.Vehicles;

public class Car 
{
    private string carClass = string.Empty;
    private Engine engine;
    private Driver driver;
    private string marka = string.Empty;

    public string CarClass
    {
        get => carClass;
        set
        {
            if (string.IsNullOrEmpty(value))
                return;
            carClass = value;
        }
    }

    public Engine Engine
    {
        get => engine;
        set
        {
            if (value is null)
                return;
            engine = value;
        }
    }

    public Driver Driver
    {
        get => driver;
        set
        {
            if (value is null)
                return;
            driver = value;
        }
    }

    public string Marka
    {
        get => marka;
        set
        {
            if (string.IsNullOrEmpty(value))
                return;
            marka = value;  
        }
    }

    public Car(string carClass, Engine engine, Driver driver, string marka)
    {
        CarClass = carClass;
        Engine = engine;
        Driver = driver;
        Marka = marka;
    }

    public void Start() =>
        Console.WriteLine("Поехали");

    public void Stop() =>
        Console.WriteLine("Останавливаемся");

    public void TurnLeft() =>
        Console.WriteLine("Поворачиваем на лево");

    public void TurnRight() =>
        Console.WriteLine("Поворачиваем на право");

    public override string ToString() =>
        $"Машина класса: {carClass} с двигателем: {engine.ToString()} водителем: {driver.ToString()} марки: {marka}";
}
