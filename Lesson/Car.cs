using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Car : Vehicle
    {
        public double CurrentFuel;
        public double FuelFor1Km;
        public override void Drive(double km)
        {
            Mileage += km;
            CurrentFuel -= km * FuelFor1Km;
        }
    }
}
