using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproximationOfPi
{
    // process 1.



    class Coordinates
    {

        private double x;
        private double y;


        public Coordinates(double x, double y)
        {
            this.x = x;
            this.y = y;
        }


        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }


        public Coordinates(Random rnd)
        {
            this.x = rnd.NextDouble();
            this.y = rnd.NextDouble();
        }

        public double getX() => x;
        public double getY() => y;

    }


}
