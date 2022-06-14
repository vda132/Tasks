// TODO: Создать класс Person, который содержит: 
// переменные fullName, age;
// методы move() и talk(), в которых просто вывести на консоль сообщение -"Такой-то  Person говорит". 
// Добавьте два конструктора  - Person() и Person(fullName, age).
// Создайте два объекта этого класса. Один объект инициализируется конструктором Person(), другой - Person(fullName, age).

using Task2;

var person1 = new Person();
var person2 = new Person("Jack", 19);

person1.Talk();
person2.Move();