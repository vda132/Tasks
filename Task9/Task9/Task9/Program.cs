// TODO: Фигуры
// Создайте супер класс Shape и его наследников Circle, Rectangle.
// Класс Shape содержит абстрактный метод draw() и переменную хранящую цвет.
// Классы Circle, Rectangle содержат координаты точек.
// Создать массив содержащий эти фигуры.
// В цикле нарисовать их (вызвать метод draw).
// Добавить метод equals() для классов Shape, Circle, Rectangle.

using Task9;

Shape[] shapes = { new Circle("Red", 29.1, 28.9), new Rectangle("Blue", 12.1, 22.0, 11.0, 9.11, 3.11, 33.1, 1.1, 2.1) };

foreach (var shape in shapes)
    shape.Draw();

Console.WriteLine(shapes[0].Equals(shapes[1]));
Console.WriteLine(shapes[0].Equals(new Circle("Red", 29.1, 28.9)));
