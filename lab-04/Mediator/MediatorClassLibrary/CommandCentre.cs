using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorClassLibrary
{
    public class CommandCentre : ICommandCentre
    {
        private List<Runway> _runways = new List<Runway>();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            this._runways.AddRange(runways);

            foreach (var runway in _runways)
            {
                runway.SetMediator(this);
            }

            foreach (var aircraft in aircrafts)
            {
                aircraft.SetMediator(this);
            }
        }

        public void Notify(object sender, string ev)
        {
            if (sender is Aircraft aircraft)
            {
                if (ev == "Land")
                {
                    RequestLanding(aircraft);
                }
                else if (ev == "TakeOff")
                {
                    RequestTakeOff(aircraft);
                }
            }
        }

        private void RequestLanding(Aircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                if (runway.IsBusyWithAircraft == null)
                {
                    Console.WriteLine($"CommandCentre: Assigning runway {runway.Id} to aircraft {aircraft.Name} for landing.");
                    runway.IsBusyWithAircraft = aircraft;
                    runway.HighLightRed();
                    return;
                }
            }

            Console.WriteLine($"CommandCentre: No available runways for aircraft {aircraft.Name} to land.");
        }

        private void RequestTakeOff(Aircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                if (runway.IsBusyWithAircraft == aircraft)
                {
                    Console.WriteLine($"CommandCentre: Clearing runway {runway.Id} for aircraft {aircraft.Name} to take off.");
                    runway.IsBusyWithAircraft = null;
                    runway.HighLightGreen();
                    return;
                }
            }

            Console.WriteLine($"CommandCentre: Aircraft {aircraft.Name} is not on any runway.");
        }
    }

}
