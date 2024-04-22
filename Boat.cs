using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop
{
    class Boat : Vehicle
    {
        private bool Radar;
        public Boat(int vin, int mileage, string make, string model, bool radar): base(vin, mileage, make, model)
        {
            radar = Radar;
        }
        public bool hasRadar()
        {
            return Radar;
        }
        public override string ToString()
        {
            string y = base.ToString();
            y += "\nRadar: " + Radar;
            return y;
        }
    }
}
