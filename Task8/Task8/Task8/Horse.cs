namespace Task8;

public class Horse : Animal
{
    protected override string Noise => "Игого";
    public Horse(int food, string location) : base(food, location)
    {
    }

    public override void MakeNoise() =>
        Console.WriteLine(Noise);

    public override void Eat() 
    { 
        Console.WriteLine("Лошадь ест");
        ++food;
    }

    public override void Sleep() => 
        Console.WriteLine("Лошадь ест");
}
