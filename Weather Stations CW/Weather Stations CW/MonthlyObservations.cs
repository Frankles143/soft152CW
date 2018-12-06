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

        // (int theMonthId, double theMaxTemp, double theMinTemp, int theDaysAirFrost, double theMmRain, double theHrsSun)
        //Outputting
        public string OutputMonth()
        {
            string messageOut = "", monthName = "";

            switch (MonthId)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;

                default:
                    break;
            }

            messageOut = string.Format($"{monthName}: Max temp this month was {MaxTemp}, and min temp was {MinTemp}. Days of air frost: {DaysAirFrost}. Rain in MM: {MmRain}. Hours of sunlight: {HrsSun}");

            return messageOut;
        }
    }
}
