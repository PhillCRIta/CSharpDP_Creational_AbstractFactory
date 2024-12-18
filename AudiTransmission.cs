using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_AbstractFactory
{
	internal class AudiTransmission : ICarTransmission
	{
		public int GetNumberGears()
		{
			return 6;
		}

		public string GetTransmission()
		{
			return "Manual";
		}
	}
}
