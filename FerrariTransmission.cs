using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_AbstractFactory
{
	internal class FerrariTransmission : ICarTransmission
	{
		public int GetNumberGears()
		{
			return 10;
		}

		public string GetTransmission()
		{
			return "Automatic";
		}
	}
}
