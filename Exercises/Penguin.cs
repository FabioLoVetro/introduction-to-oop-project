using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduction_to_oop_project.Exercises
{
    //Class Penguin Extends Bird
    public class Penguin : Bird
    {
        public Penguin(string name, string color) : base(name, color)
        {
        }
        //@override
        //Print a message on video
        public override void Speak()
        {
            Console.WriteLine($"Hi! I'm {Name} and I'm a {Color} penguin.");
        }
        //@override
        //Print a message on video
        public override void Fly()
        {
            Console.WriteLine($"Whoops, I can't fly. Waddle waddle.");
        }
    }

}
