namespace Task9;

public class Rectangle : Shape
{
    public double PosX1 { get; set; }
    public double PosY1 { get; set; }
    public double PosX2 { get; set; }
    public double PosY2 { get; set; }
    public double PosX3 { get; set; }
    public double PosY3 { get; set; }
    public double PosX4 { get; set; }
    public double PosY4 { get; set; }

    public Rectangle(string color, double posX1, double posY1, double posX2, double posY2, double posX3, double posY3, double posX4, double posY4) : base(color)
    {
        PosX1 = posX1;
        PosY1 = posY1;
        PosX2 = posX2;
        PosY2 = posY2;
        PosX3 = posX3;
        PosY3 = posY3;
        PosX4 = posX4;
        PosY4 = posY4;
    }

    public override void Draw() =>
        Console.WriteLine($"Рисуем прямоугольник с координатами {PosX1}, {PosY1}, {PosX2}, {PosY2}, {PosX3}, {PosY3}, {PosX4}, {PosY4} цветом {Color}");

    public override bool Equals(Object? obj)
    {
        Rectangle? rectangle = obj as Rectangle;
        return rectangle != null && rectangle.PosX1 == this.PosX1 && 
            rectangle.PosY1 == this.PosY1 && rectangle.PosX2 == this.PosX2 && 
            rectangle.PosY2 == this.PosY2 && rectangle.PosX3 == this.PosX3 && 
            rectangle.PosY3 == this.PosY3 && rectangle.PosX4 == this.PosY4 && 
            rectangle.PosY4 == this.PosY4 && rectangle.Color == this.Color;
    }
}
