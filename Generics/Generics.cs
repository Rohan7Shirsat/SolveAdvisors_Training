using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    class Test
    {
        public static void Convertor<T>(string input)
        {
            switch (typeof(T).Name)
            {
                case "Int32":
                    var result1 = int.Parse(input);
                    Console.WriteLine(result1);
                    break;

                case "DateTime":
                    var result2 = DateTime.Parse(input);
                    Console.WriteLine(result2);
                    break;

            }

        }


    }
}
