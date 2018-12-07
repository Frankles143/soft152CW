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
        //Graphics on same screen on the other side
        //Drop down or listbox for graphing options? - rainfall, sunshine etc. 
    //Get adding done - new form?
        //Adding a new year, bring up blank datagrid for data? - Check that all rows are full before save
    //Get editing data working - Read in selected index and edit that specific index (depending on what you click on)
        //Have an edit button that lets users change the data grid entries and then a save button that makes it readonly again
        //I will need a SAVE DATA method to put the entire locationArray back into the text file
        //dataGridView.Rows[4].Cells["Name"].Value.ToString(); - This will help for outputting from datagrid to array

    //ASK LIZ
    //Do I need to edit the text file when adding or editing? - Yes, cry. --Just rewrite the whole damn thing?

    //Problems
    //Postcodes don't output in a regular way
    //Waddington prints out streetnum weirdly - add exception that if left default like that it just "" that field?

    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        //Reads in data, spits out location data for user to choose from and then brings the form into focus
        private void frmHome_Load(object sender, EventArgs e)
        {
            ReadInData();
            OutputLocationData();
            GetMonthName();
            this.Activate();
        }

        private void txtLocationSearch_TextChanged(object sender, EventArgs e)
        {
            dgdMonths.Rows.Clear();
            lstYears.Items.Clear();
            SearchLocations();
        }

        private void lstLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutputYearData();
        }

        private void lstYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            int yearIndex = lstYears.SelectedIndex;
            OutputMonthData(yearIndex);
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
            int[] indexHit = new int[Data.locationArray.Length];

            //Get user input
            searchTerm = txtLocationSearch.Text;
            
            //Clear first
            lstLocations.Items.Clear();
            //locationName, streetNumberAndName, county, postCode, latitude, longtitude;
            for (int location = 0; location < Data.locationArray.Length; location++)
            {
                //Take the location index and put all of the data into a formatted string
                tempLocationData = ($"{Data.locationArray[location].LocationName} {Data.locationArray[location].StreetNumberAndName} {Data.locationArray[location].County} {Data.locationArray[location].PostCode} {Data.locationArray[location].Latitude} {Data.locationArray[location].Longtitude}");

                //Make that that and the searchTerm capitals
                tempLocationDataCapitals = tempLocationData.ToUpper();
                searchTermCapitals = searchTerm.ToUpper();

                //Compare that formatted string to the searchTerm for hits, if there are hits then add that location index to the listbox
                if (tempLocationDataCapitals.Contains(searchTermCapitals))
                {
                    lstLocations.Items.Add(Data.locationArray[location].OutputLocation());
                }
            }
        }

        private Location getLocationFromString(string locationInput)
        {
            Location matchedLocation = null;
            string locationToCheck;
            //loop through locations, find a match and return that object
            for (int i = 0; i < Data.locationArray.Length; i++)
            {
                //Output every location into a string, with the exact same formatting as the input
                locationToCheck = Data.locationArray[i].OutputLocation();

                if (locationToCheck == locationInput)
                {
                    matchedLocation = Data.locationArray[i];
                    break;
                }
            }
            return matchedLocation;
        }
        
        //Output locations
        private void OutputLocationData()
        {
            for (int location = 0; location < Data.locationArray.Length; location++)
            {
                //Calls output location for every location
                lstLocations.Items.Add(Data.locationArray[location].OutputLocation());
            }
        }

        //Output all years for one location
        private void OutputYearData()
        {
            int selectedIndex;
            string locationString;

            dgdMonths.Rows.Clear();
            selectedIndex = lstLocations.SelectedIndex;
            locationString = lstLocations.SelectedItem.ToString();

            //This will return the object with the year and month data for that location inside it
            Location locationMatch = getLocationFromString(locationString);

            lstYears.Items.Clear();
            //Output all years
            for (int year = 0; year < locationMatch.YearsOfObservationsArray.Length; year++)
            {
                //call Output Year
                lstYears.Items.Add(locationMatch.YearsOfObservationsArray[year].OutputYear());
            }

            //Dettach the event handler, clear the box and then reattach handler
            txtLocationSearch.TextChanged -= txtLocationSearch_TextChanged;
            txtLocationSearch.Clear();
            txtLocationSearch.TextChanged += txtLocationSearch_TextChanged;
        }

        //Output all months in a year for a specific location
        private void OutputMonthData(int selectedYear)
        {
            dgdMonths.Rows.Clear();

            string locationString = lstLocations.SelectedItem.ToString();
            Location currentLocation = getLocationFromString(locationString);

            //Loops through every month
            for (int i = 0; i < 12; i++)
            {
                //Outputs the month data for location and year selected
                dgdMonths.Rows.Add(currentLocation.YearsOfObservationsArray[selectedYear].MonthlyObservationsArray[i].MonthName, currentLocation.YearsOfObservationsArray[selectedYear].MonthlyObservationsArray[i].MaxTemp, currentLocation.YearsOfObservationsArray[selectedYear].MonthlyObservationsArray[i].MinTemp, currentLocation.YearsOfObservationsArray[selectedYear].MonthlyObservationsArray[i].DaysAirFrost, currentLocation.YearsOfObservationsArray[selectedYear].MonthlyObservationsArray[i].MmRain, currentLocation.YearsOfObservationsArray[selectedYear].MonthlyObservationsArray[i].HrsSun);
            }
            dgdMonths.Refresh();
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
                    Data.locationArray = new Location[numberOfLocations];
                    Data.yearArray = new Year[0];
                    Data.monthlyArray = new MonthlyObservations[12];

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
                        ReadLocation(ref Data.locationArray, ref Data.yearArray, ref Data.monthlyArray, fileInput, ref locationIndex);

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
            monthlyArray = new MonthlyObservations[12];
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

        private void GetMonthName()
        {
            //Triple for loop to catch everything
            for (int location = 0; location < Data.locationArray.Length; location++)
            {
                for (int year = 0; year < Data.locationArray[location].YearsOfObservationsArray.Length; year++)
                {
                    for (int month = 0; month < Data.monthlyArray.Length; month++)
                    {
                        //Changing ID to month name
                        switch (Data.locationArray[location].YearsOfObservationsArray[year].MonthlyObservationsArray[month].MonthId)
                        {
                            case 1:
                                Data.locationArray[location].YearsOfObservationsArray[year].MonthlyObservationsArray[month].MonthName = "January";
                                break;
                            case 2:
                                Data.locationArray[location].YearsOfObservationsArray[year].MonthlyObservationsArray[month].MonthName = "February";
                                break;
                            case 3:
                                Data.locationArray[location].YearsOfObservationsArray[year].MonthlyObservationsArray[month].MonthName = "March";
                                break;
                            case 4:
                                Data.locationArray[location].YearsOfObservationsArray[year].MonthlyObservationsArray[month].MonthName = "April";
                                break;
                            case 5:
                                Data.locationArray[location].YearsOfObservationsArray[year].MonthlyObservationsArray[month].MonthName = "May";
                                break;
                            case 6:
                                Data.locationArray[location].YearsOfObservationsArray[year].MonthlyObservationsArray[month].MonthName = "June";
                                break;
                            case 7:
                                Data.locationArray[location].YearsOfObservationsArray[year].MonthlyObservationsArray[month].MonthName = "July";
                                break;
                            case 8:
                                Data.locationArray[location].YearsOfObservationsArray[year].MonthlyObservationsArray[month].MonthName = "August";
                                break;
                            case 9:
                                Data.locationArray[location].YearsOfObservationsArray[year].MonthlyObservationsArray[month].MonthName = "September";
                                break;
                            case 10:
                                Data.locationArray[location].YearsOfObservationsArray[year].MonthlyObservationsArray[month].MonthName = "October";
                                break;
                            case 11:
                                Data.locationArray[location].YearsOfObservationsArray[year].MonthlyObservationsArray[month].MonthName = "November";
                                break;
                            case 12:
                                Data.locationArray[location].YearsOfObservationsArray[year].MonthlyObservationsArray[month].MonthName = "December";
                                break;

                            default:
                                break;
                        }
                    }
                }
            }
        }

    }
}
