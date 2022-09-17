﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;

            if (!isCircleExsists())
            {
                throw new Exception("Such circle doesn't exist");
            }
        }

        public double FindSquare()
        {
            return Math.PI * Math.Pow(Radius,2);

        }

        private bool isCircleExsists()
        {
            return Radius > 0; 
        }
    }
}
