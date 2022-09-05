using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduction_to_oop_project.Exercises
{
    //The Pigeon extends the base class Bird
    public class Pigeon : Bird
    {
        //The Pigeon constructor calls the base class Bird constructor
        //The name and color parameters are passed to the Bird constructor
        public Pigeon(string name, string color) : base(name, color)
        {
        }
        //print in output the message "Delicious pizza!"
        public void EatPizza()
        {
            Console.WriteLine("Delicious pizza!");
        }
        //print in output the message "I'm a sleeping pigeon"
        public void Sleep() 
        {
            Console.WriteLine("I'm a sleeping pigeon");
        }
        //@override
        //print in output the message "I'm a sleeping pigeon"
        public override void Speak()
        {
            Console.WriteLine($"Yo! I'm {Name} and I'm a {Color} pigeon.");
        }
    }
}
