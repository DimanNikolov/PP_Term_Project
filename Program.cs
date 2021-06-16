using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Term_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("USER MANUAL:");
            Console.WriteLine("Use the \"add\" keyword, accompanied with the space object you want to input; e.g. \"add galaxies\";");
            Console.WriteLine("Use the \"list\" keyword, accompanied with the space objects you want to be displayed; e.g. \"list galaxies\";");
            Console.WriteLine("Use the \"stats\" keyword to display all input space objects;");
            Console.WriteLine("Use \"print\" + the name of the space object to show all its info;");
            Console.WriteLine("Use \"exit\" to close the console.");
            Console.WriteLine();
            Stats stats = new Stats();
            string currentCommand = Console.ReadLine();
            string[] commandWords = FormatCommand(currentCommand.Split(' '));

            while (true)
            {
                if (commandWords[0].Equals("exit"))
                {
                    break;
                }

                ExecuteCommand(commandWords, stats);
                currentCommand = Console.ReadLine();
                commandWords = FormatCommand(currentCommand.Split(' '));

            }

        }

        public static string[] FormatCommand(string[] commandWords)
        {
            List<string> correctCommand = new List<string>();
            for (int i = 0; i < commandWords.Length; i++)
            {
                string currentWord = commandWords[i];  
                if (commandWords[i].StartsWith("[") && !commandWords[i].EndsWith("]"))
                {
                    for (int j = i + 1; j < commandWords.Length; j++)
                    {
                        i++;
                        currentWord = currentWord + " " + commandWords[j];
                        if (!commandWords[j].EndsWith("]"))
                        {
                            continue;
                        }

                        else
                        {
                            break;
                        }
                    }
                }
                correctCommand.Add(currentWord);
            }
            return correctCommand.ToArray();
        }
        public static void ExecuteCommand(string[] commandWords, Stats stats)
        {

            if (commandWords[0].Equals("add"))
            {
                if (commandWords[1].Equals("star"))
                {
                    stats.AddStarToList(FormatName(commandWords[2]), FormatName(commandWords[3]), Double.Parse(commandWords[4]), Double.Parse(commandWords[5]), Int16.Parse(commandWords[6]), Double.Parse(commandWords[7]));
                }

                else if (commandWords[1].Equals("moon"))
                {
                    stats.AddMoonToList(FormatName(commandWords[2]), FormatName(commandWords[3]));
                }

                else if (commandWords[1].Equals("galaxy"))
                {
                    if (TypeValidity(commandWords[3]))
                    {
                        stats.AddGalaxyToList(FormatName(commandWords[2]), commandWords[3], commandWords[4]);
                    }
                    else
                    {
                        Console.WriteLine("You have entered an invalid galaxy type! Your galaxy was not added!");
                        Console.WriteLine("Please enter one of the following options as your galaxy type: ");
                        Console.WriteLine("elliptical, lenticular, spiral or irregular.");
                    }
                }

                else if (commandWords[1].Equals("planet"))
                {
                    stats.AddPlanetToList(FormatName(commandWords[2]), FormatName(commandWords[3]), commandWords[4], commandWords[5]);
                }
            }

            else if (commandWords[0].Equals("list"))
            {
                if (commandWords[1].Equals("stars"))
                {
                    if (stats.stars.Any())
                    {
                        stats.PrintStars();
                    }
                    else
                    {
                        Console.WriteLine("There are no stars in the list!");
                    }
                }

                else if (commandWords[1].Equals("moons"))
                {
                    if (stats.moons.Any())
                    {
                        stats.PrintMoons();
                    }
                    else
                    {
                        Console.WriteLine("There are no moons in the list!");
                    }
                }

                else if (commandWords[1].Equals("planets"))
                {
                    if (stats.planets.Any())
                    {
                        stats.PrintPlanets();
                    }
                    else
                    {
                        Console.WriteLine("There are no planets in the list!");
                    }
                }

                else if (commandWords[1].Equals("galaxies"))
                {
                    if (stats.galaxies.Any())
                    {
                        stats.PrintGalaxies();
                    }
                    else
                    {
                        Console.WriteLine("There are no galaxies in the list!");
                    }
                }
                
            }

            else if (commandWords[0].Equals("stats"))
            {
                Console.WriteLine("--- Stats ---");
                Console.WriteLine("Galaxies: " + stats.galaxies.Count);
                Console.WriteLine("Stars: " + stats.stars.Count);
                Console.WriteLine("Planets: " + stats.planets.Count);
                Console.WriteLine("Moons: " + stats.moons.Count);
                Console.WriteLine("--- End of stats ---");
            }

            else if (commandWords[0].Equals("print"))
            {
                stats.PrintGalaxy(FormatName(commandWords[1]));
            }


            else if (!commandWords[0].Equals("add") && !commandWords[0].Equals("list") && !commandWords[0].Equals("stats") && !commandWords[0].Equals("print"))
            {
                Console.WriteLine("Unknown command!");
            }
        }

        public static string FormatName(string name)
        {
            return name.Replace('[', ' ').Replace(']', ' ').Trim();
        }

        public static bool TypeValidity(string galaxyType)
        {
            if (!Enum.IsDefined(typeof(GalaxyType), galaxyType))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
