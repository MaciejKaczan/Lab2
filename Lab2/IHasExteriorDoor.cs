using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    interface IHasExteriorDoor
    {
        private readonly string doorDescription;

        private readonly string doorLocation;

        string DoorDescription { get; set; }
        string DoorLocation { get; set; }
    }
}
