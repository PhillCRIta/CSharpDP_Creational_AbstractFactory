using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_AbstractFactory
{
	internal interface ICarTransmission
	{
		string GetTransmission();
		int GetNumberGears();
	}
}
