using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Term_project
{
    class Planet:Space_objects
    {
        string starName;
        string type;
        string habitability;


        public Planet(string starName, string name, string type, string habitability)
        {
            this.starName = starName;
            this.Name = name; //*
            this.type = type;
            this.habitability = habitability;
        }

        public string StarName { get => starName; set => starName = value; }
        public string Type { get => type; set => type = value; }
        public string Habitability { get => habitability; set => habitability = value; }


        public void TypeValidity()
        {
            if (Type != "terrestrial" && Type != "giant planet" && Type != "ice giant" && Type != "mesoplanet" && Type != "mini-neptune" && Type != "planetar" && Type != "super-earth" && Type != "super-jupiter" && Type != "sub-earth")
            {
                Console.WriteLine("Incorrect planet type!");
                Console.WriteLine("You should only enter one of the following types: terrestrial, giant planet, ice giant, mesoplanet, mini-neptune, planetar, super-earth, super-jupiter or sub-earth.");
            }
        }

    }
}
