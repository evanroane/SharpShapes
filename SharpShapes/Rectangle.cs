using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShapes
{
    public class Rectangle : Shape
    {
        private  int width;
        public int Width 
        { 
            get {return this.width; }
        }

        private  int height;
        public int Height 
        {
            get { return this.height; }
        }

        public override int SidesCount
        {
            get { throw new NotImplementedException(); }
        }

        public Rectangle(int Width, int Height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException();
            }
            this.width = Width;
            this.height = Height;    
        }

        public override decimal Area()
        {
            throw new NotImplementedException();
        }

        public override decimal Perimeter()
        {
 	        throw new NotImplementedException();
        }

        public override void Scale(int percent)
        {
            throw new NotImplementedException();
        }
     
    }
}
