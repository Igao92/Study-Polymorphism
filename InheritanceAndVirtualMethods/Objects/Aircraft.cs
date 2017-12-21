using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndVirtualMethods.Objects
{
    public class Aircraft : Vehicle
    {
		//'base(...)'->Executes the base constructor.
		public Aircraft(EnumVehicleType vehicleType) : base(vehicleType){}

		//'override' modifier change de default behavior of method
		public override void Move() => Console.Write("Taking off the aircraft.");
		public override void Stop() => Console.Write("Landing the aircraft.");
		
	}
}
