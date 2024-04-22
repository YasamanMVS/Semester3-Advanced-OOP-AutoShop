using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop
{
    class Sedan : Vehicle
    {
        protected bool backseatFridge;
        protected bool backseatRecliner;
        public Sedan(int vin, int mileage, string make, string model, int seats, bool fridge, bool recliner) : base (vin, mileage, make, model)
        {
            fridge = backseatFridge;
            recliner = backseatRecliner;
        }
        public bool hasFridge()
        {
            return backseatFridge;
        }
        public bool hasRecliner()
        {
            return backseatRecliner;
        }
        public override string ToString()
        {
            string y = base.ToString();
            y += "Fridge: " + backseatFridge;
            y += "\nRecliner: " + backseatRecliner;
            return y;
        }
    }
}
