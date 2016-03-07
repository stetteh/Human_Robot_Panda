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

            human.DisplayName();
            human.DisplayGreeting();

            Console.ReadLine();
        }
    }
}
