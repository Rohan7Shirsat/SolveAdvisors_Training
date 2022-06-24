using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    abstract class Car
    {

      //  1)Encasulation
        private int vehicle_id;
        
        public int Vehicle_id 
        {
            get
            {
                return vehicle_id;
            }
            set
            {
                if(value > 0)
                {
                    vehicle_id = value;
                    Console.WriteLine("Vehicle id is : "+vehicle_id);
                }
                else
                {
                    Console.WriteLine("Write valid vehicle id !");
                }
            }
        }

        // 2)Abstraction
        public abstract void getMilage(int a);

        //3)Method Overloading
        public virtual void Run()
        {
            Console.WriteLine("Car is running");
        }
        public void Run(int a)
        {
            Console.WriteLine("Car is running at speed of " + a + " kmph");
        }

        
    }

    class FuelBased : Car 
    {
       
      //Implimentation of abstract method
        public override void getMilage(int a)
        {
            Console.WriteLine("Milage of Swift is " + a );
        }

        //Method Overriding
        public override void Run()
        {
            Console.WriteLine("Car is still running...");
        }

        //Implimentation
        public static void Main(string[] args)
        {
            Car swift  =new FuelBased();
           
            
            swift.Run();
            swift.Run(60);

            swift.getMilage(12);

            Console.WriteLine("Enter the vehicle id :");
            int num =Convert.ToInt32(Console.ReadLine());
            swift.Vehicle_id = num;
           
            
        }

    }
}
