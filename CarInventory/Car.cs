using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventory
{
    internal class Car
    {
        //class atributes
        public string year, colour, make, mileage;

        //constructor method
        public Car(string _year, string _make, string _colour, string _mileage)
        {
            year = _year;
            colour = _colour;
            make = _make;
            mileage = _mileage;
        }

    }
}
