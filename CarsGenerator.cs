using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_AbstractFactory
{
	internal class CarsGenerator
	{
		public static ICarColor CreateColor(CarType carType)
		{
			switch (carType)
			{
				case CarType.AUDI:
					return new AudiColor();
					break;
				case CarType.FERRARI:
					return new FerrariColor();
					break;
				default:
					throw new InvalidOperationException("Car type not set");
					break;
			}
		}

		public static ICarEngine CreateEngine(CarType carType)
		{
			switch (carType)
			{
				case CarType.AUDI:
					return new AudiEngine();
					break;
				case CarType.FERRARI:
					return new FerrariEngine();
					break;
				default:
					throw new InvalidOperationException("Car type not set");
					break;
			}
		}

		public static ICarTransmission CreateTransimission(CarType carType)
		{
			switch (carType)
			{
				case CarType.AUDI:
					return new AudiTransmission();
					break;
				case CarType.FERRARI:
					return new FerrariTransmission();
					break;
				default:
					throw new InvalidOperationException("Car type not set");
					break;
			}
		}

	}
}
