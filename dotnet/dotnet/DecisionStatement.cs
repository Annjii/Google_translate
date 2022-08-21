using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet
{
    abstract class DecisionStatement
    {
		static void main(string[] args)
		{
				/*
				if (expression)
					// do this

				*/

				int age = 20;
				if (age >= 18)
					Console.WriteLine("You are old enough to vote!");


				Console.WriteLine("Have a nice day!");
				Console.ReadKey();
		
		}
	}
}