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
        public string message { get; set; }
        public bool terminator = false;
        public bool asleep = true;

        public void DisplayName(string name)
        {
            Console.WriteLine($"my name is {name}");
        }

        public void DisplayGreeting(string greeting)
        {
            Console.WriteLine($"{greeting}");
        }
      
        public void StartUp(string message)
        {
            Console.WriteLine($"Message is {this.message}");
        }

        
        public void ShutDown(string message)
        {
            Console.WriteLine($"Message is {this.message}");

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

        public void IsAsleep(bool asleep, string message)
        {
            if (asleep)
            {
                Console.WriteLine($"");
            }
        }
    }
}
