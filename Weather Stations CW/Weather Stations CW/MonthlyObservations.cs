using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Stations_CW
{
    class MonthlyObservations
    {
        private int monthID,  daysAirFrost;
        private double maxTemp, minTemp, mmRain, hrsSun;
        private string monthName;

        //Constructor
        public MonthlyObservations(int theMonthId, double theMaxTemp, double theMinTemp, int theDaysAirFrost, double theMmRain, double theHrsSun)
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

        public double MaxTemp
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

        public double MinTemp
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

        public double MmRain
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

        public double HrsSun
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

        public string MonthName
        {
            set
            {
                monthName = value;
            }
            get
            {
                return monthName;
            }
        }
    }
}
