namespace Task10;

public class User
{
    private string login;
    private string password;
    private Basket basket;

    public string Login
    {
        get => login;
        set
        {
            if (string.IsNullOrEmpty(value))
                return;
            login = value;
        }
    }

    public string Password
    {
        get => password;
        set
        {
            if (string.IsNullOrEmpty(value))
                return;
            password = value;
        }
    }

    public Basket Basket
    {
        get => basket;
        set
        {
            if (value is null)
                return;
            basket = value;
        }
    }

    public User(string login, string password, Basket basket)
    {
        Login = login;
        Password = password;
        Basket = basket;
    }
}
