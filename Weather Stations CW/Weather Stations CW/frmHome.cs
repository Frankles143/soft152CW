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
    //Change your output for the location listbox to be brief (KEEP ROBUST SEARCH), and then output data next to it, to be able to easily edit
    //Same with year?
    //Graphics on same screen on the other side
    //Drop down or listbox for graphing options? - rainfall, sunshine etc. 

    //Get editing data working - Read in selected index and edit that specific index (depending on what you click on)
    //Have an edit button that lets users change the data grid entries and then a save button that makes it readonly again
    //I will need a SAVE DATA method to put the entire locationArray back into the text file -- Use another dialog to save the file? Saves overwriting it everytime
    //dataGridView.Rows[4].Cells["Name"].Value.ToString(); - This will help for outputting from datagrid to array

    //Need some exception handling for pulling in data - check problems

    //ASK LIZ
    //Do I need to edit the text file when adding or editing? - Yes, cry. --Just rewrite the whole damn thing?
    //GUI feedback: She's not sure on the 1-2-3-4 approach, maybe have everything on the left and data read out on the right? 
    //Have a search function and only display some of the data, once you click on that location it pushes out all the data elsewhere ^ on the right, with graphing etc
    //Scrunch up the month grid!

    //Problems
    //Postcodes don't output in a regular way
    //Waddington prints out streetnum weirdly - add exception that if left default like that it just "" that field?
    //Location info goes out of box
    //One of the location's has an ' that is printed out weirdly

    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        //Reads in data, spits out location data for user to choose from and then brings the form into focus
        private void frmHome_Load(object sender, EventArgs e)
        {
            //exception handling
            try
            {
                ReadInData();
                OutputLocationList();
                GetMonthName();
                this.Activate();
                lstLocations.SelectedIndex = 0;
                lstYears.SelectedIndex = 0;
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

        private void txtLocationSearch_TextChanged(object sender, EventArgs e)
        {
            dgdMonths.Rows.Clear();
            lstYears.Items.Clear();
            SearchLocations();
            btnEditLocation.Enabled = false;
            btnNewYear.Enabled = false;
            btnEditYear.Enabled = false;
        }

        private void lstLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutputYearList();
            OutputLocationData();
            btnNewYear.Enabled = true;
            btnEditLocation.Enabled = true;
            btnEditYear.Enabled = false;
            if (lstYears.SelectedIndex > -1)
            {
                lstYears.SelectedIndex = 0;
            }
            
        }

        private void lstYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            int yearIndex = lstYears.SelectedIndex;
            OutputMonthList(yearIndex);
            OutputYearData();
            btnEditYear.Enabled = true;
        }

        private void btnNewLocation_Click(object sender, EventArgs e)
        {
            //Brings up form for adding/editing
            Location newLocation = NewLocationDialog();

            if (newLocation != null)
            {
                SaveNewLocation(newLocation);
            }
        }

        private void btnNewYear_Click(object sender, EventArgs e)
        {
            //Bring up custom dialog box for year description and then save the new year into the array
            Year newYear = NewYearDialog();
            if (newYear != null)
            {
                SaveNewYear(newYear);
            }
            OutputYearList();
        }

        
        private void dgdMonths_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgdMonths_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditMonth.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Saves all changes to a file? -- How to stop editing a month?
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Method to get location data from user
        private Location NewLocationDialog()
        {
            frmEditAdd newLocationDialog = new frmEditAdd();
            string locationName, streetNumberAndName, county, postCode, latitude, longtitude;
            Location newLocation;

            if (newLocationDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (newLocationDialog.txtNameInput.Text != "" && newLocationDialog.txtStreetNumberAndNameInput.Text != "" && newLocationDialog.txtCountyInput.Text != "" && newLocationDialog.txtPostcodeInput.Text != "" && newLocationDialog.txtLatitudeInput.Text != "" && newLocationDialog.txtLongtitudeInput.Text != "")
                {
                    //put everything into an object and return it
                    locationName = newLocationDialog.txtNameInput.Text;
                    streetNumberAndName = newLocationDialog.txtStreetNumberAndNameInput.Text;
                    county = newLocationDialog.txtCountyInput.Text;
                    postCode = newLocationDialog.txtPostcodeInput.Text;
                    latitude = newLocationDialog.txtLatitudeInput.Text;
                    longtitude = newLocationDialog.txtLongtitudeInput.Text;
                    Year[] newYear = new Year[0];

                    newLocation = new Location(locationName, streetNumberAndName, county, postCode, latitude, longtitude, newYear);

                    return newLocation;
                }
                else
                {
                    MessageBox.Show("Please fill in all fields");
                    return null;
                }

            }
            else
            {
                newLocationDialog.Dispose();
                return null;
            }
        }

        //Saves new location array
        private void SaveNewLocation(Location newLocation)
        {
            //Increase the location arraty by one and then add in the new location object
            GrowArray(ref Data.locationArray);
            Data.locationArray[Data.locationArray.Length - 1] = newLocation;

            OutputLocationList();
        }

        //Gets new year data from user
        private Year NewYearDialog()
        {
            frmNewYear newYearDialog = new frmNewYear();
            Year tempYear;
            int yearDate;
            string yearDescription;
            MonthlyObservations[] newMonthlyObservations = new MonthlyObservations[12];

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (newYearDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (newYearDialog.txtYearDateInput.Text != "" && newYearDialog.txtDescriptionInput.Text != "")
                {
                    try
                    {
                        // Read from textboxes to create a new object to return
                        yearDate = Convert.ToInt32(newYearDialog.txtYearDateInput.Text);
                        yearDescription = newYearDialog.txtDescriptionInput.Text;

                        tempYear = new Year(yearDescription, yearDate, newMonthlyObservations);

                        return tempYear;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Please enter the year as a number");
                        return null;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please fill in all fields");
                    return null;
                }
            }
            else
            {
                newYearDialog.Dispose();
                return null;
            }
        }

        //Saves new year array for a specific location
        private void SaveNewYear(Year newYear)
        {
            //Declare variables and objects
            int locationIndex = GetLocationIndexFromString(), arraySize;
            Location tempLocation = new Location();

            //Call method to increase year array for that location
            tempLocation.IncreaseYearArray(locationIndex);

            //get array size
            arraySize = Data.locationArray[locationIndex].YearsOfObservationsArray.Length;

            //Put new data into an object and then put that into new index
            Data.locationArray[locationIndex].YearsOfObservationsArray[arraySize - 1] = newYear;
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

        //Should I get rid of the return object method? Less helpful and not needed now?
        private Location GetLocationFromString(string locationInput)
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

        private int GetLocationIndexFromString()
        {
            int matchedIndex = 0;
            string locationToCheck, locationInput;
            locationInput = lstLocations.SelectedItem.ToString();
            //loop through locations, find a match and return that object
            for (int i = 0; i < Data.locationArray.Length; i++)
            {
                //Output every location into a string, with the exact same formatting as the input
                locationToCheck = Data.locationArray[i].OutputLocation();

                if (locationToCheck == locationInput)
                {
                    matchedIndex = i;
                    break;
                }
            }
            return matchedIndex;
        }

        private void ClearYearForm()
        {
            //Make this clear the year form - do another for location
            
            //You need this one for when you create a new location, if the array size of the new location is 0 then clear the boxes
        }

        //Output locations
        private void OutputLocationList()
        {
            for (int location = 0; location < Data.locationArray.Length; location++)
            {
                //Calls output location for every location
                lstLocations.Items.Add(Data.locationArray[location].OutputLocation());
            }
        }

        private void OutputLocationData()
        {
            int locationIndex = GetLocationIndexFromString();

            txtName.Text = Data.locationArray[locationIndex].LocationName;
            txtStreetNumberAndName.Text = Data.locationArray[locationIndex].StreetNumberAndName;
            txtCounty.Text = Data.locationArray[locationIndex].County;
            txtPostcode.Text = Data.locationArray[locationIndex].PostCode;
            txtLongtitude.Text = Data.locationArray[locationIndex].Longtitude;
            txtLatitude.Text = Data.locationArray[locationIndex].Latitude;
        }

        //Output all years for one location
        private void OutputYearList()
        {
            int selectedIndex;
            string locationString;

            if (lstLocations.SelectedItem != null)
            {
                dgdMonths.Rows.Clear();
                selectedIndex = lstLocations.SelectedIndex;
                locationString = lstLocations.SelectedItem.ToString();

                //This will return the object with the year and month data for that location inside it
                Location locationMatch = GetLocationFromString(locationString);

                lstYears.Items.Clear();
                //Output all years
                for (int year = 0; year < locationMatch.YearsOfObservationsArray.Length; year++)
                {
                    //call Output Year
                    lstYears.Items.Add(locationMatch.YearsOfObservationsArray[year].OutputYear());
                }

                //Dettach the event handler, clear the box and then reattach handler
                //txtLocationSearch.TextChanged -= txtLocationSearch_TextChanged;
                //txtLocationSearch.Clear();
                //txtLocationSearch.TextChanged += txtLocationSearch_TextChanged;
            }
        }

        private void OutputYearData()
        {
            int locationIndex = GetLocationIndexFromString();
            int yearIndex = lstYears.SelectedIndex;

            txtYearDateInput.Text = Data.locationArray[locationIndex].YearsOfObservationsArray[yearIndex].YearDate.ToString();
            txtDescriptionInput.Text = Data.locationArray[locationIndex].YearsOfObservationsArray[yearIndex].YearDescription;
        }

        //Output all months in a year for a specific location
        private void OutputMonthList(int selectedYear)
        {
            dgdMonths.Rows.Clear();

            string locationString = lstLocations.SelectedItem.ToString();
            Location currentLocation = GetLocationFromString(locationString);
            try
            {
                //Loops through every month
                for (int i = 0; i < 12; i++)
                {
                    //Outputs the month data for location and year selected
                    dgdMonths.Rows.Add(currentLocation.YearsOfObservationsArray[selectedYear].MonthlyObservationsArray[i].MonthName, currentLocation.YearsOfObservationsArray[selectedYear].MonthlyObservationsArray[i].MaxTemp, currentLocation.YearsOfObservationsArray[selectedYear].MonthlyObservationsArray[i].MinTemp, currentLocation.YearsOfObservationsArray[selectedYear].MonthlyObservationsArray[i].DaysAirFrost, currentLocation.YearsOfObservationsArray[selectedYear].MonthlyObservationsArray[i].MmRain, currentLocation.YearsOfObservationsArray[selectedYear].MonthlyObservationsArray[i].HrsSun);
                }
                dgdMonths.Refresh();
            }
            catch (NullReferenceException)
            {
                for (int i = 0; i < 12; i++)
                {
                    dgdMonths.Rows.Add(Data.yearArray[0].MonthlyObservationsArray[i].MonthName, "", "", "", "", "");
                }
            }
        }


        //Method to pull in data from text file
        private void ReadInData()
        {
            //Declare variables
            string filename = "";
            int numberOfLocations, locationIndex = 0;


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
            int monthID, daysAirFrost, year;
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
