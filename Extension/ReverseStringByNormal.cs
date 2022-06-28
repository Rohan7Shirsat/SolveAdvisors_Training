using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
	public static class ReverseStringByNormal
	{
		public static void Reverse(this string input)
		{
			char[] array = input.ToCharArray();
			char[] reverse = new char[array.Length];

			Console.Write("String Reverse By Normal Method :-");
			for (int i = 0; i < array.Length; i++)
			{
				reverse[array.Length - i - 1] = array[i];
			}

			for (int i = 0; i < reverse.Length; i++)
			{
				Console.Write(reverse[i]);
			}


		}
	}
}
