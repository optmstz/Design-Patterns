using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generating_patterns_class_library.Purchasers
{
    public class MobileApp
    {
        private readonly ISubscriptionFactory _factory;

        public MobileApp(ISubscriptionFactory factory)
        {
            _factory = factory;
        }

        public ISubscription PurchaseSubscription(string userToken)
        {
            if (AuthenticateUser(userToken))
            {
                Console.WriteLine("Purchasing subscription through Mobile App");
                return _factory.CreateSubscription();
            }
            else
            {
                Console.WriteLine("User authentication failed.");
                return null!;
            }
        }

        private bool AuthenticateUser(string token)
        {
            // Простий приклад автентифікації користувача
            return !string.IsNullOrEmpty(token);
        }
    }
}
