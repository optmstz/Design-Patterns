using Generating_patterns_class_library.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generating_patterns_class_library.Factories
{
    public class EducationalSubscriptionFactory : ISubscriptionFactory
    {
        private readonly decimal _monthlyPrice;
        private readonly int _minimalSubscriptionPeriod;
        private readonly List<string> _includedChannels;
        private readonly bool _accessToPremiumContent;

        public EducationalSubscriptionFactory(decimal monthlyPrice, int minimalSubscriptionPeriod,
            List<string> includedChannels, bool accessToPremiumContent)
        {
            _monthlyPrice = monthlyPrice;
            _minimalSubscriptionPeriod = minimalSubscriptionPeriod;
            _includedChannels = includedChannels;
            _accessToPremiumContent = accessToPremiumContent;
        }

        public ISubscription CreateSubscription()
        {
            return new EducationalSubscription(_monthlyPrice, _minimalSubscriptionPeriod, _includedChannels, _accessToPremiumContent);
        }
    }
}
