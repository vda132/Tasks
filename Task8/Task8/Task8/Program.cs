// TODO: Животные
// Создать класс Animal и расширяющие его классы Dog, Cat, Horse.
// Класс Animal содержит переменные food, location и методы makeNoise, eat, sleep. Метод makeNoise, например, может выводить на консоль "Такое-то животное спит". 
// Dog, Cat, Horse переопределяют методы makeNoise, eat. 
// Добавьте переменные в классы Dog, Cat, Horse, характеризующие только этих животных.
// Создайте класс Ветеринар, в котором определите метод void treatAnimal(Animal animal). Пусть этот метод распечатывает food и location пришедшего на прием животного.
// В методе main создайте массив типа Animal, в который запишите животных всех имеющихся у вас типов. В цикле отправляйте их на прием к ветеринару.

using Task8;

Animal[] animals = { new Cat(21, "Europe"), new Horse(12, "America"), new Dog(17, "Asia") };

animals[0].Sleep();
animals[0].Eat();

var veterinarian = new Veterinarian("Иван");

foreach(var animal in animals)
   veterinarian.TreatAnimal(animal);