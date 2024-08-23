using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refernces
{
    internal class Truck : IAutoMobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        //similar to sedan but we add a weight Param

        public double Weight { get; }

        public Truck(double speedParam, double weightParam, string licenseNum)
        {
            Weight = weightParam;
            LicensePlate = licenseNum;
            Weight = weightParam;

            if (Weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        public void Stringify()
        {
            Console.WriteLine($"The Truck is travelling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}! ");
        }

        public void IncreaseSpeed()
        {
            Speed += 5;
        }

    }
}