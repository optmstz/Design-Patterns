using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generating_patterns_class_library.Subscriptions
{
    public class DomesticSubscription : ISubscription
    {
        public decimal MonthlyPrice { get; private set; }
        public int MinimalSubscriptionPeriod { get; private set; }
        public List<string> IncludedChannels { get; private set; }
        public bool AccessToPremiumContent { get; private set; }

        public DomesticSubscription(decimal monthlyPrice, int minimalSubscriptionPeriod,
            List<string> includedChannels, bool accessToPremiumContent)
        {
            MonthlyPrice = monthlyPrice;
            MinimalSubscriptionPeriod = minimalSubscriptionPeriod;
            IncludedChannels = includedChannels;
            AccessToPremiumContent = accessToPremiumContent;
        }

        public decimal GetPrice()
        {
            return MonthlyPrice;
        }
    }
}
