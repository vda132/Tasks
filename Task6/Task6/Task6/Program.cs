// TODO: Наследование Student, Aspirant
// Создайте пример наследования, реализуйте класс Student и класс Aspirant, аспирант отличается от студента наличием некой научной работы.
// Класс Student содержит переменные: String firstName, lastName, group. А также, double averageMark, содержащую среднюю оценку.
// Создать переменную типа Student, которая ссылается на объект типа Aspirant.
// Создать метод getScholarship() для класса Student, который возвращает сумму стипендии. Если средняя оценка студента равна 5, то сумма 100 грн, иначе 80. Переопределить этот метод в классе Aspirant.  Если средняя оценка аспиранта равна 5, то сумма 200 грн, иначе 180.
// Создать массив типа Student, содержащий объекты класса Student и Aspirant. Вызвать метод getScholarship() для каждого элемента массива.

using Task6;

Student[] students = { new Student("Иван", "Иванов", "ИНФ-20-3", 5), new Aspirant("Янгазов", "Эдуард", "ИНФ-17-1", 3, "Научная работа по компьютерному зрению") };

foreach (var student in students)
    Console.WriteLine(student.GetScholarShip());