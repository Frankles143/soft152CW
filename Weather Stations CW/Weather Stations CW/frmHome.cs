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
    //GUI - WIP
        //Completely re-do with picture on phone
        //everytime I click on an index it will update the other listboxes?
        //Search bar and small box for location - maybe just select index instead of hiding them (no worries for index numbers)
        //A different listbox for years
        //a data grid for month data
        //Graphics on same screen on the other side
    //Outputting data in a good way
        //NOPE. See above
    //Get adding done - new form?
    //Get editing data working - Read in selected index and edit that specific index (depending on what you click on)

    //ASK LIZ
    //Do I need to edit the text file when adding or editing? - Yes, cry.
    //Can I have class level variables? - See comments
    //GUI opinion? - Shite, re-do

    //Problems
    //Postcodes don't output in a regular way
    //Waddington prints out streetnum weirdly - add exception that if left default like that it just "" that field?

    public partial class frmHome : Form
    {
        //Arrays that can be accessed by all my methods
        Location[] locationArray;
        //These shouldn't be here - I will get marked down
        Year[] yearArray;
        MonthlyObservations[] monthlyArray;
        //This one is probably okay?
        Location locationMatch;

        public frmHome()
        {
            InitializeComponent();
        }

        //Reads in data, spits out location data for user to choose from and then brings the form into focus
        private void frmHome_Load(object sender, EventArgs e)
        {
            ReadInData();
            Outputting(ref locationArray);
            this.Activate();
        }

        //Runs this everytime the text box is changed
        private void txtLocationSearch_TextChanged(object sender, EventArgs e)
        {
            lstMainBox.SelectedIndex = -1;
            btnSelectLocation.Enabled = true;
            btnSelectYear.Enabled = false;
            SearchLocations();
        }

        private void btnSelectLocation_Click(object sender, EventArgs e)
        {
            int selectedIndex;
            string locationString;

            selectedIndex = lstMainBox.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a location");
            }
            else
            {
                locationString = lstMainBox.SelectedItem.ToString();

                //This will return the object with the year and month data for that location inside it
                locationMatch = getLocationFromString(locationString);

                lstMainBox.Items.Clear();
                grpSelectYear.Enabled = true;

                //Output all years
                for (int year = 0; year < locationMatch.YearsOfObservationsArray.Length; year++)
                {
                    //call Output Year
                    lstMainBox.Items.Add(locationMatch.YearsOfObservationsArray[year].OutputYear());
                }
                btnSelectLocation.Enabled = false;
                btnSelectYear.Enabled = true;
            }

            //Dettach the event handler, clear the box and then reattach handler
            txtLocationSearch.TextChanged -= txtLocationSearch_TextChanged;  
            txtLocationSearch.Clear(); 
            txtLocationSearch.TextChanged += txtLocationSearch_TextChanged; 
            

        }

        private void btnSelectYear_Click(object sender, EventArgs e)
        {
            int selectedIndex;
            string yearString;

            selectedIndex = lstMainBox.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a year");
            }
            else
            {
                yearString = lstMainBox.SelectedItem.ToString();

                //This will return the object with the year and month data for that location inside it
                Year yearMatch = getYearFromString(yearString);

                lstMainBox.Items.Clear();
                grpSelectMonth.Enabled = true;

                //Output all years
                for (int month = 0; month < yearMatch.MonthlyObservationsArray.Length; month++)
                {
                    //call Output Year
                    lstMainBox.Items.Add(yearMatch.MonthlyObservationsArray[month].OutputMonth());
                }
                btnSelectYear.Enabled = false;
            }
        }

        //Might not need this?
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
            this.Close();
        }

        //Method to search through the locations
        private void SearchLocations()
        {
            //Declare vars
            string searchTerm, tempLocationData = "", searchTermCapitals, tempLocationDataCapitals;
            int[] indexHit = new int[locationArray.Length];

            //Get user input
            searchTerm = txtLocationSearch.Text;
            
            //Clear first
            lstMainBox.Items.Clear();
            //locationName, streetNumberAndName, county, postCode, latitude, longtitude;
            for (int location = 0; location < locationArray.Length; location++)
            {
                //Take the location index and put all of the data into a formatted string
                tempLocationData = ($"{locationArray[location].LocationName} {locationArray[location].StreetNumberAndName} {locationArray[location].County} {locationArray[location].PostCode} {locationArray[location].Latitude} {locationArray[location].Longtitude}");

                //Make that that and the searchTerm capitals
                tempLocationDataCapitals = tempLocationData.ToUpper();
                searchTermCapitals = searchTerm.ToUpper();

                //Compare that formatted string to the searchTerm for hits, if there are hits then add that location index to the listbox
                if (tempLocationDataCapitals.Contains(searchTermCapitals))
                {
                    lstMainBox.Items.Add(locationArray[location].OutputLocation());
                }
            }
        }

        private Location getLocationFromString(string locationInput)
        {
            Location matchedLocation = null;
            string locationToCheck;
            //loop through locations, find a match and return that object
            for (int i = 0; i < locationArray.Length; i++)
            {
                //Output every location into a string, with the exact same formatting as the input
                locationToCheck = locationArray[i].OutputLocation();

                if (locationToCheck == locationInput)
                {
                    matchedLocation = locationArray[i];
                    break;
                }
            }
            return matchedLocation;
        }

        //Why did I do this? Just use the fucking selected index you idiot-faced twat
        private Year getYearFromString(string yearInput)
        {
            Year matchedYear = null;
            string yearToCheck;
            //loop through locations, find a match and return that object
            for (int i = 0; i < locationMatch.YearsOfObservationsArray.Length; i++)
            {
                //Output every location into a string, with the exact same formatting as the input
                yearToCheck = locationMatch.YearsOfObservationsArray[i].OutputYear();

                if (yearToCheck == yearInput)
                {
                    matchedYear = locationMatch.YearsOfObservationsArray[i];
                    break;
                }
            }
            return matchedYear;
        }

        
        //Output everything
        private void Outputting()
        {
            //Clear first
            lstMainBox.Items.Clear();
            //Triple for loop to output everything
            for (int location = 0; location < locationArray.Length; location++)
            {
                //Call Output Location
                lstMainBox.Items.Add(locationArray[location].OutputLocation());
                for (int year = 0; year < locationArray[location].YearsOfObservationsArray.Length; year++)
                {
                    //Call Output Year
                    lstMainBox.Items.Add(locationArray[location].YearsOfObservationsArray[year].OutputYear());
                    for (int month = 0; month < monthlyArray.Length; month++)
                    {
                        //Call Output month
                        lstMainBox.Items.Add(yearArray[year].MonthlyObservationsArray[month].OutputMonth());
                    }
                }
            }
        }
        
        //Output locations
        private void Outputting(ref Location[] locationArray)
        {
            for (int location = 0; location < locationArray.Length; location++)
            {
                //Calls output location for every location
                lstMainBox.Items.Add(locationArray[location].OutputLocation());
            }
        }

        //Output all years for a specific location
        private void Outputting(ref Year[] yearArray, int locationIndex)
        {
            for (int year = 0; year < locationArray[locationIndex].YearsOfObservationsArray.Length; year++)
            {
                //call Output Year
                lstMainBox.Items.Add(locationArray[locationIndex].YearsOfObservationsArray[year].OutputYear());
            }
        }

        //Output all months, for a specific location, in a specific year
        private void Outputting(ref MonthlyObservations[] monthlyArray, int locationIndex, int yearIndex)
        {
            for (int month = 0; month < monthlyArray.Length; month++)
            {
                lstMainBox.Items.Add(locationArray[locationIndex].YearsOfObservationsArray[yearIndex].MonthlyObservationsArray[month].OutputMonth());
            }
        }


        //Method to pull in data from text file
        private void ReadInData()
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
                //Opens streamreader
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
                    //Close streamreader
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

        //private void GrowArray(ref MonthlyObservations[] arrayToChange)
        //{
        //    int arraySize;

        //    if (arrayToChange == null)
        //    {
        //        arraySize = 0;
        //    }
        //    else
        //    {
        //        arraySize = arrayToChange.Length;
        //    }
        //    Array.Resize(ref arrayToChange, arraySize + 1);
        //}
    }
}
