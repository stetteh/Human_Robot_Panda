using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Robot_Panda
{
    class Human : Parent
    {
        //public string Name { get; set;  }
        // public string Food { get; set; }
        //public bool Asleep = false;

        public override void DisplayName()
        {
            Console.WriteLine($"my name is {this.Name}");
        }

        public override void DisplayGreeting()
        {
            Console.WriteLine($"Helllo!! {Name}");
        }

        public void GoToSleep()
        {
            Asleep = true;
        }

        public void WakeUp()
        {
            Asleep = false;
        }

        public override void Eat()
        {
            Console.WriteLine($"Yum i ate {food}");
        }

        public void IsAsleep()
        {
            if (Asleep)
            {
                Console.WriteLine($"{Name} is asleep");
            }
        }
    }
}
