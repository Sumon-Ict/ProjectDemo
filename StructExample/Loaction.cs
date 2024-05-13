using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    internal struct Loaction
    {
        public double longitude;
        public double latitude;

        public Loaction(double longitude, double latitude)
        {
            this.longitude = longitude;
            this.latitude = latitude;
        }

        public bool Equals(Loaction other)
        {
         return   other.longitude==longitude &&
            other.latitude==latitude;
        }
        public bool Equals(double x,double y)
        {
            return longitude == x && latitude ==y;

        }

    }
}
