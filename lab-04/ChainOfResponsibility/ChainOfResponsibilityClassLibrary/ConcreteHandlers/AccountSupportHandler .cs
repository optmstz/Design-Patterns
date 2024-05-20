using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityClassLibrary.ConcreteHandlers
{
    public class AccountSupportHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Account Support")
            {
                return "Account Support: What issue are you having with your account?\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
