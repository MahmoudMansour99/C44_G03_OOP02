using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP02.Encapsulation
{
    internal struct Point
    {
        #region Attributes
        private double x;
        private double y;
        #endregion

        #region Properties
        public double X
        {
            get { return x; }
            set
            {
                if (!double.IsNaN(value))
                    x = value;
                else
                    Console.WriteLine("Invalid X coordinate.");
            }
        }
        public double Y
        {
            get { return y; }
            set
            {
                if (!double.IsNaN(value))
                    y = value;
                else
                    Console.WriteLine("Invalid Y coordinate.");
            }
        }
        #endregion

        #region Constructor

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        #endregion
    }
}
