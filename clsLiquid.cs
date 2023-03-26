using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Conversion_App
{
    class clsLiquid
    {
        //Class Members
        public string sSelectedUnit;
        public double dUnit;

        //Contructor for clsLenght Class
        public clsLiquid(string SelectedUnit, double Unit)
        {
            sSelectedUnit = SelectedUnit;
            dUnit = Unit;
        }

        //Method to Convert to Cup
        public double ConvertFromCup()
        {
            switch (sSelectedUnit)
            {
                case ("Cup"):
                    return dUnit;
                    break;
                case ("Pint"):
                    return dUnit / 2;
                    break;
                case ("Quart"):
                    return dUnit / 4;
                    break;
                case ("Gallon"):
                    return dUnit / 16;
                    break;
                default:
                    return 0;
                    break;
            }
        }
        //Method to Convert to Pint
        public double ConvertFromPint()
        {
            switch (sSelectedUnit)
            {
                case ("Cup"):
                    return dUnit * 2;
                    break;
                case ("Pint"):
                    return dUnit;
                    break;
                case ("Quart"):
                    return dUnit / 2;
                    break;
                case ("Gallon"):
                    return dUnit / 4;
                    break;
                default:
                    return 0;
                    break;
            }
        }
        //Method to Convert to Quart
        public double ConvertFromQuart()
        {
            switch (sSelectedUnit)
            {
                case ("Cup"):
                    return dUnit * 4;
                    break;
                case ("Pint"):
                    return dUnit * 2;
                    break;
                case ("Quart"):
                    return dUnit;
                    break;
                case ("Gallon"):
                    return dUnit / 2;
                    break;
                default:
                    return 0;
                    break;
            }
        }
        //Method to Convert to Cup
        public double ConvertFromGallon()
        {
            switch (sSelectedUnit)
            {
                case ("Cup"):
                    return dUnit * 16;
                    break;
                case ("Pint"):
                    return dUnit * 4;
                    break;
                case ("Quart"):
                    return dUnit * 2;
                    break;
                case ("Gallon"):
                    return dUnit;
                    break;
                default:
                    return 0;
                    break;
            }
        }
    }
}
