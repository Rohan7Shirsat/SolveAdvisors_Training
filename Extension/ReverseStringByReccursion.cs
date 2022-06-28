using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{

	public static class ReverseStringByRecursion
	{
		public static string RecursionForStringReverse(this string input)
		{

			if (input.Length > 0)
				return input[input.Length - 1] + RecursionForStringReverse(input.Substring(0, input.Length - 1));
			else
				return input;

		}
	}
}
