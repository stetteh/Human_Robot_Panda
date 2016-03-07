using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Robot_Panda
{
    class Robot
    {
        public string Name { get; set; }
        public bool Terminator = false;
        public bool IsShutdown = true;

        public void DisplayName()
        {
            Console.WriteLine($"my name is {Name}");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine($"Hello!!!!! { Name} ");
        }
      
        public void StartUp()
        {
            Console.WriteLine("Robot has Started!!!");
        }

        
        public void ShutDown()
        {
            Console.WriteLine("Robot has Shutdown");

        }

        public void IsTerminator()
        {
            if (Terminator)
            {
                Console.WriteLine("It is a Terminator");
            }
            else
            {
                Console.WriteLine("It is not a Terminator");
            }
        }

        public void IsAsleep()
        {
            if (IsShutdown)
            {
                Console.WriteLine("robot is shutdown");
            }
        }
    }
}
