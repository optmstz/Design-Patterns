using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generating_patterns_class_library.Purchasers
{
    public class ManagerCall
    {
        private readonly ISubscriptionFactory _factory;

        public ManagerCall(ISubscriptionFactory factory)
        {
            _factory = factory;
        }

        public ISubscription PurchaseSubscription(string managerCode)
        {
            if (ConfirmWithManager(managerCode))
            {
                Console.WriteLine("Purchasing subscription through Manager Call");
                return _factory.CreateSubscription();
            }
            else
            {
                Console.WriteLine("Manager confirmation failed.");
                return null!;
            }
        }

        private bool ConfirmWithManager(string managerCode)
        {
            return managerCode == "CONFIRMED";
        }
    }
}
