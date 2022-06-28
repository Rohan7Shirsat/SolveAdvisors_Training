using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
	public class DriverClass
	{
		public static void Main(string[] args)
		{
			string str = "Rohan";
			Console.WriteLine("Original String :-" + str);
			str.Reverse();
			Console.WriteLine();
			Console.WriteLine("String Reverse By Recurrsion :-" + str.RecursionForStringReverse());
			Console.Write("After Changing First character : - ");
			str.ChangeCaseOfFirstLetter();

		}
	}
}


