using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Robot_Panda
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Name = "Seth Quaye";
            human.Food = "Taco";
            human.Asleep = true;

            human.DisplayName();
            human.DisplayGreeting();
            human.Eat();
            human.IsAsleep();

            Robot robot = new Robot();
            robot.Terminator = true;

            robot.StartUp();
            robot.ShutDown();
            robot.IsTerminator();

            Panda panda = new Panda();
            panda.Food = "Bamboo and Sugar Cane";
            panda.Asleep = true;

            panda.Eat();
            panda.IsAsleep();

            Console.ReadLine();
        }
    }
}
