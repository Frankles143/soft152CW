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
using System.Drawing.Drawing2D;

namespace Weather_Stations_CW
{
    //TO DO LIST
    //Fix graph
    //Get rid of object search, and fix normal search somehow - see notes
    //Need some exception handling for pulling in data - check problems

    //Problems
    //Postcodes don't output in a regular way
    //Waddington prints out streetnum weirdly - add exception that if left default like that it just "" that field?
    //Location info goes out of box
    //One of the location's has an ' that is printed out weirdly

    public partial class frmHome : Form
    {
        private bool fileLoaded = false, stillEditing = false;
        private int saveOrEdit;

        //Form events and buttons

        public frmHome()
        {
            InitializeComponent();
        }

        //Reads in data, spits out location data for user to choose from and then brings the form into focus
        private void frmHome_Load(object sender, EventArgs e)
        {
            //While loop to make sure users select a file
            while (fileLoaded == false)
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
                    fileLoaded = true;
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

        }

        private void txtLocationSearch_TextChanged(object sender, EventArgs e)
        {
            dgdMonths.Rows.Clear();
            lstYears.Items.Clear();
            SearchLocations();
            ClearYearForm();
            ClearLocationForm();
            btnEditLocation.Enabled = false;
            btnNewYear.Enabled = false;
            btnEditYear.Enabled = false;
        }

        private void lstLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutputYearList();
            OutputLocationData();
            OutputLocationData();
            btnNewYear.Enabled = true;
            btnEditLocation.Enabled = true;
            btnEditYear.Enabled = false;
            //If lstYears has items in it then change the selected index to 0, otherwise, clear year form ready for a new year
            if (lstYears.SelectedIndex >= -1 && lstYears.Items.Count > 0)
            {
                lstYears.SelectedIndex = 0;
                OutputMonthList();
                pnlGraphics.Refresh();
                PanelUpdates();
            }
            else if (lstYears.Items.Count == 0)
            {
                ClearYearForm();
            }

        }

