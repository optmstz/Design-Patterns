using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generating_patterns_class_library
{
    internal interface ISubscription
    {
        decimal MonthlyPrice { get; }
        int MinimalSubscriptionPeriod { get; }
        List<string> IncludedChannels { get; }
        bool AccessToPremiumContent { get; }
    }
}
