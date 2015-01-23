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
        //Perimeter, Area, BorderColor, FillColor, NumberOfSides
        /// <summary>
        /// Specifies the color of the interior of the shape when drawn.
        /// </summary>
        public Color FillColor { get; set; }
        
        /// <summary>
        /// Specifies the color of the bordr of the shape when drawn.
        /// </summary>
        public Color BorderColor { get; set; }
        
        /// <summary>
        /// Counts the sides of a shape.
        /// </summary>
        public virtual int SidesCount { get; }
        
        /// <summary>
        /// Calculates the area of a shape.
        /// </summary>
        /// <returns>the area of the shape</returns>
        public abstract decimal Area();

        /// <summary>
        /// Calculates the perimeter of the shape.
        /// </summary>
        /// <returns>the perimeter of this shape</returns>
        public abstract int Perimeter();

        /// <summary>
        /// Scales the size of the shape
        /// </summary>
        /// <param name="percent">the percentage by which to scale the shape</param>
        public abstract void scale(int percent)
        { 
            
        }
    }
}
