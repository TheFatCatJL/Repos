using System;
using BoxDLL;

namespace CommonBots
{
    class BoxBot
    {
        public BoxBot()
        { }
                
        public TransactionBox TBoxFull()
        {
            TransactionBox TBox = new TransactionBox();
            //TBox.NUSID = button;
            //TBox.TransactionID = button;
            //TBox.BookingDateTime = button;
            //TBox.FacilityID = button;
            //TBox.TimeSlot = button;
            //TBox.TransactionType = button;
            //TBox.TransDateTime = button;
            return TBox;
        }
        public MemberBox MemberBoxFull()
        {
            MemberBox MBox = new MemberBox();
            //MBox.Email = button;
            //MBox.MemberType = button;
            //MBox.Mobile = button;
            //MBox.Name = button;
            //MBox.NUSID = button.ToUpper();
            return MBox;
        }

        public FacilityBox FacilityBoxFull()
        {
            FacilityBox FBox = new FacilityBox();
            //FBox.FacilityID = button.ToUpper();
            //FBox.Activity = button;
            //FBox.LocationTag = Button;
            //FBox.Location = button;
            //FBox.Remarks = button;
            return FBox;
        }
        
        public AvailabilityCheckBox AvailabilityBoxFull()
        {
            AvailabilityCheckBox ABox = new AvailabilityCheckBox();
            //ABox.BookingDate = button;
            //ABox.FacilityID = button;
            //ABox.Timeslot = button;
            //ABox.TransactionID = button;
            return ABox;
        }
    }
}
