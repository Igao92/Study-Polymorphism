using System;
using System.Collections.Generic;
using InheritanceAndVirtualMethods.Objects;

namespace InheritanceAndVirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
			var vehicles = new List<Vehicle>();
			vehicles.Add(new Car(EnumVehicleType.Car));
			vehicles.Add(new Aircraft(EnumVehicleType.Aircraft));

			Morph(vehicles[0]);
			Morph(vehicles[1]);

			Console.Read();
		}

		public static void Morph(Vehicle vehicle)
		{
			Console.WriteLine(vehicle.Type);
			vehicle.Move();
		}
    }
}
