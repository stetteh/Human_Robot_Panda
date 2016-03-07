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
        public bool Asleep = false;

        public void DisplayName()
        {
            Console.WriteLine($"my name is {this.Name}");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine($"Helllo!! {Name}");
        }

        public string GoToSleep()
        {
            return Sleep;
        }

        public string WakeUp()
        {
            return Wake;
        }

        public void Eat()
        {
            Console.WriteLine($"Yum i ate {this.Food}");
        }

        public void IsAsleep()
        {
            if (Asleep)
            {
                Console.WriteLine($"Human is asleep");
            }
        }
    }
}
