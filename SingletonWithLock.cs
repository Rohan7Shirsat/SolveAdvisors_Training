
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SingltonWithLock
{
    sealed class Chess
    {
        private static Chess Instance = null;
        private Chess()
        {
            Console.WriteLine("Constructor called");
        }

        public static Chess getInstance
        {
           
            get
            {
                lock (Instance)
                {
                    if (Instance == null)
                        Instance = new Chess();
                    return Instance;
                }
            }
        }

        public void Play()
        {
            lock (this)
            {
                Console.WriteLine("Player playing his/her move");
                Thread.Sleep(2000);
            }
        }
    }

    class Player
    {
        public static void Main(String[] args)
        {
            Chess Player1 = Chess.getInstance;
            Player1.Play<>();

            Chess Player2 = Chess.getInstance;
            Player2.Play();
        }


    }
}

