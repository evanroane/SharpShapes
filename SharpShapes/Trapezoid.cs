using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShapes
{
    public class Trapezoid : Shape
    {
        private decimal firstBase;
        public decimal FirstBase
        {
            get {return this.firstBase;}
        }
        
        private decimal secondBase;
        public decimal SecondBase;
        {
            get {return this.secondBase;}
        }
        
        private decimal altitude;
        public decimal Altitude
        {
            get { return altitude; }
        }
        
        public override int SidesCount
        {
            get { return 4; }
        }


        public Trapezoid(int FirstBase, int SecondBase, int Altitude)
        {
            this.FirstBase = FirstBase;
            this.SecondBase = SecondBase;
            this.Altitude = Altitude;
        }
    }
}
