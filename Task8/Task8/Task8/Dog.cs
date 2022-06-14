namespace Task8;

public class Dog : Animal
{
    protected override string Noise => "Гав гав";

    public Dog(int food, string location) : base(food, location)
    {
    }

    public override void MakeNoise() =>
        Console.WriteLine(Noise);
    public override void Eat()
    {
        Console.WriteLine("Собака ест");
        ++food;
    }

    public override void Sleep() =>
        Console.WriteLine("Собака спит");
}
