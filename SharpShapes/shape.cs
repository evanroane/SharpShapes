using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SharpShapes
{
    abstract public class Shape
    {
        //Perimeter, Area, BorderColor, FillColor, NumberOfSides
        /// <summary>
        /// Specifies the color of the interior of the shape when drawn.
        /// </summary>
        public Color FillColor
        {
            get;
            set;
        }
        
        /// <summary>
        /// Specifies the color of the bordr of the shape when drawn.
        /// </summary>
        public Color BorderColor { get; set; }
        
        /// <summary>
        /// Counts the sides of a shape.
        /// </summary>
        abstract public int SidesCount 
        { 
            get; 
        }

        public Shape()
        {
            FillColor = Color.Tomato;
            BorderColor = Color.Bisque;

        }
        /// <summary>
        /// Calculates the area of a shape.
        /// </summary>
        /// <returns>the area of the shape</returns>
        abstract public decimal Area();

        /// <summary>
        /// Calculates the perimeter of the shape.
        /// </summary>
        /// <returns>the perimeter of this shape</returns>
        abstract public decimal Perimeter();

        /// <summary>
        /// Scales the size of the shape
        /// </summary>
        /// <param name="percent">the percentage by which to scale the shape</param>
        abstract public void Scale(int percent);

    }
}
