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
        public string Greeting { get; set; }
        public string Food { get; set; }
        public bool Asleep = false;
        public string Wakeup { get; set; }
        public string Sleep { get; set; }

        public void DisplayName(string name)
        {
            Console.WriteLine($"my name is {name}");
        }

        public void DisplayGreeting(string greeting)
        {
            Console.WriteLine($"{greeting}");
        }

        public void Eat()
        {
            Console.WriteLine($"Yum i ate {Food}");
        }

        public string GoToSleep(string sleep)
        {
            return Sleep;
        }

        public string WakeUp()
        {
            return Wakeup;
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
