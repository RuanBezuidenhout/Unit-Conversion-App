using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Conversion_App
{
    class clsWeight
    {
        //Class Members
        public string sSelectedUnit;
        public double dUnit;

        //Contructor for clsLenght Class
        public clsWeight(string SelectedUnit, double Unit)
        {
            sSelectedUnit = SelectedUnit;
            dUnit = Unit;
        }

        //Method to Convert to Gram
        public double ConvertFromGram()
        {
            switch (sSelectedUnit)
            {
                case ("Gram"):
                    return dUnit;
                    break;
                case ("Kilogram"):
                    return dUnit / 1000;
                    break;
                case ("Ton"):
                    return dUnit / 1000000;
                    break;
                default:
                    return 0;
                    break;
            }
        }
        //Method to Convert to Kilogram
        public double ConvertFromKilogram()
        {
            switch (sSelectedUnit)
            {
                case ("Gram"):
                    return dUnit * 1000;
                    break;
                case ("Kilogram"):
                    return dUnit;
                    break;
                case ("Ton"):
                    return dUnit / 1000;
                    break;
                default:
                    return 0;
                    break;
            }
        }
        //Method to Convert to Ton
        public double ConvertFromTon()
        {
            switch (sSelectedUnit)
            {
                case ("Gram"):
                    return dUnit * 1000000;
                    break;
                case ("Kilogram"):
                    return dUnit * 1000;
                    break;
                case ("Ton"):
                    return dUnit;
                    break;
                default:
                    return 0;
                    break;
            }
        }
    }
}
