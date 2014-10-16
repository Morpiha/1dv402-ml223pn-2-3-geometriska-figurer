using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    abstract class Shape
    {
        private double _length;
        private double _width;

        protected Shape(double lenght, double width)
        {
            lenght = _length;
            width = _width;
            
        }
        public override string ToString()
        {
            return string.Format("Something");
        }

        public double Area
        {
            get {
                return Area;
            }
        }
        public double Lenght
        {
            get
            {
                return Lenght;
            }
            set
            {

            }
        }
        public double Perimeter
        {
            get
            {
                return Perimeter;
            }
        }
        public double Width
        {
            get
            {
                return Width;
            }
            set
            {

            }
        }
    }
}
