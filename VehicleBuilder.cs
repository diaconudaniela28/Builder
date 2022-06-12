using System;
using System.Collections.Generic;
using System.Text;

namespace Builder__
{
    abstract class VehicleBuilder
    {
        protected Vehicle vehicle;
        // Gets vehicle instance
        public Vehicle Vehicle
        {
            get { return vehicle; }
        }
        // Abstract build methods
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();

        public static implicit operator VehicleBuilder(ScooterBuilder v)
        {
            throw new NotImplementedException();
        }
    }
}
