﻿namespace NFleet.Data
{
    public class AddressData
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string ApartmentLetter { get; set; }
        public int ApartmentNumber { get; set; }
        public AddressResolution Resolution { get; set; }
        public double Confidence { get; set; }
    }
}