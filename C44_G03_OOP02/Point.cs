using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP02
{
    internal struct Point
    {
        #region Attributes
            public int x; 
            public int y;
        #endregion

        #region Constructor

        // Is Special Function
        public Point()
        {
            x = default(int);
            y = default(int);
        }
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public Point(int x)
        {
            this.x = x;
        }

        #endregion

    }
}
