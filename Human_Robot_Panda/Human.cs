using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Robot_Panda
{
    class Human
    {
        public string Name { get; set;  }
        public string Sleep { get; set; }
        public string Wake { get; set; }
        public string Food { get; set; }
        public bool Asleep = true;

        public void DisplayName()
        {
            Console.WriteLine($"my name is {this.Name}");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine($"Helllo!! {Name}");
        }

        public string GoToSleep(string sleep)
        {
            return sleep;
        }

        public string WakeUp(string wake)
        {
            return wake;
        }

        public void Eat()
        {
            Console.WriteLine($"Yum i ate {this.Food}");
        }

        public void IsAsleep(bool asleep)
        {
            if (asleep)
            {
                Console.WriteLine($"Human is asleep");
            }
        }
    }
}
