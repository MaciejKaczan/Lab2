﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class OutsideWithDoor : Room, IHasExteriorDoor
    {
        private string Test1;
        public string DoorDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DoorLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
