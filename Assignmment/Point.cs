﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmment
{
    internal struct Point
    {
        public double  X;
        public double Y;

        public Point (double x, double y)
        {
            this.X= x;
            this.Y= y;
        }

        public double Distance(Point p)
        {
            return Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));
        }
    
    }
}
