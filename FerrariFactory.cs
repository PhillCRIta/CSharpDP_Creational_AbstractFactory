using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_AbstractFactory
{
	internal class FerrariFactory : ICarFactory
	{
		public ICarColor CreateCarColor()
		{
			return new FerrariColor();
		}

		public ICarEngine CreateCarEngine()
		{
			return new FerrariEngine();
		}

		public ICarTransmission CreateTransmission()
		{
			return new FerrariTransmission();
		}
	}
}
