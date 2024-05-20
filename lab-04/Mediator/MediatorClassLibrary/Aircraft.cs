using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorClassLibrary
{
    public class Aircraft
    {
        public string? Name { get; private set; }
        private ICommandCentre? _mediator;

        public Aircraft(string name)
        {
            this.Name = name;
        }

        public void SetMediator(ICommandCentre mediator)
        {
            this._mediator = mediator;
        }

        public void Land()
        {
            Console.WriteLine($"Aircraft {this.Name} is requesting to land.");
            _mediator?.Notify(this, "Land");
        }

        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {this.Name} is requesting to take off.");
            _mediator?.Notify(this, "TakeOff");
        }
    }

}
