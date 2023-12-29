using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec29Console
{
    public abstract class Vehicle
    {
        public abstract void Start(); 
        public abstract void Stop();
      
    }
    public class Car : Vehicle { 
        public override void Start() { 
            Console.WriteLine("car start by key Igneation"); 
        } 
        public override void Stop() { 
            Console.WriteLine("Car Stoped by pressing Break"); 
        } 
    }

    public class Train : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Train runs by Power ON");
        }
        public override void Stop() { 
            Console.WriteLine("Train stops by Power OFF"); 
        }
    }

internal class AbstractClassEg2
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car();
            car.Start();
            car.Stop();
            Vehicle train = new Train();
            train.Start();
            train.Stop();
            Console.ReadLine();

        }
    }
}
