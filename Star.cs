using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Term_project
{
    class Star:Space_objects
    {
        string galaxyName;
        char starClass;
        int temperature;
        double luminosity;
        double mass;
        double size; //radius


        public char StarClass { get => starClass; set => starClass = value; }
        public string GalaxyName { get => galaxyName; set => galaxyName = value; }
        public int Temperature { get => temperature; set => temperature = value; }
        public double Luminosity { get => luminosity; set => luminosity = value; }
        public double Mass { get => mass; set => mass = value; }
        public double Size { get => size; set => size = value; }

        public Star(string galaxyName, string name, double mass, double size, int temperature, double luminosity)
        {
            this.galaxyName = galaxyName;
            this.Name = name; //*
            this.temperature = temperature;
            this.luminosity = luminosity;
            this.mass = mass;
            this.size = size;
        }

        public void ClassifyStar()
        {
            double radius = this.size / 2;
            if (this.temperature >= 30000 && this.luminosity >= 30000 && this.mass >= 16 && radius >= 6.6) 
            {
                this.starClass = 'O';
            }

            else if (this.temperature > 10000 && this.temperature < 30000 && this.luminosity > 25 && this.luminosity < 30000 && this.mass > 2.1 && this.mass < 16 && radius > 1.8 && radius < 6.6)            
            {
                this.starClass = 'B';
            }

            else if (this.temperature > 7500 && this.temperature < 10000 && this.luminosity > 5 && this.luminosity < 25 && this.mass > 1.4 && this.mass < 2.1 && radius > 1.4 && radius < 1.8)
            {
                this.starClass = 'A';
            }

            else if (this.temperature > 6000 && this.temperature < 7500 && this.luminosity > 1.5 && this.luminosity < 5 && this.mass > 1.04 && this.mass < 1.4 && radius > 1.15 && radius < 1.4)
            {
                this.starClass = 'F';
            }

            else if (this.temperature > 5200 && this.temperature < 6000 && this.luminosity > 0.6 && this.luminosity < 1.5 && this.mass > 0.8 && this.mass < 1.04 && radius > 0.96 && radius < 1.15)
            {
                this.starClass = 'G';
            }

            else if (this.temperature > 3700 && this.temperature < 5200 && this.luminosity > 0.08 && this.luminosity < 0.6 && this.mass > 0.45 && this.mass < 0.8 && radius > 0.7 && radius < 0.96)
            {
                this.starClass = 'K';
            }

            else if (this.temperature > 2400 && this.temperature < 3700 && this.luminosity <= 0.08 && this.mass > 0.08 && this.mass < 0.45 && radius <= 0.7)
            {
                this.starClass = 'M';
            }

        }
        

    }
}
