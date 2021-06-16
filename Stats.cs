using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Term_project
{
    class Stats
    {
        public List<Galaxy> galaxies = new List<Galaxy>();
        public List<Star> stars = new List<Star>();
        public List<Planet> planets = new List<Planet>();
        public List<Moon> moons = new List<Moon>();



        public void AddGalaxyToList(string name, string type, string age)
        {
            Galaxy newGalaxy = new Galaxy(name, type, age);
            galaxies.Add(newGalaxy);
        }

        public void AddStarToList(string galaxyName, string name, double mass, double size, int temperature, double luminosity)
        {
            Star newStar = new Star(galaxyName, name, mass, size, temperature, luminosity);
            newStar.ClassifyStar();
            stars.Add(newStar);
        }

        public void AddPlanetToList(string starName, string name, string type, string habitability)
        {
            Planet newPlanet = new Planet(starName, name, type, habitability);
            newPlanet.TypeValidity();
            planets.Add(newPlanet);
        }

        public void AddMoonToList(string planetName, string name)
        {
            Moon newMoon = new Moon(planetName, name);
            moons.Add(newMoon);
        }


        public void PrintGalaxy(string galaxyName)
        {
            Galaxy targetGalaxy = null;
            Console.WriteLine($"--- Data for {galaxyName} galaxy ---");
            foreach (Galaxy galaxy in galaxies)
            {
                if (galaxy.Name.Equals(galaxyName))
                {
                    targetGalaxy = galaxy;
                }

            }
            if (targetGalaxy != null) 
            {
                Console.WriteLine("Type: " + targetGalaxy.Type);
                Console.WriteLine("Age: " + targetGalaxy.Age);
                Console.WriteLine("Stars: ");
                foreach (Star star in stars)
                {
                    if (star.GalaxyName.Equals(galaxyName))
                    {
                        Console.WriteLine("\t-  Name: " + star.Name);
                        Console.WriteLine("\t   Class: " + star.StarClass + " " + "(" + star.Mass + ", " + star.Size / 2 + ", " + star.Temperature + ", " + star.Luminosity + ")");
                        Console.WriteLine("\t   Planets:");
                        foreach (Planet planet in planets)
                        {

                            if (planet.StarName.Equals(star.Name))
                            {
                                Console.WriteLine("\t\to  Name: " + planet.Name);
                                Console.WriteLine("\t\t   Type: " + planet.Type);
                                Console.WriteLine("\t\t   Support life: " + planet.Habitability);
                                Console.WriteLine("\t\t   Moons:");
                                foreach (Moon moon in moons)
                                {
                                    if (moon.PlanetName.Equals(planet.Name))
                                    {
                                        Console.WriteLine("\t\t\t>  " + moon.Name);
                                    }
                                }
                            }
                        }
                    }

                }
            }
            Console.WriteLine($"--- End of data {galaxyName} galaxy ---");
        }

        public void PrintGalaxies()
        {
            string galaxyNames = "";
            Console.WriteLine("--- List of all researched galaxies ---");
            foreach (Galaxy galaxy in galaxies)
            {
                galaxyNames += galaxy.Name + ", ";

            }
            Console.WriteLine(galaxyNames.Remove(galaxyNames.Length - 2));
            Console.WriteLine("--- End of galaxies list ---");
        }

        public void PrintStars()
        {
            string starNames = "";
            Console.WriteLine("--- List of all researched stars ---");
            foreach (Star star in stars)
            {
                starNames += star.Name + ", ";
            }
            Console.WriteLine(starNames.Remove(starNames.Length - 2));
            Console.WriteLine("--- End of stars list ---");
        }

        public void PrintPlanets()
        {
            string planetNames = "";
            Console.WriteLine("--- List of all researched planets ---");
            foreach (Planet planet in planets)
            {
                planetNames += planet.Name + ", ";
            }
            Console.WriteLine(planetNames.Remove(planetNames.Length - 2));
            Console.WriteLine("--- End of planets list ---");
        }

        public void PrintMoons()
        {
            string moonNames = "";
            Console.WriteLine("--- List of all researched moons ---");
            foreach (Moon moon in moons)
            {
                moonNames += moon.Name + ", ";
            }
            Console.WriteLine(moonNames.Remove(moonNames.Length - 2));
            Console.WriteLine("--- End of moons list ---");
        }

        
    }
}
