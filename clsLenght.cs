using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Conversion_App
{
    class clsLenght
    {
        //Class Members
        public string sSelectedUnit;
        public double dUnit;

        //Contructor for clsLenght Class
        public clsLenght(string SelectedUnit, double Unit)
        {
            sSelectedUnit = SelectedUnit;
            dUnit = Unit;
        }

        //Method to Convert to Milimeter
        public double ConvertFromMilimeter()
        {
            switch (sSelectedUnit)
            {
                case ("Milimeter"):
                    return dUnit;
                    break;
                case ("Centimeter"):
                    return dUnit / 10;
                    break;
                case ("Decimeter"):
                    return dUnit / 100;
                    break;
                case ("Meter"):
                    return dUnit / 1000;
                    break;
                case ("Kilometer"):
                    return dUnit / 1000000;
                    break;
                default:
                    return 0;
                    break;
            }
        }
        //Method to Convert to Seconds
        public double ConvertFromCentimeter()
        {
            switch (sSelectedUnit)
            {
                case ("Milimeter"):
                    return dUnit * 10;
                    break;
                case ("Centimeter"):
                    return dUnit;
                    break;
                case ("Decimeter"):
                    return dUnit / 10;
                    break;
                case ("Meter"):
                    return dUnit / 100;
                    break;
                case ("Kilometer"):
                    return dUnit / 100000;
                    break;
                default:
                    return 0;
                    break;
            }
        }
        //Method to Convert to Decimeter
        public double ConvertFromDecimeter()
        {
            switch (sSelectedUnit)
            {
                case ("Milimeter"):
                    return dUnit * 100;
                    break;
                case ("Centimeter"):
                    return dUnit * 10;
                    break;
                case ("Decimeter"):
                    return dUnit ;
                    break;
                case ("Meter"):
                    return dUnit / 10;
                    break;
                case ("Kilometer"):
                    return dUnit / 10000;
                    break;
                default:
                    return 0;
                    break;
            }
        }
        //Method to Convert to Meter
        public double ConvertFromMeter()
        {
            switch (sSelectedUnit)
            {
                case ("Milimeter"):
                    return dUnit * 1000;
                    break;
                case ("Centimeter"):
                    return dUnit * 100;
                    break;
                case ("Decimeter"):
                    return dUnit * 10;
                    break;
                case ("Meter"):
                    return dUnit ;
                    break;
                case ("Kilometer"):
                    return dUnit / 10;
                    break;
                default:
                    return 0;
                    break;
            }
        }
        //Method to Convert to Kilometer
        public double ConvertFromKilometer()
        {
            switch (sSelectedUnit)
            {
                case ("Milimeter"):
                    return dUnit * 1000000;
                    break;
                case ("Centimeter"):
                    return dUnit * 100000;
                    break;
                case ("Decimeter"):
                    return dUnit * 10000;
                    break;
                case ("Meter"):
                    return dUnit * 1000;
                    break;
                case ("Kilometer"):
                    return dUnit;
                    break;
                default:
                    return 0;
                    break;
            }
        }
    }
}
