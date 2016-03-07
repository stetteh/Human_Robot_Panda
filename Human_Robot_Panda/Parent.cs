using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Robot_Panda
{
    public abstract class Parent
    {
        public string Name { get; set; }
        public bool Asleep = false;
       // public string food { get; set; }


        public abstract void DisplayName();
        public abstract void DisplayGreeting();
        //public abstract void Eat();
    }

    public interface CanEat
    {
        void Eat(string food);
    }


}
