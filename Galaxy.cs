using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Term_project
{
    class Galaxy:Space_objects 
    {
        string type;
        string age;


        public string Type { get => type; set => type = value; }

        public string Age { get => age; set => age = value; }


        public Galaxy(string name, string type, string age)
        {
            this.Name = name; //*
            this.type = type;
            this.age = age;
        }

        

    }
}
