using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Robot_Panda
{
    class Panda : Parent, CanEat
    {
        

        public override void DisplayName()
        {
            Console.WriteLine($"my name is {this.Name}");
        }

        public override void DisplayGreeting()
        {
            Console.WriteLine($"Hello!!!!!!!! {Name} ");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Yum i ate {food}");
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
