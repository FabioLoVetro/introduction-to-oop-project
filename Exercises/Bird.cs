using System;

namespace introduction_to_oop_project.Exercises
{
    public abstract class Bird
    {
        public string Name { get; private set; }
        public string Color { get; private set; }

        public Bird(string name, string color)
        {
            Name = name;
            Color = color;
        }

        //I marked this method virtual keyword to give a default implementation.
        //If the method is marked with abstract keyword means
        //that any classes extending on Bird must implement this
        //Abstract methods don't have a method body
        public virtual void Speak()
        {
            //default implementation
            Console.WriteLine($"My name is {Name} and I am a {Color} bird.");
        }

        public virtual void Fly()
        {
            //default implementation
            Console.WriteLine($"I'm {Name} and I can fly high in the blue sky!");
        }
    }
}