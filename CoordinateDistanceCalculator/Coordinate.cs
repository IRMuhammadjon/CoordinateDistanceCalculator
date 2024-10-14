using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateDistanceCalculator
{
    public struct Coordinate
    {
      
        public Coordinate(double latitude, double longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
        public Coordinate(string? s)
        {

           var collict = s?.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(Convert.ToDouble).ToArray();
            if (collict is { Length: 2 })
            {
                Latitude = collict[0];
                Longitude = collict[1];
            }
            else
            {
                Latitude = 0;
                Longitude = 0;
            }
           
        }

        public double Latitude { get; set; }
        public double Longitude { get; set; }


        public static Coordinate From(string? s)
        {
          return new Coordinate(s);
        }
    }
}
