using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Robot_Panda
{
    class Robot
    {
        public string name { get; set; }
        public string greeting { get; set; }
        public bool terminator = false;
        public bool shutdown = true;

        public void DisplayName(string name)
        {
            Console.WriteLine($"my name is {name}");
        }

        public void DisplayGreeting(string greeting)
        {
            Console.WriteLine($"{greeting}");
        }
      
        public void StartUp()
        {
            Console.WriteLine("Robot has Started!!!");
        }

        
        public void ShutDown()
        {
            Console.WriteLine("Robot has Shutdown");

        }

        public void IsTerminator(bool terminator)
        {
            if (terminator)
            {
                Console.WriteLine("It is not a Terminator");
            }
            else
            {
                Console.WriteLine("Its a Terminator");
            }
        }

        public void IsAsleep(bool shutdown)
        {
            if (shutdown)
            {
                Console.WriteLine("robot is shutdown");
            }
        }
    }
}
