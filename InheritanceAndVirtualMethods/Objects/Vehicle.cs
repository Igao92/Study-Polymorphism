using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndVirtualMethods.Objects
{
    public class Vehicle
    {
		public EnumVehicleType Type { get; set; }

		public Vehicle(EnumVehicleType vehicleType)
		{
			Type = vehicleType;
		}

		//'virtual' modifier allows you to change the behavior of the method in the derived class.
		public virtual void Move() { }
		public virtual void Stop() { }
    }
}
