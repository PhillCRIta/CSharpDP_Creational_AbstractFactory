using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_AbstractFactory
{
	internal class AudiColor : ICarColor
	{
		public string GetColor()
		{
			return "Grey";
		}

		public List<string> ListColor()
		{
			return new List<string>() { "Grey", "Black", "Blue"};
		}
	}
}
