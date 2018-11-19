﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Stations_CW
{
    class Year
    {
        private int yearDate;
        private string yearDescription;
        private MonthlyObservations[] monthlyObservationsArray;

        //Constructor
        public Year(int theYearDate, string theYearDescription, MonthlyObservations[] theMonthlyObservationsArray)
        {
            YearDate = theYearDate;
            YearDescription = theYearDescription;
            MonthlyObservationsArray = theMonthlyObservationsArray;
        }

        //Properties
        public int YearDate
        {
            set
            {
                try
                {
                    yearDate = value;
                }
                catch (FormatException e)
                {
                    System.Windows.Forms.MessageBox.Show("Error: " + e.Message + " Please input a valid year");
                }
            }
            get
            {
                return yearDate;
            }
        }

        public string YearDescription
        {
            set
            {
                yearDescription = value;
            }
            get
            {
                return yearDescription;
            }
        }

        public MonthlyObservations[] MonthlyObservationsArray
        {
            set
            {
                monthlyObservationsArray = value;
            }
            get
            {
                return monthlyObservationsArray;
            }
        }
    }
}