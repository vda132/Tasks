// TODO: 1. Класс Phone.
// Создайте класс Phone, который содержит переменные number, model и weight.
// Создайте три экземпляра этого класса. 
// Выведите на консоль значения их переменных. 
// Добавить в класс Phone методы: receiveCall, имеет один параметр – имя звонящего. Выводит на консоль сообщение “Звонит {name}”. Метод getNumber – возвращает номер телефона. Вызвать эти методы для каждого из объектов.
// Добавить конструктор в класс Phone, который принимает на вход три параметра для инициализации переменных класса - number, model и weight. 
// Добавить конструктор, который принимает на вход два параметра для инициализации переменных класса - number, model. 
// Добавить конструктор без параметров.
// Вызвать из конструктора с тремя параметрами конструктор с двумя. 
// Добавьте перегруженный метод receiveCall, который принимает два параметра - имя звонящего и номер телефона звонящего. Вызвать этот метод.
// Создать метод sendMessage с аргументами переменной длины. Данный метод принимает на вход номера телефонов, которым будет отправлено сообщение. Метод выводит на консоль номера этих телефонов.
// Изменить класс Phone в соответствии с концепцией JavaBean. Смотрите решение задачи в видео 1, видео 2, видео 3, видео 4, видео 5.

using Task1;

var phone1 = new Phone
{
    Model = "Samsung",
    Number = "+380661643085",
    Weight = 27.5
};

var phone2 = new Phone 
{
    Model = "Xiaomi",
    Number = "+380505652623",
    Weight = 13.2
};

var phone3 = new Phone 
{
    Model = "Oppo",
    Number = "+380666221544",
    Weight = 20.1
};

Console.WriteLine($"Model: {phone1.Model} Number: {phone1.Number} Weight: {phone1.Weight}");
Console.WriteLine($"Model: {phone2.Model} Number: {phone2.Number} Weight: {phone2.Weight}");
Console.WriteLine($"Model: {phone3.Model} Number: {phone3.Number} Weight: {phone3.Weight}");

phone1.ReceiveCall("Mike");
phone2.ReceiveCall("Jason");
phone3.ReceiveCall("Taylor");

phone1.ReceiveCall("Jack", phone2.Number);