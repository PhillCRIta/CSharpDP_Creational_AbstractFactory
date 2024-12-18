using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_AbstractFactory
{
	internal class AudiFactory : ICarFactory
	{
		public ICarColor CreateCarColor()
		{
			return new AudiColor();
		}

		public ICarEngine CreateCarEngine()
		{
			return new AudiEngine();
		}

		public ICarTransmission CreateTransmission()
		{
			return new AudiTransmission();
		}
	}
}
