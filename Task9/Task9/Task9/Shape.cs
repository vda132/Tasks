namespace Task9;

public abstract class Shape
{
    public string Color { get; set; }

    public Shape(string color) =>
        Color = color;

    public abstract void Draw();
    public override bool Equals(Object? obj)
    {
        object obj2 = obj as Shape;
        return base.Equals(obj2);
    }
}
