using System;

namespace introduction_to_oop_project.Exercises
{
    public class Bird
    {
        public string Name { get; private set; }
        public string Color { get; private set; }

        public Bird(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public void Speak()
        {
            Console.WriteLine($"My name is {Name} and I am a {Color} bird.");
        }

        public void Fly()
        {
            Console.WriteLine($"I'm {Name} and I can fly high in the blue sky!");
        }
    }
}