using System;

namespace BoxDLL
{
    public class MemberBox
    {
        public string NUSID {get; set;}
        public string MemberType { get; set; }
        public string Name { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        //public MemberBox() : this("A000000","Student","NoName",12345678,"No Email") { }

        public MemberBox() : this("A1010101F", "Student", "Janelle", 12345678, "janelle@XB.com") { }
        public MemberBox(string NUSID, string MemberType, string Name, int Mobile, string Email)
        {
            this.NUSID = NUSID;
            this.MemberType = MemberType;
            this.Name = Name;
            this.Mobile = Mobile;
            this.Email = Email;
        }
    }

    public class FacilityBox
    {
        public string FacilityID { get; set; }
        public string Activity { get; set; }
        public string LocationTag { get; set; }
        public string Location { get; set; }
        public string Remarks { get; set; }
        //public FacilityBox() : this("No ID", "No Facility Name", "No Location Tag", "No Location", "No Operating Hours") { }
        public FacilityBox() : this("DRAGONBOAT1", "Dragon Boat", "NUS Pond", "NUS Pond", "No fishing") { }
        public FacilityBox(string FacilityID, string Activity, string LocationTag, string Location, string Remarks)
        {
            this.FacilityID = FacilityID;
            this.Activity = Activity;
            this.LocationTag = LocationTag;
            this.Location = Location;
            this.Remarks = Remarks;
        }
    }

    public class TransactionBox
    {
        public int TransactionID { get; set; }
        public string TransactionType { get; set; }
        public string NUSID { get; set; }
        public string FacilityID { get; set; }
        public DateTime TransDateTime { get; set; }
        public DateTime BookingDateTime { get; set; }
        public int TimeSlot { get; set; }
        //public TransactionBox() : this (0, "No Transaction Type", "No ID", "No Facility ID", new DateTime(),new DateTime(),0) { }
        public TransactionBox() : this(100, "No Transaction Type", "No ID", "No Facility ID", DateTime.Parse("2018-03-15 00:00:00.000"), DateTime.Parse("2018-03-15 00:00:00.000"), 1) { }

        public TransactionBox(int TransactionID, string TransactionType, string NUSID, string FacilityID, DateTime TransDateTime, DateTime BookingDateTime, int TimeSlot)
        {
            this.TransactionID = TransactionID;
            this.TransactionType = TransactionType;
            this.NUSID = NUSID;
            this.FacilityID = FacilityID;
            this.TransDateTime = TransDateTime;
            this.BookingDateTime = BookingDateTime;
            this.TimeSlot = TimeSlot;
        }
    }

    public class AvailabilityCheckBox
    {
        public int TransactionID { get; set; }
        public string FacilityID { get; set; }
        public DateTime BookingDate { get; set; }
        public int Timeslot { get; set; }
        //public AvailabilityCheckBox() : this(0,"No ID",new DateTime(),0 ) { }
        public AvailabilityCheckBox() : this(100, "DRAGONBOAT1", DateTime.Parse("2018-03-15 00:00:00.000"), 1) { }

        public AvailabilityCheckBox(int TransactionID, string FacilityID, DateTime BookingDate, int Timeslot)
        {
            this.TransactionID = TransactionID;
            this.FacilityID = FacilityID;
            this.BookingDate = BookingDate;
            this.Timeslot = Timeslot;
        }
    }

}






