﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Chemical : Product
    {
        public string City { get; set; }

        public string LabName { get; set; }

        public string StreetAddress { get; set; }

        public override void  GetMyType()
        {
            base.GetMyType();
            Console.WriteLine("chemical");
        }
        public override string ToString()
        {
            return base.ToString() + "City: " + City;

        }
    }
    
}
