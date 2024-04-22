using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop
{
    class Car : Vehicle
    {
        protected int seats;
        public Car(int vin, int mileage, string model, string make, int seats): base(vin,mileage,model,make)
        {
            this.seats = seats;
        }
        public int getSeats()
        {
            return seats;
        }
        public override string ToString()
        {
            string y = base.ToString();
            y += "\nSeats: " + seats;
            return y;
        }

    }
}
