using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Stations_CW
{
    class Location
    {
        //Declaring variables
        private string locationName, streetNumberAndName, county, postCode, latitude, longtitude;
        private Year[] yearsOfObservationsArray;

        //Constructor
        public Location(string theLocationName, string theStreetNameAndNumber, string theCounty, string thePostCode, string theLatitude, string theLongtitude, Year[] theYearsOfObservationsArray)
        {
            LocationName = theLocationName;
            StreetNumberAndName = theStreetNameAndNumber;
            County = theCounty;
            PostCode = thePostCode;
            Latitude = theLatitude;
            Longtitude = theLongtitude;
            YearsOfObservationsArray = theYearsOfObservationsArray;
        }

        public Location(string theLocationName, string theStreetNameAndNumber, string theCounty, string thePostCode, string theLatitude, string theLongtitude)
        {
            LocationName = theLocationName;
            StreetNumberAndName = theStreetNameAndNumber;
            County = theCounty;
            PostCode = thePostCode;
            Latitude = theLatitude;
            Longtitude = theLongtitude;
        }

        //Properties
        public string LocationName
        {
            set
            {
                locationName = value; 
            }
            get
            {
                return locationName;
            }
        }

        public string StreetNumberAndName
        {
            set
            {
                streetNumberAndName = value;
            }
            get
            {
                return streetNumberAndName;
            }
        }

        public string County
        {
            set
            {
                county = value;
            }
            get
            {
                return county;
            }
        }

        public string PostCode
        {
            set
            {
                postCode = value;
            }
            get
            {
                return postCode;
            }
        }

        public string Latitude
        {
            set
            {
                latitude = value;
            }
            get
            {
                return latitude;
            }
        }

        public string Longtitude
        {
            set
            {
                longtitude = value;
            }
            get
            {
                return longtitude;
            }
        }

        public Year[] YearsOfObservationsArray
        {
            set
            {
                yearsOfObservationsArray = value;
            }
            get
            {
                return yearsOfObservationsArray;
            }
        }

        //string locationName, streetNumberAndName, county, postCode, latitude, longtitude;
        //Outputting
        public string OutputLocation()
        {
            string messageOut = "";

            messageOut = string.Format($"Name and address: {LocationName}, {StreetNumberAndName}, {County}, {PostCode}. Latitude and longtitude: {Latitude},{Longtitude}");

            return messageOut;
        }
    }
}
