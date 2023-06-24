public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }

    public void GetInfo()
    {
        Console.WriteLine("First Name: ", FirstName);
        Console.WriteLine("Last Name: ", LastName);
        Console.WriteLine("User Name: ", UserName);
        Console.WriteLine("Password: ", Password);
    }

    public bool Login(string userName, string password)
    {
        return (userName == UserName && password == Password);
    }
}
