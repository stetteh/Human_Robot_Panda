using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Robot_Panda
{
    class Panda
    {
        public string Name { get; set; }
        public string Food { get; set; }
        public bool Asleep = false;

        public void DisplayName()
        {
            Console.WriteLine($"my name is {this.Name}");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine($"Hello!!!!!!!! {Name} ");
        }

        public void Eat()
        {
            Console.WriteLine($"Yum i ate {Food}");
        }

        public void GoToSleep()
        {
            Asleep = true;
        }

        public void WakeUp()
        {
            Asleep = false;
        }

        public void IsAsleep()
        {
            if (Asleep)
            {
                Console.WriteLine($"Panda is asleep");
            }
        }
    }
}
