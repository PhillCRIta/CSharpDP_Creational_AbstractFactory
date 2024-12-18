using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_AbstractFactory
{
	internal class FerrariColor:ICarColor
	{
		public string GetColor()
		{
			return "Red";
		}

		public List<string> ListColor()
		{
			return new List<string>() { "Red", "Yellow", "Grey" };
		}
	}
}
