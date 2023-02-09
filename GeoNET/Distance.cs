namespace GeoNET
{
    public class Distance
    {
        private double _meters;
        private double _miles;
        private double _kilometers;
        private double _yards;
        private double _versts;

        /// <summary>
        ///  Расстояние в метрах
        /// </summary>
        public double Meters
        {
            get { return _meters; }
            set
            {
                _meters = value;
                if(_meters < 0) 
                    _meters = 0;

                _kilometers = _meters * 1000.0;
                _miles = _meters * 1609.0;
                _yards = _meters / 1.094;
                _versts = _meters * 1067.0;
            }
        }
        /// <summary>
        ///  Расстояние в милях
        /// </summary>
        public double Miles
        {
            get { return _miles; }
            set
            {
                _miles = value;
                if (_miles < 0)
                    _miles = 0;

                _versts = _miles / 1.509;
                _kilometers = _miles / 1609.0;
                _meters = _miles / 1609.0;
                _yards = _miles / 1760.0;
            }
        }
        /// <summary>
        ///  Расстояние в километрах
        /// </summary>
        public double Kilometers
        {
            get { return _kilometers; }
            set
            {
                _kilometers = value;
                if (_kilometers < 0)
                    _kilometers = 0;

                _versts = _kilometers * 1.067;
                _miles = _kilometers * 1609.0;
                _meters = _kilometers / 1000.0;
                _yards = _kilometers / 1094.0;
            }
        }
        /// <summary>
        ///  Расстояние в ярдах
        /// </summary>
        public double Yards
        {
            get { return _yards; }
            set
            {
                _yards = value;
                if (_yards < 0)
                    _yards = 0;

                _versts = _yards * 1167.0;
                _miles = _yards * 1760.0;
                _meters = _yards * 1.094;
                _kilometers = _yards * 1094.0;
            }
        }
        /// <summary>
        ///  Расстояние в вёрстах
        /// </summary>
        public double Versts
        {
            get { return _versts; }
            set
            {
                _versts = value;
                if (_versts < 0)
                    _versts = 0;

                _yards = _versts / 1167.0;
                _miles = _versts * 1.509;
                _meters = _versts / 1067;
                _kilometers = _versts / 1.067;
            }
        }

        public Distance() { }
        /// <summary>
        ///  Получает расстояние в километрах и переводит в другие единицы
        /// </summary>
        public Distance(double kilometers)
        {
            Kilometers = kilometers;
        }
    }
}