        private void lstYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutputMonthList();
            OutputYearData();
            pnlGraphics.Refresh();
            PanelUpdates();
            btnEditYear.Enabled = true;
            btnEditMonth.Enabled = true;
        }

        private void btnNewLocation_Click(object sender, EventArgs e)
        {
            stillEditing = true;
            saveOrEdit = 0;
            //Dettach the event handler, change the selected index and then reattach the event handler
            lstLocations.SelectedIndexChanged -= lstLocations_SelectedIndexChanged;
            lstLocations.SelectedIndex = -1;
            lstLocations.SelectedIndexChanged += lstLocations_SelectedIndexChanged;

            ClearLocationForm();
            ClearYearForm();

            //Set focus for the location name
            txtName.Focus();

            DisableButtonsNewLocation();
        }

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            stillEditing = true;
            saveOrEdit = 1;
            DisableButtonsNewLocation();

        }

        private void btnCancelNewLocation_Click(object sender, EventArgs e)
        {
            //Re enable everything to cancel the new location process
            stillEditing = false;
            pnlGraphics.Refresh();
            OutputLocationList();
            EnableButtonsNewLocation();
            lstLocations.SelectedIndex = 0;
        }

        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            //Decide between edit or save
            if (saveOrEdit == 0)
            {
                NewLocation();
            }
            else if (saveOrEdit == 1)
            {
                EditLocation();
            }
        }

        private void btnNewYear_Click(object sender, EventArgs e)
        {
            stillEditing = true;
            saveOrEdit = 0;
            //Remove the event handler, then change the selected index, then add the event handler back on
            lstYears.SelectedIndexChanged -= lstYears_SelectedIndexChanged;
            lstYears.SelectedIndex = -1;
            lstYears.SelectedIndexChanged += lstYears_SelectedIndexChanged;

            ClearYearForm();

            //Set focus for the year date
            txtYearDateInput.Focus();

            DisableButtonsNewYear();
        }

        private void btnEditYear_Click(object sender, EventArgs e)
        {
            stillEditing = true;
            saveOrEdit = 1;
            DisableButtonsNewYear();
        }

        private void btnCancelNewYear_Click(object sender, EventArgs e)
        {
            //Re enable everything to cancel the new year process
            stillEditing = false;
            pnlGraphics.Refresh();
            OutputLocationList();
            OutputYearList();
            EnableButtonsNewYear();
            lstLocations.SelectedIndex = 0;
        }

        private void btnSaveYear_Click(object sender, EventArgs e)
        {
            if (saveOrEdit == 0)
            {
                NewYear();
            }
            else if (saveOrEdit == 1)
            {
                EditYear();
            }
        }

        private void btnEditMonth_Click(object sender, EventArgs e)
        {
            stillEditing = true;
            dgdMonths.ReadOnly = false;
            DisableButtonsEditMonth();
        }

        private void btnSaveMonth_Click(object sender, EventArgs e)
        {
            SaveMonthData();
        }

        private void btnCancelEditMonth_Click(object sender, EventArgs e)
        {
            stillEditing = false;
            pnlGraphics.Refresh();
            EnableButtonsEditMonth();
            OutputMonthList();
        }

        private void dgdMonths_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (stillEditing == false)
            {
                btnEditMonth.Enabled = true;
            }
        }

        private void cmbGraphicOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlGraphics.Refresh();
            PanelUpdates();
        }

        private void pnlGraphics_Paint(object sender, PaintEventArgs e)
        {
            PanelUpdates();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Methods

        private void PanelUpdates()
        {
            Pen redPen;
            Pen blackPen;
            int penSize = 2, gapBetweenPoints = 35;
            Color myColour = Color.Red;
            Color black = Color.Black;

            redPen = new Pen(myColour, penSize);
            blackPen = new Pen(black, penSize);

            //error checking, seeing if the file has been pulled in, whether the user is editing or adding a location and to make sure there is a year of data to output
            if (fileLoaded == true && stillEditing == false && lstYears.Items.Count > 0)
            {
                using (Graphics panelGraphics = pnlGraphics.CreateGraphics())
                {
                    //Declare points and vars
                    Point p1 = new Point();
                    Point p2 = new Point();

                    //300 pixels between the chart lines X
                    //3 pixels is 1%
                    //430 pixels between lines Y
                    //430/12 = ~35
                    int topOfGraph = 10, onePercent = 3;
                    //the ? allows these two doubles to be nulled, this is for error checking
                    double? value = 0, difference = 0;

                    //Create pens
                    panelGraphics.DrawLine(blackPen, 10, 10, 10, 310);
                    panelGraphics.DrawLine(blackPen, 10, 310, 440, 310);

                    for (int i = 0; i < 12; i++)
                    {
                        double newY = 0;

                        //Grabs the value and difference depending on drop down option
                        MonthDataSwitch(ref value, ref difference, i);

                        if (value != null && difference != null)
                        {
                            //Make sure that the next point starts from the last point
                            p1 = p2;

                            //p2.X will be increased by a set amount so points are equal distance apart 
                            p2.X = p2.X + gapBetweenPoints;

                            //New p2.Y co-ord is made using method and some maths
                            newY = (PercentageCalcAndInvert(value, difference) * onePercent) + topOfGraph;
                            p2.Y = Convert.ToInt32(newY);

                            if (p1.X != 0 && p2.X != 0)
                            {
                                panelGraphics.DrawLine(blackPen, p1, p2);
                            }

                            //Draws dot at p2
                            panelGraphics.DrawPie(blackPen, p2.X - 2.5f, p2.Y - 2.5f, 5, 5, 0, 360);
                            panelGraphics.FillPie(new SolidBrush(Color.Black), p2.X - 2.5f, p2.Y - 2.5f, 5, 5, 0, 360);
                        }
                    }
                }
            }
            redPen.Dispose();
            blackPen.Dispose();
        }

        private void MonthDataSwitch(ref double? value, ref double? difference, int currentIndex)
        {
            double highestCurrentValue = 0, lowestCurrentValue = 500000, tempCurrentValue = 0, average = 0, runningTotal = 0;
            //Returns value depending on drop down option
            switch (cmbGraphicOptions.SelectedIndex)
            {
                
                case -1:
                    value = null;
                    difference = null;
                    break;
                case 0:
                    value = Data.locationArray[GetLocationIndexFromString()].YearsOfObservationsArray[lstYears.SelectedIndex].MonthlyObservationsArray[currentIndex].MaxTemp;

                    //Cycles through each month and will eventually end up with highest, lowest and average values
                    for (int i = 0; i < 12; i++)
                    {
                        tempCurrentValue = Data.locationArray[GetLocationIndexFromString()].YearsOfObservationsArray[lstYears.SelectedIndex].MonthlyObservationsArray[i].MaxTemp;
                        if (tempCurrentValue > highestCurrentValue)
                        {
                            highestCurrentValue = tempCurrentValue;
                        }
                        if (tempCurrentValue < lowestCurrentValue)
                        {
                            lowestCurrentValue = tempCurrentValue;
                        }
                        runningTotal = runningTotal + tempCurrentValue;
                    }

                    average = runningTotal / 12;

                    
                    

                    //The difference for the graph is calculated and then 10% is added to make sure there is enough room
                    difference = (highestCurrentValue - 0) * 1.1;
                    break;
                case 1:
                    value = Data.locationArray[GetLocationIndexFromString()].YearsOfObservationsArray[lstYears.SelectedIndex].MonthlyObservationsArray[currentIndex].MinTemp;

                    //Cycles through each month and will eventually end up with highest and lowest values
                    for (int i = 0; i < 12; i++)
                    {
                        tempCurrentValue = Data.locationArray[GetLocationIndexFromString()].YearsOfObservationsArray[lstYears.SelectedIndex].MonthlyObservationsArray[i].MinTemp;
                        if (tempCurrentValue > highestCurrentValue)
                        {
                            highestCurrentValue = tempCurrentValue;
                        }
                        if (tempCurrentValue < lowestCurrentValue)
                        {
                            lowestCurrentValue = tempCurrentValue;
                        }
                        runningTotal = runningTotal + tempCurrentValue;
                    }

                    average = runningTotal / 12;

                    //The difference is calculated and then 10% is added to make sure there is enough room on the graph
                    difference = (highestCurrentValue - 0) * 1.1;
                    break;
                case 2:
                    value = Data.locationArray[GetLocationIndexFromString()].YearsOfObservationsArray[lstYears.SelectedIndex].MonthlyObservationsArray[currentIndex].DaysAirFrost;

                    //Cycles through each month and will eventually end up with highest and lowest values
                    for (int i = 0; i < 12; i++)
                    {
                        tempCurrentValue = Data.locationArray[GetLocationIndexFromString()].YearsOfObservationsArray[lstYears.SelectedIndex].MonthlyObservationsArray[i].DaysAirFrost;
                        if (tempCurrentValue > highestCurrentValue)
                        {
                            highestCurrentValue = tempCurrentValue;
                        }
                        if (tempCurrentValue < lowestCurrentValue)
                        {
                            lowestCurrentValue = tempCurrentValue;
                        }
                        runningTotal = runningTotal + tempCurrentValue;
                    }

                    average = runningTotal / 12;

                    //The difference is calculated and then 10% is added to make sure there is enough room on the graph
                    difference = (highestCurrentValue - 0) * 1.1;
                    break;
                case 3:
                    value = Data.locationArray[GetLocationIndexFromString()].YearsOfObservationsArray[lstYears.SelectedIndex].MonthlyObservationsArray[currentIndex].MmRain;

                    //Cycles through each month and will eventually end up with highest and lowest values
                    for (int i = 0; i < 12; i++)
                    {
                        tempCurrentValue = Data.locationArray[GetLocationIndexFromString()].YearsOfObservationsArray[lstYears.SelectedIndex].MonthlyObservationsArray[i].MmRain;
                        if (tempCurrentValue > highestCurrentValue)
                        {
                            highestCurrentValue = tempCurrentValue;
                        }
                        if (tempCurrentValue < lowestCurrentValue)
                        {
                            lowestCurrentValue = tempCurrentValue;
                        }
                        runningTotal = runningTotal + tempCurrentValue;
                    }

                    average = runningTotal / 12;

                    //The difference is calculated and then 10% is added to make sure there is enough room on the graph
                    difference = (highestCurrentValue - 0) * 1.1;
                    break;
                case 4:
                    value = Data.locationArray[GetLocationIndexFromString()].YearsOfObservationsArray[lstYears.SelectedIndex].MonthlyObservationsArray[currentIndex].HrsSun;

                    //Cycles through each month and will eventually end up with highest and lowest values
                    for (int i = 0; i < 12; i++)
                    {
                        tempCurrentValue = Data.locationArray[GetLocationIndexFromString()].YearsOfObservationsArray[lstYears.SelectedIndex].MonthlyObservationsArray[i].HrsSun;
                        if (tempCurrentValue > highestCurrentValue)
                        {
                            highestCurrentValue = tempCurrentValue;
                        }
                        if (tempCurrentValue < lowestCurrentValue)
                        {
                            lowestCurrentValue = tempCurrentValue;
                        }
                        runningTotal = runningTotal + tempCurrentValue;
                    }

                    average = runningTotal / 12;

                    //The difference is calculated and then 10% is added to make sure there is enough room on the graph
                    difference = (highestCurrentValue - 0) * 1.1;
                    break;
                default:
                    value = null;
                    break;
            }
            //Print out numbers after calculations are complete
            lblAverage.Text = string.Format($"{average:0.00}");
            lblHighestValue.Text = highestCurrentValue.ToString();
            lblLowestValue.Text = lowestCurrentValue.ToString();
            lblMaxValue.Text = highestCurrentValue.ToString();
        }

        private double PercentageCalcAndInvert(double? value, double? difference)
        {
            double percent, returnPercent;

            //Finds percent given two values
            percent = Convert.ToDouble((value / difference) * 100);

            //inverts the percentage because of how the graph works
            returnPercent = 100 - percent;

            //Returns a percent I can use for the graph
            return returnPercent;
        }

        private void NewLocation()
        {
            string locationName, streetNumberAndName, county, postCode, latitude, longtitude;
            Location newLocation;

            if (txtName.Text != "" && txtStreetNumberAndName.Text != "" && txtCounty.Text != "" && txtPostcode.Text != "" && txtLatitude.Text != "" && txtLongtitude.Text != "")
            {
                //put everything into an object and return it
                locationName = txtName.Text;
                streetNumberAndName = txtStreetNumberAndName.Text;
                county = txtCounty.Text;
                postCode = txtPostcode.Text;
                latitude = txtLatitude.Text;
                longtitude = txtLongtitude.Text;
                Year[] newYear = new Year[0];

                newLocation = new Location(locationName, streetNumberAndName, county, postCode, latitude, longtitude, newYear);

                //Increase the location array by one and then add in the new location object
                GrowArray(ref Data.locationArray);
                Data.locationArray[Data.locationArray.Length - 1] = newLocation;

                //Clears old list to output new one with updated array
                lstLocations.Items.Clear();
                OutputLocationList();

                EnableButtonsNewLocation();

                lstLocations.SelectedIndex = 0;

                WriteOutData();
                stillEditing = false;
                pnlGraphics.Refresh();
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        private void EditLocation()
        {
            string locationName, streetNumberAndName, county, postCode, latitude, longtitude;
            Location newLocation;
            int selectedLocation = GetLocationIndexFromString();

            if (txtName.Text != "" && txtStreetNumberAndName.Text != "" && txtCounty.Text != "" && txtPostcode.Text != "" && txtLatitude.Text != "" && txtLongtitude.Text != "")
            {
                //put everything into an object and return it
                locationName = txtName.Text;
                streetNumberAndName = txtStreetNumberAndName.Text;
                county = txtCounty.Text;
                postCode = txtPostcode.Text;
                latitude = txtLatitude.Text;
                longtitude = txtLongtitude.Text;
                Year[] newYear = Data.locationArray[selectedLocation].YearsOfObservationsArray;

                newLocation = new Location(locationName, streetNumberAndName, county, postCode, latitude, longtitude, newYear);

                Data.locationArray[selectedLocation] = newLocation;

                //Clears old list to output new one with updated array
                lstLocations.Items.Clear();
                OutputLocationList();

                EnableButtonsNewLocation();

                lstLocations.SelectedIndex = 0;
                stillEditing = false;
                pnlGraphics.Refresh();
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        //Gets new year data from user
        private void NewYear()
        {
            Year newYear;
            int yearDate;
            string yearDescription;
            MonthlyObservations[] newMonthlyObservations = new MonthlyObservations[12];

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (txtYearDateInput.Text != "" && txtDescriptionInput.Text != "")
            {
                try
                {
                    // Read from textboxes to create a new object to return
                    yearDate = Convert.ToInt32(txtYearDateInput.Text);
                    yearDescription = txtDescriptionInput.Text;

                    newYear = new Year(yearDescription, yearDate, newMonthlyObservations);

                    SaveNewYear(newYear);

                    lstYears.Items.Clear();
                    OutputYearList();

                    EnableButtonsNewYear();

                    //Remove event handler, change the index and then reattach the handler
                    lstYears.SelectedIndexChanged -= lstYears_SelectedIndexChanged;
                    lstYears.SelectedIndex = (lstYears.Items.Count - 1);
                    lstYears.SelectedIndexChanged += lstYears_SelectedIndexChanged;

                    dgdMonths.ReadOnly = false;
                    DisableButtonsEditMonth();
                    btnCancelEditMonth.Enabled = false;
                    btnEditMonth.Enabled = false;
                    OutputMonthList();
                    stillEditing = false;
                    pnlGraphics.Refresh();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter the year as a number");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
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

        private void EditYear()
        {
            Year tempYear;
            int yearDate;
            string yearDescription;
            int locationIndex = GetLocationIndexFromString();
            int yearIndex = lstYears.SelectedIndex;
            MonthlyObservations[] monthlyObservations = Data.locationArray[locationIndex].YearsOfObservationsArray[yearIndex].MonthlyObservationsArray;

            if (txtYearDateInput.Text != "" && txtDescriptionInput.Text != "")
            {
                try
                {
                    // Read from textboxes to create a new object to return
                    yearDate = Convert.ToInt32(txtYearDateInput.Text);
                    yearDescription = txtDescriptionInput.Text;

                    tempYear = new Year(yearDescription, yearDate, monthlyObservations);

                    Data.locationArray[locationIndex].YearsOfObservationsArray[yearIndex] = tempYear;

                    lstYears.Items.Clear();
                    OutputYearList();

                    EnableButtonsNewYear();
                    stillEditing = false;
                    pnlGraphics.Refresh();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter the year as a number");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        private void SaveMonthData()
        {
            //Checks to see if every cell is full first
            if (DatagridChecker() == true)
            {
                //declare vars
                int monthId, daysAirFrost;
                double maxTemp, minTemp, mmRain, hrsSun;
                int locationIndex = GetLocationIndexFromString();
                int yearIndex = lstYears.SelectedIndex;
                MonthlyObservations tempMonthlyObservations;
                try
                {
                    //Cycle through each row to grab all the data for one month, put that month into it's own index and do that for the whole year - as long as no exception is thrown!
                    for (int i = 0; i < 12; i++)
                    {

                        monthId = i + 1;
                        maxTemp = Convert.ToDouble(dgdMonths.Rows[i].Cells["maxTemp"].Value);
                        minTemp = Convert.ToDouble(dgdMonths.Rows[i].Cells["minTemp"].Value);
                        daysAirFrost = Convert.ToInt32(dgdMonths.Rows[i].Cells["daysAirFrost"].Value);
                        mmRain = Convert.ToDouble(dgdMonths.Rows[i].Cells["mmRain"].Value);
                        hrsSun = Convert.ToDouble(dgdMonths.Rows[i].Cells["hrsSun"].Value);

                        tempMonthlyObservations = new MonthlyObservations(monthId, maxTemp, minTemp, daysAirFrost, mmRain, hrsSun);

                        Data.locationArray[locationIndex].YearsOfObservationsArray[yearIndex].MonthlyObservationsArray[i] = tempMonthlyObservations;

                    }
                    //Output the new array
                    GetMonthName();
                    OutputMonthList();
                    EnableButtonsEditMonth();
                    WriteOutData();
                    stillEditing = false;
                    pnlGraphics.Refresh();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter month data in numbers!");
                }
            }
        }

        private bool DatagridChecker()
        {
            //Checks every cell to make sure it has data inside it
            for (int i = 0; i < dgdMonths.Rows.Count; i++)
            {
                for (int j = 0; j < dgdMonths.ColumnCount; j++)
                {
                    if (dgdMonths.Rows[i].Cells[j].Value == null)
                    {
                        MessageBox.Show("Please fill in all fields!");
                        return false;
                    }
                }
            }
            return true;
        }

        private void DisableButtonsNewLocation()
        {
            //Disable/enable listboxes, buttons etc.
            lstLocations.Enabled = false;
            txtLocationSearch.Enabled = false;
            btnNewLocation.Enabled = false;
            btnEditLocation.Enabled = false;
            btnCancelNewLocation.Enabled = true;

            txtName.ReadOnly = false;
            txtStreetNumberAndName.ReadOnly = false;
            txtCounty.ReadOnly = false;
            txtPostcode.ReadOnly = false;
            txtLongtitude.ReadOnly = false;
            txtLatitude.ReadOnly = false;

            btnSaveLocation.Enabled = true;

            grpYear.Enabled = false;
            grpMonths.Enabled = false;
        }

        private void EnableButtonsNewLocation()
        {
            //Enable listboxes and buttons that were disabled during the new location process
            grpLocation.Enabled = true;
            lstLocations.Enabled = true;
            txtLocationSearch.Enabled = true;
            btnNewLocation.Enabled = true;
            btnEditLocation.Enabled = true;

            txtName.ReadOnly = true;
            txtStreetNumberAndName.ReadOnly = true;
            txtCounty.ReadOnly = true;
            txtPostcode.ReadOnly = true;
            txtLongtitude.ReadOnly = true;
            txtLatitude.ReadOnly = true;

            grpYear.Enabled = true;
            grpMonths.Enabled = true;

            btnSaveLocation.Enabled = false;
            btnSaveYear.Enabled = false;
            btnSaveMonth.Enabled = false;
            btnCancelNewLocation.Enabled = false;
        }

        private void DisableButtonsNewYear()
        {
            //Disable/enable listboxes, buttons etc.
            lstYears.Enabled = false;
            btnNewYear.Enabled = false;
            btnEditYear.Enabled = false;
            btnSaveYear.Enabled = true;
            btnCancelNewYear.Enabled = true;

            txtYearDateInput.ReadOnly = false;
            txtDescriptionInput.ReadOnly = false;

            grpLocation.Enabled = false;
            grpMonths.Enabled = false;
        }

        private void EnableButtonsNewYear()
        {
            //Disable/enable listboxes, buttons etc.
            grpLocation.Enabled = true;
            grpYear.Enabled = true;
            lstYears.Enabled = true;
            btnNewYear.Enabled = true;
            btnEditYear.Enabled = true;
            btnCancelNewYear.Enabled = false;

            txtYearDateInput.ReadOnly = true;
            txtDescriptionInput.ReadOnly = true;

            grpMonths.Enabled = true;

            btnSaveLocation.Enabled = false;
            btnSaveYear.Enabled = false;
            btnSaveMonth.Enabled = false;
        }

        private void DisableButtonsEditMonth()
        {
            grpLocation.Enabled = false;
            grpYear.Enabled = false;

            btnEditMonth.Enabled = false;
            btnSaveMonth.Enabled = true;
            btnCancelEditMonth.Enabled = true;

            dgdMonths.Columns["monthId"].ReadOnly = true;
        }

        private void EnableButtonsEditMonth()
        {
            grpLocation.Enabled = true;
            grpYear.Enabled = true;
            grpMonths.Enabled = true;

            btnEditMonth.Enabled = true;
            btnSaveMonth.Enabled = false;
            btnCancelEditMonth.Enabled = false;
            dgdMonths.ReadOnly = true;
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

        private void ClearLocationForm()
        {
            txtName.Clear();
            txtStreetNumberAndName.Clear();
            txtCounty.Clear();
            txtPostcode.Clear();
            txtLatitude.Clear();
            txtLongtitude.Clear();
        }

        private void ClearYearForm()
        {
            txtDescriptionInput.Clear();
            txtYearDateInput.Clear();

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
        private void OutputMonthList()
        {
            if (dgdMonths.Rows.Count > 0)
            {
                try
                {
                    dgdMonths.Rows.Clear();
                    //Changes the selected index only if nothing was selected before
                    if (cmbGraphicOptions.SelectedIndex == -1)
                    {
                        cmbGraphicOptions.SelectedIndex = 0;
                    }

                    int currentLocation = GetLocationIndexFromString();
                    int selectedYear = lstYears.SelectedIndex;

                    //Loops through every month
                    for (int i = 0; i < 12; i++)
                    {
                        //Outputs the month data for location and year selected
                        dgdMonths.Rows.Add(Data.locationArray[currentLocation].YearsOfObservationsArray[selectedYear].MonthlyObservationsArray[i].MonthName, Data.locationArray[currentLocation].YearsOfObservationsArray[selectedYear].MonthlyObservationsArray[i].MaxTemp, Data.locationArray[currentLocation].YearsOfObservationsArray[selectedYear].MonthlyObservationsArray[i].MinTemp, Data.locationArray[currentLocation].YearsOfObservationsArray[selectedYear].MonthlyObservationsArray[i].DaysAirFrost, Data.locationArray[currentLocation].YearsOfObservationsArray[selectedYear].MonthlyObservationsArray[i].MmRain, Data.locationArray[currentLocation].YearsOfObservationsArray[selectedYear].MonthlyObservationsArray[i].HrsSun);
                    }
                    dgdMonths.Refresh();
                }
                catch (NullReferenceException e)
                {
                    MessageBox.Show("Null reference exception!" + e.Message);
                }
            }
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    dgdMonths.Rows.Add(Data.locationArray[0].YearsOfObservationsArray[0].MonthlyObservationsArray[i].MonthName, "", "", "", "", "");
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

        private string outputFilename = "";

        //Saves all the locations, years and months to a file
        private void WriteOutData()
        {
            //Choosing where to save - only have to do this once
            if (outputFilename == "")
            {
                dlgSaveData.ShowDialog();
                outputFilename = dlgSaveData.FileName;
            }

            //Grab number of locations
            int numberOfLocations = Data.locationArray.Length;

            //Opens streamwriter
            using (StreamWriter fileOutput = new StreamWriter(outputFilename))
            {
                fileOutput.WriteLine(numberOfLocations);

                //Loop for how many locations there are before closing the streamwriter
                for (int location = 0; location < numberOfLocations; location++)
                {
                    WriteLocation(fileOutput, location);
                }
            }
        }

        private void WriteLocation(StreamWriter fileOutput, int location)
        {
            //Grab number of years for this location
            int numberOfYears = Data.locationArray[location].YearsOfObservationsArray.Length;

            //Write in location data
            fileOutput.WriteLine(Data.locationArray[location].LocationName);
            fileOutput.WriteLine(Data.locationArray[location].StreetNumberAndName);
            fileOutput.WriteLine(Data.locationArray[location].County);
            fileOutput.WriteLine(Data.locationArray[location].PostCode);
            fileOutput.WriteLine(Data.locationArray[location].Latitude);
            fileOutput.WriteLine(Data.locationArray[location].Longtitude);

            fileOutput.WriteLine(numberOfYears);

            //Loop for number of years in that location
            for (int year = 0; year < numberOfYears; year++)
            {
                WriteYear(fileOutput, location, year);
            }
        }

        private void WriteYear(StreamWriter fileOutput, int location, int year)
        {
            //Write out year data
            fileOutput.WriteLine(Data.locationArray[location].YearsOfObservationsArray[year].YearDescription);

            //Loop for 12 months
            for (int month = 0; month < 12; month++)
            {
                fileOutput.WriteLine(Data.locationArray[location].YearsOfObservationsArray[year].YearDate);
                WriteMonth(fileOutput, location, year, month);
            }
        }

        private void WriteMonth(StreamWriter fileOutput, int location, int year, int month)
        {
            //Write out all the month data
            fileOutput.WriteLine(Data.locationArray[location].YearsOfObservationsArray[year].MonthlyObservationsArray[month].MonthId);
            fileOutput.WriteLine(Data.locationArray[location].YearsOfObservationsArray[year].MonthlyObservationsArray[month].MaxTemp);
            fileOutput.WriteLine(Data.locationArray[location].YearsOfObservationsArray[year].MonthlyObservationsArray[month].MinTemp);
            fileOutput.WriteLine(Data.locationArray[location].YearsOfObservationsArray[year].MonthlyObservationsArray[month].DaysAirFrost);
            fileOutput.WriteLine(Data.locationArray[location].YearsOfObservationsArray[year].MonthlyObservationsArray[month].MmRain);
            fileOutput.WriteLine(Data.locationArray[location].YearsOfObservationsArray[year].MonthlyObservationsArray[month].HrsSun);
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
