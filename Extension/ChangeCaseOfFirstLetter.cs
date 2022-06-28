using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extension;

namespace Extension
{

	public static class ChangeCaseOfFirstLetterOfStrng
	{
        public static void ChangeCaseOfFirstLetter(this string input)
		{
			if (char.IsUpper(input[0]) == true)
			{
				Console.WriteLine(char.ToLower(input[0]) + input.Substring(1));
			}
			else
			{
				Console.WriteLine(char.ToUpper(input[0]) + input.Substring(1));
			}

		}

	}
}
