// TODO: Интернет магазин, часть 1
// Создать класс Товар, имеющий переменные имя, цена, рейтинг. 
// Создать класс Категория, имеющий переменные имя и массив товаров. Создать несколько объектов класса Категория. 
// Создать класс Basket, содержащий массив купленных товаров. 
// Создать класс User, содержащий логин, пароль и объект класса Basket. Создать объект класса User.

using Task10;

var tovar = new Tovar("Ноутбук", 100, 4);
Tovar[] tovars = { tovar };

var category = new Category("Електроника", tovars);

Tovar[] tovarsForBasket = { new Tovar("Фонарик", 90, 3), new Tovar("Лампа", 100, 5) };

var category1 = new Category("Електроника", tovarsForBasket);

var basket = new Basket(tovarsForBasket);

var user = new User("123456", "qwerty", basket);