
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SingltonWithoutLock
{
    sealed class Settelite
    {
        private static Settelite Instance = null;
        private Settelite()
        {
            Console.WriteLine("Constructor called");
        }
      
        public static Settelite getInstance
        {
            get
            {
                if (Instance == null)
                    Instance = new Settelite();
                return Instance;
            }
        }

        public void RunThePicture()
        {
            Console.WriteLine("Picture is Running .... (Time - 1:45:50)");
          
        }
    }

    class CinemaHall
    {
        public static void Main(String[] args)
        {
            Settelite CinemaHall1 = Settelite.getInstance;
            CinemaHall1.RunThePicture();

            Settelite CinemaHall2= Settelite.getInstance;
            CinemaHall2.RunThePicture();
        }


    }
}

