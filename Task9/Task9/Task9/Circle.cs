namespace Task9;

public class Circle : Shape
{
    public double PosX { get; set; }
    public double PosY { get; set; }
    public Circle(string color, double posX, double posY) : base(color)
    {
        PosX = posX;
        PosY = posY;
    }

    public override void Draw() =>
        Console.WriteLine($"Рисуем круг с координатами: {PosX}, {PosY} цветом {Color}");

    public override bool Equals(Object? obj)
    {
        Circle? circle = obj as Circle;

        return circle != null && circle.PosX == this.PosX && circle.PosY == this.PosY && circle.Color == this.Color;
    }
}
