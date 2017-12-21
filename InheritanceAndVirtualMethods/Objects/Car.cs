using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndVirtualMethods.Objects
{
    public class Car : Vehicle
    {
		//'base(...)'->Executes the base constructor.
		public Car(EnumVehicleType vehicleType) : base(vehicleType) { } 

		//'override' modifier change de default behavior of method
		public override void Move() => Console.WriteLine("Accelerating the car.");
		public override void Stop() => Console.WriteLine("Braking the car.");
	}
}
