using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    abstract class Location
    {
        public Location(string name)
        {
            Name = name;
        }

        public Location[] Exits;

        public string Name { get; private set; }

        public virtual string Description
        {
            get
            {
                string description = "Stoisz w: " + Name
                    + ". Widzisz wejścia do następujących lokalizacji: ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;
                    if (i != Exits.Length - 1)
                        description += ",";
                }
                description += ".";
                return description;
            }
        }
    }
}
