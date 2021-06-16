using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Term_project
{
    class Moon:Space_objects
    {
        string planetName;
        public Moon(string planetName, string name)
        {
            this.planetName = planetName;
            this.Name = name; //*
        }

        public string PlanetName { get => planetName; set => planetName = value; }
    }
}
