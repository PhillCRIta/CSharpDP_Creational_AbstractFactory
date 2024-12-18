using System.Diagnostics;

namespace Creational_AbstractFactory
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* CREATIONAL
			 * MANAGE THE BUILDING PROCESS OF MULTIPLE OBJECTS
			 * IS POSSIBILE USING TOGETHER WITH A FACTORY TO SIMPLIFY THE MULTIPLE OBJECTS CREATION
			 * BASED ON PARAMETER YOU CAN CREATE AUTOMATICALLY A DESIDERD OBJECT
			 * Provides an interface for creating families of related or dependent objects without specifying their concrete classes
			 */
			//ABSTRACT FACTORY
			ICarFactory factory = new FerrariFactory();
			CreateCar(factory, "turbo ferrari engine");
			Console.WriteLine("");
			factory = new AudiFactory();
			CreateCar(factory, "audi diesel engine");
			Console.WriteLine(""); Console.WriteLine("");
			//UNTIL HERE, THERE IS A SIMPLE ABSTRACT FACTORY
			//TO IMPROVE THE ABSTRACT FACTORY, AND HIDE THE CONRETE INSTANTIATION, YOU CAN CREATE A FACTORY (pattern) THAT CREATE FACTORIES
			//NOW WE WILL USE THE CARGENERATOR CLASS LIKE A FACTORY
			CarType carType = CarType.FERRARI;
			ICarTransmission transmission = CarsGenerator.CreateTransimission(carType);
			ICarColor color = CarsGenerator.CreateColor(carType);
			ICarEngine engine = CarsGenerator.CreateEngine(carType);
			engine.EnigneStart(carType.ToString());
			Console.WriteLine($"The car has {transmission.GetNumberGears()} gears and {transmission.GetTransmission()} transmission");
			Console.WriteLine($"The color of car is {color.GetColor()}, you can choose between following colors: {String.Join(", ", color.ListColor())}");

			carType = CarType.AUDI;
			transmission = CarsGenerator.CreateTransimission(carType);
			color = CarsGenerator.CreateColor(carType);
			engine = CarsGenerator.CreateEngine(carType);
			engine.EnigneStart(carType.ToString());
			Console.WriteLine($"The car has {transmission.GetNumberGears()} gears and {transmission.GetTransmission()} transmission");
			Console.WriteLine($"The color of car is {color.GetColor()}, you can choose between following colors: {String.Join(", ", color.ListColor())}");
			Debug.WriteLine("");
		}

		private static void CreateCar(ICarFactory factory, string engineType)
		{
			ICarEngine engine = factory.CreateCarEngine();
			ICarTransmission transmission = factory.CreateTransmission();
			ICarColor color = factory.CreateCarColor();
			engine.EnigneStart(engineType);
			Console.WriteLine($"The car has {transmission.GetNumberGears()} gears and {transmission.GetTransmission()} transmission");
			Console.WriteLine($"The color of car is {color.GetColor()}, you can choose between following colors: {String.Join(", ", color.ListColor())}");
		}
	}
}
