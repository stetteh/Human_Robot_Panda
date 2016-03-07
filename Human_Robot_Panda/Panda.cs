using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Robot_Panda
{
    class Panda
    {
        public string name { get; set; }
        public string greeting { get; set; }
        public string food { get; set; }
        public bool asleep = true;

        public void DisplayName(string name)
        {
            Console.WriteLine($"my name is {name}");
        }

        public void DisplayGreeting(string greeting)
        {
            Console.WriteLine($"{greeting}");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Yum i ate {food}");
        }

        public string GoToSleep(string sleep)
        {
            return sleep;
        }

        public string WakeUp(string wake)
        {
            return wake;
        }

        public void IsAsleep(bool asleep)
        {
            if (asleep)
            {
                Console.WriteLine($"Panda is asleep");
            }
        }
    }
}
