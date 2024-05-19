using Generating_patterns_class_library;
using Generating_patterns_class_library.Factories;
using Generating_patterns_class_library.Purchasers;
using System;
using System.Collections.Generic;

namespace VideoProviderSubscriptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var domesticFactory = new DomesticSubscriptionFactory(10m, 1, new List<string> { "Channel1", "Channel2" }, false);
            var educationalFactory = new EducationalSubscriptionFactory(15m, 3, new List<string> { "Channel3", "Channel4" }, false);
            var premiumFactory = new PremiumSubscriptionFactory(25m, 6, new List<string> { "Channel5", "Channel6" }, true);

            var webSite = new WebSite(domesticFactory);
            var mobileApp = new MobileApp(educationalFactory);
            var managerCall = new ManagerCall(premiumFactory);

            var domesticSubscription = webSite.PurchaseSubscription("user@example.com");
            var educationalSubscription = mobileApp.PurchaseSubscription("valid_token");
            var premiumSubscription = managerCall.PurchaseSubscription("CONFIRMED");

            DisplaySubscriptionDetails(domesticSubscription);
            DisplaySubscriptionDetails(educationalSubscription);
            DisplaySubscriptionDetails(premiumSubscription);
        }

        static void DisplaySubscriptionDetails(ISubscription subscription)
        {
            if (subscription != null)
            {
                Console.WriteLine("Subscription Details:");
                Console.WriteLine($"Monthly Price: ${subscription.GetPrice()}");
                Console.WriteLine($"Minimal Subscription Period: {subscription.MinimalSubscriptionPeriod} months");
                Console.WriteLine("Included Channels:");
                foreach (var channel in subscription.IncludedChannels)
                {
                    Console.WriteLine($"- {channel}");
                }
                Console.WriteLine($"Access to Premium Content: {(subscription.AccessToPremiumContent ? "Yes" : "No")}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Failed to create subscription.");
            }
        }
    }
}
