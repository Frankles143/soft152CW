using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Stations_CW
{
    class MonthlyObservations
    {
        private int monthID, maxTemp, minTemp, daysAirFrost, mmRain, hrsSun;

        //Constructor
        public MonthlyObservations(int theMonthId, int theMaxTemp, int theMinTemp, int theDaysAirFrost, int theMmRain, int theHrsSun)
        {
            MonthId = theMonthId;
            MaxTemp = theMaxTemp;
            MinTemp = theMinTemp;
            DaysAirFrost = theDaysAirFrost;
            MmRain = theMmRain;
            HrsSun = theHrsSun;
        }

        //Properties
        public int MonthId
        {
            set
            {
                try
                {
                    monthID = value;
                }
                catch (FormatException e)
                {
                    System.Windows.Forms.MessageBox.Show("Error: " + e.Message + " Please input a month ID (January = 1, February = 2 etc.)");
                }
            }
            get
            {
                return monthID;
            }
        }

        public int MaxTemp
        {
            set
            {
                try
                {
                    maxTemp = value;
                }
                catch (FormatException e)
                {
                    System.Windows.Forms.MessageBox.Show("Error: " + e.Message + " Please input a valid temperature");
                }
            }
            get
            {
                return maxTemp;
            }
        }

        public int MinTemp
        {
            set
            {
                try
                {
                    minTemp = value;
                }
                catch (FormatException e)
                {
                    System.Windows.Forms.MessageBox.Show("Error: " + e.Message + " Please input a valid temperature");
                }
            }
            get
            {
                return minTemp;
            }
        }

        public int DaysAirFrost
        {
            set
            {
                try
                {
                    daysAirFrost = value;
                }
                catch (FormatException e)
                {
                    System.Windows.Forms.MessageBox.Show("Error: " + e.Message + " Please input a valid number of days");
                }
            }
            get
            {
                return daysAirFrost;
            }
        }

        public int MmRain
        {
            set
            {
                try
                {
                    mmRain = value;
                }
                catch (FormatException e)
                {
                    System.Windows.Forms.MessageBox.Show("Error: " + e.Message + " Please input a valid amount of rain (millimeters)");
                }
            }
            get
            {
                return mmRain;
            }
        }

        public int HrsSun
        {
            set
            {
                try
                {
                    hrsSun = value;
                }
                catch (FormatException e)
                {
                    System.Windows.Forms.MessageBox.Show("Error: " + e.Message + " Please input a valid number of hours");
                }
            }
            get
            {
                return hrsSun;
            }
        }
    }
}
