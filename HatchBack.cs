using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop
{
    class HatchBack : Vehicle
    {
        private bool foldableSeats;
        public HatchBack(int vin, int mileage, string make, string model, int seats, bool foldable): base(vin, mileage, make, model)
        {
            foldable = foldableSeats;
        }
        public bool hasFoldableSeats()
        {
            return foldableSeats;
        }
        public override string ToString()
        {
            string y = base.ToString();
            y += "\nFoldable: " + foldableSeats;
            return y;
        }
    }
}
