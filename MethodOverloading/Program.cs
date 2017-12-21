using System;
using MethodOverloading.Objects;

using static System.Console;
using console = System.Console;

namespace MethodOverloading
{
    class Program
    {
		static void Main(string[] args)
        {
			var calculate = new Calculate();
			WriteLine("Polymorphism com sobrecarga");
			WriteLine("Adding 2 numbers...");
			WriteLine(calculate.Sum(10, 18));
			WriteLine("Adding 3 numbers...");
			WriteLine(calculate.Sum(25, 34, 125));
			ReadKey();

		}
    }
}
