namespace Task8;

public class Veterinarian
{
    private string name = string.Empty;

    public string Name 
    { 
        get => name; 
        set
        {
            if (string.IsNullOrEmpty(value))
                return;
            name = value;
        }
    }

    public Veterinarian(string name) =>
        Name = name;

    public void TreatAnimal(Animal animal) =>
        Console.WriteLine($"Еда животного: {animal.Food.ToString()} Местоположение животного: {animal.Location}");
}
