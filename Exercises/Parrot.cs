using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduction_to_oop_project.Exercises
{
    //Class Parrot Extends Bird
    public class Parrot : Bird
    {
        public Parrot(string name, string color) : base(name, color)
        {
        }
        //@override
        //print a message on video
        public override void Speak()
        {
            Console.WriteLine($"Hi! I'm {Name} and I'm a {Color} parrot and I'm a {Color} parrot and I'm a {Color} parrot.");
        }
    }
}
