using SingletonClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        Authenticator authenticator1 = Authenticator.GetInstance();
        authenticator1.AuthenticateUser("user1", "password1");

        Authenticator authenticator2 = Authenticator.GetInstance();
        authenticator2.AuthenticateUser("user2", "password2");

        Console.WriteLine("authenticator1 == authenticator2: " + (authenticator1 == authenticator2));
    }
}