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

            human.DisplayName();
            human.DisplayGreeting();
            human.Eat();

            Robot robot = new Robot();
            robot.StartUp();
            robot.ShutDown();

            Panda panda = new Panda();
            panda.Food = "Bamboo and Sugar Cane";

            panda.Eat();
            Console.ReadLine();
        }
    }
}
