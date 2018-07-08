using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportFacilitySystem
{
    //code by Jason
    class TimeSlotBox
    {
        public string Activity { get; set; }
        public string FacilityID { get; set; }
        public DateTime Bookdate { get; set; }
        public int Timeslot {get;set;}
        public bool Available { get; set; }

        public TimeSlotBox():this ("BADMINTON","BADMINTON1",new DateTime(),1,true)
        { }
        public TimeSlotBox(string Activity,string FacilityID,DateTime Bookdate, int Timeslot,bool Available)
        {
            this.Activity = Activity;
            this.FacilityID = FacilityID;
            this.Bookdate = Bookdate;
            this.Timeslot = Timeslot;
            this.Available = Available;
        }
    }
}
