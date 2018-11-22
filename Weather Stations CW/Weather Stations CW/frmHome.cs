using System;
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
    //GUI
    //Pulling data in from file

    //You need to make another method for pulling monthly data, in a for loop for 12 months

    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        //Method to pull in data
        public void ReadInData()
        {
            //Declare variables
            //Monthly obs
            int monthID, maxTemp, minTemp, daysAirFrost, mmRain, hrsSun;

            

            string filename;
            int numberOfLocations;

            //Choosing file
            dlgOpenData.ShowDialog();
            filename = dlgOpenData.FileName;

            //Reading in file
            StreamReader fileInput = new StreamReader(filename);

            //Number of locations - 1st line
            numberOfLocations = Convert.ToInt32(fileInput.ReadLine());

            //Create arrays

            //Not sure these arrays are correct?
            Location[] locationArray = new Location[numberOfLocations];
            Year[] yearArray = new Year[0];
            MonthlyObservations[] monthlyArray = new MonthlyObservations[12];

            //While loop to continue until no more data
            while (!fileInput.EndOfStream)
            {

                //Gather location data and store appropriately - 6 lines

                //Number of years from that location - 1 line

                //Create index for that location

                //Year data - 2 lines

                //Month data - 6 lines (12 times)



                ReadLocation(ref locationArray, fileInput);

                ReadYear(ref yearArray, fileInput);




            }
            fileInput.Close();
        }

        //Method to read in location data
        private void ReadLocation(ref Location[] locationArray, StreamReader inputData)
        {
            //Delcare vars
            string locationName, streetNumberAndName, county, postCode, latitude, longtitude;
            int locationIndex = 0;

            //Grab the location data
            locationName = inputData.ReadLine();
            streetNumberAndName = inputData.ReadLine();
            county = inputData.ReadLine();
            postCode = inputData.ReadLine();
            latitude = inputData.ReadLine();
            longtitude = inputData.ReadLine();

            //New location object to put into array, then increase the index for the next time around
            Location tempLocation = new Location(locationName, streetNumberAndName, county, postCode, latitude, longtitude);

            locationArray[locationIndex] = tempLocation;

            locationIndex++;
        }

        private void ReadYear(ref Year[] yearArray,StreamReader inputData)
        {
            //Delcare vars
            string yearDescription;
            int numberOfYears, yearDate, yearIndex = 0;

            //Read in data
            numberOfYears = Convert.ToInt32(inputData.ReadLine());
            yearDescription = inputData.ReadLine();
            yearDate = Convert.ToInt32(inputData.ReadLine());

            //Create temp year object to pass data into year array, grow the array and increase the index for the next time around
            Year tempYear = new Year(yearDescription, yearDate);

            GrowArray(ref yearArray);

            yearArray[yearIndex] = tempYear;

            yearIndex++;
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
