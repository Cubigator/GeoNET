using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoNET
{
    public class Coordinates
    {
        private HemisphereAlongTheEquator _hemisphereAtTheEquator;
        private HemisphereGMT _hemisphereGMT;

        public HemisphereAlongTheEquator HemisphereAtTheEquator
        {
            get { return _hemisphereAtTheEquator; }
        }
        public HemisphereGMT HemisphereGMT
        {
            get { return _hemisphereGMT; }
        }

        private double _latitude;
        private double _longitude;

        public double Latitude
        {
            get { return _latitude; }
            set
            {
                _latitude = value;
                if (_latitude < 0)
                    _hemisphereAtTheEquator = HemisphereAlongTheEquator.Southern;
                else
                    _hemisphereAtTheEquator = HemisphereAlongTheEquator.Northern;
            }
        }
        public double Longitude
        {
            get { return _longitude; }
            set
            {
                _longitude = value;
                if (_longitude < 0)
                    _hemisphereGMT = HemisphereGMT.Western;
                else
                    _hemisphereGMT = HemisphereGMT.Eastern;
            }
        }

        public Coordinates(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        /// <summary>
        /// Возвращает расстояние между двумя точками (координатами)
        /// </summary>
        public Distance GetDistance(Coordinates right)
        {
            double distance = Math.Sqrt(Math.Pow(Latitude - right.Latitude, 2) + 
                Math.Pow(Longitude - right.Longitude, 2));

            return new Distance(distance * 111.0);
        }
        /// <summary>
        /// Возвращает расстояние между двумя точками (координатами)
        /// </summary>
        public static Distance GetDistance(Coordinates left, Coordinates right)
        {
            double distance = Math.Sqrt(Math.Pow(left.Latitude - right.Latitude, 2) +
                Math.Pow(left.Longitude - right.Longitude, 2));

            return new Distance(distance * 111.0);
        }
    }
}
