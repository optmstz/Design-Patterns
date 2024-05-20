using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityClassLibrary.ConcreteHandlers
{
    public class GeneralInquiryHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "General Inquiry")
            {
                return "General Inquiry: How can I help you with your general questions?\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
