// TODO: Автомобили
// Создать класс Car в пакете com.company.vehicles, Engine в пакете com.company.details и Driver в пакете com.company.professions.
// Класс Driver содержит поля - ФИО, стаж вождения.
// Класс Engine содержит поля - мощность, производитель.
// Класс Car содержит поля - марка автомобиля, класс автомобиля, вес, водитель типа Driver, мотор типа Engine. Методы start(), stop(), turnRight(), turnLeft(), которые выводят на печать: "Поехали", "Останавливаемся", "Поворот направо" или "Поворот налево".А также метод toString(), который выводит полную информацию об автомобиле, ее водителе и моторе. 
// Создать производный от Car класс  - Lorry (грузовик), характеризуемый также грузоподъемностью кузова.
// Создать производный от Car класс - SportCar, характеризуемый также предельной скоростью.
// Пусть класс Driver расширяет класс Person.

using Task7;
using Task7.Details;
using Task7.Professions;
using Task7.Vehicles;

var driver = new Driver("Иванов Иван", 31, 4);
Console.WriteLine(driver);

var engine = new Engine(230, "Galo");
Console.WriteLine(engine);
var lorry = new Lorry("Грузовая", engine, driver, "Volvo", 430);
Console.WriteLine(lorry);
lorry.Start();