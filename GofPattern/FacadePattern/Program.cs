﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICar car = new CarFacade();
            car.BuildCar();
        }
    }
}
