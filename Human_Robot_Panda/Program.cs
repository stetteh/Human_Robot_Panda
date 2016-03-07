﻿using System;
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
            //Instance of human
            Human human = new Human();
            human.Name = "Seth Quaye";
            human.Food = "Taco";
            human.Asleep = true;

            //function call
            human.DisplayName();
            human.DisplayGreeting();
            human.Eat();
            human.IsAsleep();

            //Instance of robot
            Robot robot = new Robot();
            robot.Terminator = true;

            //function call
            robot.StartUp();
            robot.ShutDown();
            robot.IsTerminator();

            //Instance of panda
            Panda panda = new Panda();
            panda.Food = "Bamboo and Sugar Cane";
            panda.Asleep = true;

            //function call
            panda.Eat();
            panda.IsAsleep();

            Console.ReadLine();
        }
    }
}
