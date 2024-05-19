using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generating_patterns_class_library
{
    internal interface ISubscription
    {
        decimal MonthlyPrice { get; set; }
        int MinimalSubscriptionPeriod { get; set; }
        List<string> IncludedChannels { get; set; }
        bool AccessToPremiumContent { get; }
    }
}
