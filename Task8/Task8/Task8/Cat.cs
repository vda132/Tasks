namespace Task8;

public class Cat : Animal
{
    protected override string Noise => "Мяу мяу";
    public Cat(int food, string location) : base(food, location)
    {
    }

    public override void MakeNoise() =>
        Console.WriteLine(Noise);

    public override void Eat()
    {
        Console.WriteLine("Кошка ест");
        ++food;
    }

    public override void Sleep() =>
        Console.WriteLine("Кошка спит");
}
