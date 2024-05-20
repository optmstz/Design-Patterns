using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityClassLibrary.ConcreteHandlers
{
    public class BillingSupportHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Billing Support")
            {
                return "Billing Support: How can I assist you with billing?\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

}
