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

			Console.Write("String Reverse By for Loop :-");
			for (int i=0;i<array.Length;i++)
            {
				reverse[array.Length-i-1] = array[i];
            }

			for (int i = 0; i < reverse.Length; i++)
            {
				Console.Write(reverse[i]);
            }


		}
	}

	

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

	public static class ChangeCase
	{
		public static void ChangeCaseOfFirstLetter(this string input)
		{ 
		    if (char.IsUpper(input[0])==true)
            {
				Console.WriteLine(char.ToLower(input[0]) + input.Substring(1));
            }
            else
            {
				Console.WriteLine(char.ToUpper(input[0]) + input.Substring(1));
			}

		}

	}

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
