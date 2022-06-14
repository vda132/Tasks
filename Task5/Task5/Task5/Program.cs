//TODO Даны два целых числа A и В.
//Выведите все числа от A до B включительно, в порядке возрастания, если A < B, или в порядке убывания в противном случае. Использовать рекурсию.

Recursia(2, 9);
Recursia(10, 4);

void Recursia(int a, int b)
{
    if (a < b)
    { 
        Recursia(a, b - 1);
        Console.WriteLine(b);
    }
    else if (a > b)
    {
        Console.WriteLine(a);
        Recursia(a - 1, b);
    }
    else
        Console.WriteLine(a);
}
