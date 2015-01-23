using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SharpShapes
{
    public class shape
    {
        //Width, Height, Perimeter, Area, BorderColor, FillColor, NumberOfSides
        public Color FillColor { get; set; }
        public Color BorderColor { get; set; }
        public virtual int SidesCount { get; }
        
        //returns area of the shape
        public abstract decimal Area();

        //returns the perimeter of this shape
        public abstract int Perimeter();

        //resizes a shape by percent%
        public abstract void scale(int percent)
        { 
            
        }
    }
}
