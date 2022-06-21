
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SingltonWithLock
{
    sealed class VotingMachine
    {
        private static VotingMachine Instance = null;
        private VotingMachine()
        {
            Console.WriteLine("Constructor called");
        }

        public static VotingMachine getInstance
        {
            get
            {
                lock (Instance)
                {
                    if (Instance == null)
                    Instance = new VotingMachine();
                return Instance;
                }
            }
        }

        public void DoVoting()
        {
           
                Console.WriteLine("Voter doing his/her voting");

           
        }
    }

    class Voter
    {
        public static void Main(String[] args)
        {
            VotingMachine voter1 = VotingMachine.getInstance;
            voter1.DoVoting();

            VotingMachine voter2 = VotingMachine.getInstance;
            voter2.DoVoting();
        }


    }
}

