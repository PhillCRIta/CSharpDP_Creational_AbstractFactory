using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_AbstractFactory
{
	internal class AudiEngine : ICarEngine
	{
		public void EnigneStart(string typeEngine)
		{
            Console.WriteLine($"Audi Engine is starting, type: {typeEngine}");
		}
	}
}
