﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpShapes;

namespace SharpShapes
{
    public class Trapezoid : Shape
    {
        private decimal firstBase;
        public decimal FirstBase
        {
            get { return this.firstBase; }
        }
        private decimal secondBase;
        public decimal SecondBase
        {
            get { return this.secondBase; }
        }
        private decimal altitude;
        public decimal Altitude
        {
            get { return this.altitude; }
        }

        public Trapezoid(int firstBase, int secondBase, int altitude)
        {
            if (firstBase <= 0 || secondBase <= 0 || altitude <= 0)
            {
                throw new ArgumentException();
            }
            this.firstBase = firstBase;
            this.secondBase = secondBase;
            this.altitude = altitude;
        }

        public override void Scale(int percent)
        {
            throw new NotImplementedException();
        }

        public override decimal Area()
        {
            throw new NotImplementedException();
        }

        public override decimal Perimeter()
        {
            throw new NotImplementedException();
        }

        public override int SidesCount
        {
            get { return 4; }
        }
    }
}
