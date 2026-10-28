using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShuttleCore
{
    public partial class SpaceShuttle
    {
        #region Поля

        private double _fuelKg;
        private double _oxygenHours;
        private int _hullIntegrity;

        #endregion

        #region Свойства

        public string ShuttleName { get; set; }

        public double FuelKg
        {
            get { return _fuelKg; }
            set
            {
                if (value <= 0) _fuelKg = 0;
                else _fuelKg = value;
            }
        }

        public int HullIntegrity
        {
            get { return _hullIntegrity; }
            set
            {
                if (value <= 0) _hullIntegrity = 0;
                else if (value >= 100) _hullIntegrity = 100;
                else _hullIntegrity = value;
            }
        }

        public bool IsOperational => 15 < _hullIntegrity && _oxygenHours > 0;

        #endregion

    }

    public class Designer
    {
        public string ShuttleName { get; set; }
        public double FuelKg { get; set; }
        public double OxygenHours { get; set; }
        public int HullIntegrity { get; set; }

        public Designer()
        {
            ShuttleName = "Буран-Next";
            FuelKg = 2400.0;
            OxygenHours = 48.0;
            HullIntegrity = 100;
        }

        public Designer(string name, double _fuelKg, double _oxygenHours, int _hullIntegrity)
        {
            this.ShuttleName = name;
            this.FuelKg = _fuelKg;
            this.OxygenHours = _oxygenHours;
            this.HullIntegrity = _hullIntegrity;
        }

    }
}
