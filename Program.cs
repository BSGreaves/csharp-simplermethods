using System;
using System.Collections;
using System.Collections.Generic;

namespace simplermethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Bug Spider = new Bug("Spider", "Palystes castaneus", new List<string>(){"Bird", "Mouse"}, new List<string>(){"Beetle", "Fly"});
            Console.WriteLine(Spider.Name);
            foreach (string prey in Spider.Prey) 
            {
                Console.WriteLine(prey);
            }
            Console.WriteLine(Spider.Eat("Fly"));
        }
        public class Bug
        {
            public string Name { get; } = "";
            public string Species { get; } = "";
            public ICollection<string> Predators { get; } = new List<string>();
            public ICollection<string> Prey { get; } = new List<string>();
            public string FormalName => $"{Name} the {Species}";
            public Bug(string name, string species, List<string> predators, List<string> prey)
            {
                this.Name = name;
                this.Species = species;
                this.Predators = predators;
                this.Prey = prey;
            }
            public string PreyList => string.Join(",", Prey);
            public string PredatorList => string.Join(",", Predators);
            public string Eat(string food) => Prey.Contains(food) ? $"{Name} ate the {food}." : $"{Name} is still hungry.";
        }
    }
}
