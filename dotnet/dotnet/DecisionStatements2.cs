using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet
{
	class DecisionStatements2
	{
		static void main(string[] args)
		{

			int age = 20;

			if (age >= 18)
			{
				Console.WriteLine("You are old enough to vote!");
				Console.WriteLine("Congratulations!");
			}
			Console.ReadKey();
		}
	}
}
