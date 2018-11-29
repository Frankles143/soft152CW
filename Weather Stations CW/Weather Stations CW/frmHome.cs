﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Weather_Stations_CW
{
    //TO DO LIST
    //GUI - WIP
        //Do I even need the month group box?
    //Do I need to format postcodes correctly? 
    //Outputting data in a good way
        //Get search function working for location, then output location data and years in that location e.g 1997-2017 - bubble search?
        //Use .Contains
        //use this System.StringComparison.CurrentCultureIgnoreCase to ignore case in search
        //Once location is working be able to type in a year of data from that location and output year description and 12 months of data
        //Polymorphism for outputting specific data - shouldn't be too hard, read in the index from the user
    //Get editing data working - Read in selected index and edit that specific index (depending on what you click on)

    //Problems
    //None yet (that I know of)

    public partial class frmHome : Form
    {
        //Arrays that can be accessed by all my methods
        Location[] locationArray;
        Year[] yearArray;
        MonthlyObservations[] monthlyArray;

        public frmHome()
        {
            InitializeComponent();
            
            //ReadInData();
            //Outputting();
        }

        private void txtLocationSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectLocation_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectYear_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectMonth_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        public void SearchLocations()
        {
            //Foreach (or for) to search through the index's, compare each index in a formatted string (so they can search for name/long/lat/postcode?)
            //Save any hits (if compare.... == true then add to output array?)
        }

        public void Outputting()
        {
            //Triple for loop to output everything
            for (int location = 0; location < locationArray.Length; location++)
            {
                //Create and call Output Location
                lstMainBox.Items.Add(locationArray[location].OutputLocation());
                for (int year = 0; year < locationArray[location].YearsOfObservationsArray.Length; year++)
                {
                    //Create and call Output Year
                    lstMainBox.Items.Add(locationArray[location].YearsOfObservationsArray[year].OutputYear());
                    for (int month = 0; month < monthlyArray.Length; month++)
                    {
                        lstMainBox.Items.Add(yearArray[year].MonthlyObservationsArray[month].OutputMonth());
                    }
                }
            }


        }

        //Method to pull in data
        public void ReadInData()
        {
            //Declare variables
            string filename = "";
            int numberOfLocations, locationIndex = 0;

            //exception handling
            try
            {
                //Choosing file
                dlgOpenData.ShowDialog();
                filename = dlgOpenData.FileName;

                //Reading in file

                //Old, inefficient
                //StreamReader fileInput = new StreamReader(filename);

                //Opens streamreader and clears it from memory once done
                using (StreamReader fileInput = new StreamReader(filename))
                {
                    //Number of locations - 1st line
                    numberOfLocations = Convert.ToInt32(fileInput.ReadLine());

                    //Create arrays
                    locationArray = new Location[numberOfLocations];
                    yearArray = new Year[0];
                    monthlyArray = new MonthlyObservations[12];

                    //While loop to continue until no more data
                    while (!fileInput.EndOfStream)
                    {
                        //Gather location data and store - 6 lines
                        //Number of years from that location - 1 line
                        //Year data - 2 lines
                        //Month data - 6 lines (12 times)
                        //Back up to year data until done
                        //Back up to location to start again until done

                        //Call methods (which calls the next method)
                        ReadLocation(ref locationArray, ref yearArray, ref monthlyArray, fileInput, ref locationIndex);

                    }
                    //Close using streamreader
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Please choose a valid file " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Method to read in location data
        private void ReadLocation(ref Location[] locationArray, ref Year[] yearArray, ref MonthlyObservations[] monthlyArray, StreamReader inputData, ref int locationIndex)
        {
            //Delcare vars
            string locationName, streetNumberAndName, county, postCode, latitude, longtitude;

            //Grab the location data
            locationName = inputData.ReadLine();
            streetNumberAndName = inputData.ReadLine();
            county = inputData.ReadLine();
            postCode = inputData.ReadLine();
            latitude = inputData.ReadLine();
            longtitude = inputData.ReadLine();

            //Call the other methods, passing the arrays in by ref so that I can input all the data into the object
            ReadYear(ref yearArray, ref monthlyArray, inputData);

            //New location object to put into array, then increase the index for the next time around
            Location tempLocation = new Location(locationName, streetNumberAndName, county, postCode, latitude, longtitude, yearArray);
            locationArray[locationIndex] = tempLocation;

            locationIndex++;
        }

        //Method to read in year data
        private void ReadYear(ref Year[] yearArray, ref MonthlyObservations[] monthlyArray, StreamReader inputData)
        {
            //Delcare vars
            string yearDescription;
            int numberOfYears, yearDate;

            //Get number of years in this location
            numberOfYears = Convert.ToInt32(inputData.ReadLine());
            yearArray = new Year[numberOfYears];

            for (int year = 1; year <= numberOfYears; year++)
            {
                //GrowArray(ref yearArray);

                //Read in data
                yearDescription = inputData.ReadLine();
                yearDate = Convert.ToInt32(inputData.ReadLine());

                //Call monthly
                ReadMonth(ref monthlyArray, inputData);

                //Create temp year object to pass data into year array, grow the array and increase the index for the next time around
                Year tempYear = new Year(yearDescription, yearDate, monthlyArray);

                yearArray[year - 1] = tempYear;
            }
        }

        //Method to read in month data
        private void ReadMonth(ref MonthlyObservations[] monthlyArray, StreamReader inputData)
        {
            //Delcare variables
            int monthID,  daysAirFrost, year;
            double maxTemp, minTemp, mmRain, hrsSun;

            //One for loop for years, second for loop for 12 months of that year
            for (int months = 0; months < 12; months++)
            {
                //Read in data
                if (months != 0)
                {
                    year = Convert.ToInt32(inputData.ReadLine());
                }
                monthID = Convert.ToInt32(inputData.ReadLine());
                maxTemp = Convert.ToDouble(inputData.ReadLine());
                minTemp = Convert.ToDouble(inputData.ReadLine());
                daysAirFrost = Convert.ToInt32(inputData.ReadLine());
                mmRain = Convert.ToDouble(inputData.ReadLine());
                hrsSun = Convert.ToDouble(inputData.ReadLine());

                //Put data into a temp object and then place into the correct index
                MonthlyObservations tempMonthlyArray = new MonthlyObservations(monthID, maxTemp, minTemp, daysAirFrost, mmRain, hrsSun);
                monthlyArray[months] = tempMonthlyArray;
            }
        }


        //Growing arrays with polymorphism
        private void GrowArray(ref Location[] arrayToChange)
        {
            int arraySize;

            if (arrayToChange == null)
            {
                arraySize = 0;
            }
            else
            {
                arraySize = arrayToChange.Length;
            }
            Array.Resize(ref arrayToChange, arraySize + 1);
        }

        private void GrowArray(ref Year[] arrayToChange)
        {
            int arraySize;

            if (arrayToChange == null)
            {
                arraySize = 0;
            }
            else
            {
                arraySize = arrayToChange.Length;
            }
            Array.Resize(ref arrayToChange, arraySize + 1);
        }

        private void GrowArray(ref MonthlyObservations[] arrayToChange)
        {
            int arraySize;

            if (arrayToChange == null)
            {
                arraySize = 0;
            }
            else
            {
                arraySize = arrayToChange.Length;
            }
            Array.Resize(ref arrayToChange, arraySize + 1);
        }
    }
}
