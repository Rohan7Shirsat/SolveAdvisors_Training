using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic;

namespace Generic
{

    class Test 
    {

        public static void Convertor<T> (string s )
        {
           
            Console.WriteLine(Convert.ChangeType( s, typeof (T)));
        }
    }
    class DriverClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose the option: -");
            Console.WriteLine("1) Convert into Integer");
            Console.WriteLine("2) Convert into DateTime");
            int a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Write String :-");
            string s=Console.ReadLine();
            if (a == 1)
            {
                Test.Convertor<int>(s);
            }
            else if(a == 2)
            {
                Test.Convertor<DateTime>(s);
            }
            else
            {
                Console.WriteLine("Please select correct option :-");
            }

        }

    }
    
}