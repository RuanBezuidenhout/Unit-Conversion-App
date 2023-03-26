using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Conversion_App
{
    class clsTime
    {
        //Class Members
        public string sSelectedUnit;
        public double dUnit;

        //Contructor for clsTime Class
        public clsTime(string SelectedUnit, double Unit)
        {
            sSelectedUnit = SelectedUnit;
            dUnit = Unit;
        }

        //Method to Convert to Seconds
        public double ConvertFromSeconds()
        {
            switch(sSelectedUnit)
            {
                case ("Second"):
                    return dUnit;
                    break;
                case ("Minute"):
                    return dUnit / 60;
                    break;
                case ("Hour"):
                    return dUnit / 3600;
                    break;
                case ("Day"):
                    return dUnit / 86400;
                    break;
                case ("Week"):
                    return dUnit / 604800;
                    break;
                default:
                    return 0;
                    break;
            }
        }
        //Method to Convert to Minutes
        public double ConvertFromMinutes()
        {
            switch (sSelectedUnit)
            {
                case ("Second"):
                    return dUnit * 60;
                    break;
                case ("Minute"):
                    return dUnit;
                    break;
                case ("Hour"):
                    return dUnit / 60;
                    break;
                case ("Day"):
                    return dUnit / 1440;
                    break;
                case ("Week"):
                    return dUnit / 10080;
                    break;
                default:
                    return 0;
                    break;
            }
        }
        //Method to Convert to Hours
        public double ConvertFromHours()
        {
            switch (sSelectedUnit)
            {
                case ("Second"):
                    return dUnit * 3600;
                    break;
                case ("Minute"):
                    return dUnit * 60;
                    break;
                case ("Hour"):
                    return dUnit;
                    break;
                case ("Day"):
                    return dUnit / 24;
                    break;
                case ("Week"):
                    return dUnit / 168;
                    break;
                default:
                    return 0;
                    break;
            }
        }
        //Method to Convert to Days
        public double ConvertFromDays()
        {
            switch (sSelectedUnit)
            {
                case ("Second"):
                    return dUnit * 86400;
                    break;
                case ("Minute"):
                    return dUnit * 1440;
                    break;
                case ("Hour"):
                    return dUnit * 24;
                    break;
                case ("Day"):
                    return dUnit;
                    break;
                case ("Week"):
                    return dUnit / 7;
                    break;
                default:
                    return 0;
                    break;
            }
        }
        //Method to Convert to Weeks
        public double ConvertFromWeeks()
        {
            switch (sSelectedUnit)
            {
                case ("Second"):
                    return dUnit * 604800;
                    break;
                case ("Minute"):
                    return dUnit * 10080;
                    break;
                case ("Hour"):
                    return dUnit * 168;
                    break;
                case ("Day"):
                    return dUnit * 7;
                    break;
                case ("Week"):
                    return dUnit;
                    break;               
                default:
                    return 0;
                    break;
            }
        }
    }
}
