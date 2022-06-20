using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    interface Transport
    {
        public void Transportation();
    }

    class Tempo : Transport
    {
        public void Transportation()
        {
            Console.WriteLine("Transportation By Tempo");
        }
    }

    class Ship : Transport
    {
        public void Transportation()
        {
            Console.WriteLine("Transportation By ship");
        }
    }

    class FactoryClass
    {
        public static Transport GetTransportationType(String s)
        {
            if (s == null)
            {
                return null;
            }

            if (s == "Tempo")
            {
                return new Tempo();
            }
            else if (s == "Ship")
            {
                return new Ship();
            }
            else
                return null;
        }
    }

    class DriverClass
    {
        public static void Main(string[] args)
        {
           
            Transport Tempo = FactoryClass.GetTransportationType("Tempo");
            Tempo.Transportation();

            Transport Ship = FactoryClass.GetTransportationType("Ship");
            Ship.Transportation();
        }

    }

}
