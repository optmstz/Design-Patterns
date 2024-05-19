using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generating_patterns_class_library.Purchasers
{
    public class WebSite
    {
        private readonly ISubscriptionFactory _factory;

        public WebSite(ISubscriptionFactory factory)
        {
            _factory = factory;
        }

        public ISubscription PurchaseSubscription(string userEmail)
        {
            if (ValidateUserEmail(userEmail))
            {
                Console.WriteLine("Purchasing subscription through Website");
                return _factory.CreateSubscription();
            }
            else
            {
                Console.WriteLine("Invalid email address provided.");
                return null!;
            }
        }

        private bool ValidateUserEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }
    }
}
