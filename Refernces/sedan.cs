using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refernces
{
    internal class Sedan : IAutoMobile //Sedan inherits from IAutomobile interface
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        //sets defaults for the vehicle
        public Sedan(double speed)
        {
            Wheels = 4;
            Speed = speed;
            LicensePlate = "GCTC-59";
        }
        //prints the sedan's stats
        public void Stringify()
        {
            Console.WriteLine($"The Sedan is travelling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}.");
        }

        //Increases speed by 5
        public void IncreaseSpeed()
        {
            Speed += 5;
        }

        //decreases speed by 5
        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
