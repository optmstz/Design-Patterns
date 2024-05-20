using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityClassLibrary.ConcreteHandlers
{
    public class TechnicalSupportHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Technical Support")
            {
                return "Technical Support: What technical issue are you experiencing?\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
