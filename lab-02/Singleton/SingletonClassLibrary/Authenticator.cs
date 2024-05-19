namespace SingletonClassLibrary
{
    public class Authenticator
    {
        private static Authenticator? instance;

        private static readonly object lockObject = new object();

        private Authenticator()
        {
            Console.WriteLine("Initializing Singleton");
        }

        public static Authenticator GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Authenticator();
                    }
                }
            }

            return instance;
        }

        public void AuthenticateUser(string username, string password)
        {
            Console.WriteLine("Authenticating user: " + username);
        }
    }
}
