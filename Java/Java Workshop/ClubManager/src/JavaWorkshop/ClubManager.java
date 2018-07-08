package JavaWorkshop;

import java.time.LocalDateTime;
import java.util.*;
import java.util.Iterator;

public class ClubManager
{

    public static class Facility
    {
        static HashMap<String, Facility> FacilityMapper = new HashMap<>();

        String FacilityName;
        String Description;

        public Facility()
        {
        }

        private Facility(String facilityName, String description)
        {
            if(description == null)
            {
                description="";
            }
            this.FacilityName = facilityName;
            this.Description = description;
            FacilityMapper.put(facilityName,this);
        }

        private Facility(String facilityName)
        {
            String description = "";
            this.FacilityName = facilityName;
            this.Description = description;
            FacilityMapper.put(facilityName,this);
        }

        public static Facility getFacility(String facilityName)
        {
            return FacilityMapper.get(facilityName);
        }

        public static List<Facility> getFacilities()
        {
            List<Facility> mylist = new ArrayList<Facility>(FacilityMapper.values());
            return mylist;
        }

        public static void removeFacility(String facilityname)
        {
            FacilityMapper.remove(facilityname);
        }

        public static void addFacility(String facilityname, String facilityDesciption)
        {
            new Facility(facilityname,facilityDesciption);
        }

        public static void addFacility(String facilityname)
        {
            new Facility(facilityname);
        }

        public static String Show(String referFacility)
        {
            String myValue = FacilityMapper.get(referFacility).Description;
            if (myValue==null || myValue == "")
            {
                return String.format("%s : Ground floor facilities",referFacility);
            }
            return String.format("%s : {%s}",referFacility,myValue);
        }

        public static void showFacilities()
        {
            List<Facility> mylist = new ArrayList<Facility>(FacilityMapper.values());
            for (Facility X : mylist)
            {
                System.out.println(X.Show(X.FacilityName));
            }
        }

    }


    public static void main(String[] args)
    {
        Club Havana = new Club();

        Person Guest = new Person("Tan","Ah-Kow","");
        Person Guest2 = new Person("Nick","fury");
        Person Guest3 = new Person ("Chow","Ah","Beng");

        Facility.addFacility("Club Disco","Crazy hangout on the 101th floor");
        Facility.addFacility("Toilet");
        Facility.addFacility("Unknown Area","");

        Facility.Show("Toilet");
        Facility.showFacilities();

        Member member1 = Havana.addMember(Guest);
        Member member2 = Havana.addMember("Johnny","Depp","");
        Member member3 = Havana.addMember(Guest2);
        Member member4 = Havana.addMember(Guest3);

        Havana.showMember();

        Havana.removeMember(2);
        System.out.println();
        Havana.showMember();

        Booking book1;
        Booking book2;
        try {
            book1 = new Booking(member1, Facility.getFacility("Toilet"),
                    LocalDateTime.of(2018, 5, 25, 8, 0),
                    LocalDateTime.of(2018, 5, 25, 10, 0));
            System.out.println();
            book1.Show();
            book2 = new Booking(member4, Facility.getFacility("Unknown Area"),
                    LocalDateTime.of(2018, 5, 25, 8, 0),
                    LocalDateTime.of(2018, 5, 25, 10, 0));
            System.out.println();
            System.out.println(book1.overlaps(book2));
        }
        catch (BadBookingException e)
        {
            System.out.println(e);
        }

        BookingRegister Havanabook = new BookingRegister();
        Havanabook.addBooking(Facility.getFacility("Toilet"), member1 ,LocalDateTime.of(2018, 5, 25, 8, 0),
                LocalDateTime.of(2018, 5, 25, 10, 0));
        Havanabook.addBooking(Facility.getFacility("Toilet"), member1 ,LocalDateTime.of(2018, 5, 25, 10, 0),
                LocalDateTime.of(2018, 5, 25, 12, 0));
        Havanabook.addBooking(Facility.getFacility("Toilet"), member1 ,LocalDateTime.of(2018, 5, 25, 12, 0),
                LocalDateTime.of(2018, 5, 25, 14, 0));
        Havana.addBooking(member1,"Toilet" ,LocalDateTime.of(2018, 5, 25, 14, 0),
                LocalDateTime.of(2018, 5, 25, 16, 0));

        ArrayList<Booking> myBookings = Havanabook.getBooking(Facility.getFacility("Toilet"),LocalDateTime.of(2018, 5, 25, 8, 0),
            LocalDateTime.of(2018, 5, 25, 16, 0));
        Booking removebook = null;
        for(Booking X : myBookings)
        {
            System.out.println(X.getBookMember());
            removebook = X;
        }
        System.out.println();
        Havanabook.removeBooking(removebook);

        Havana.showBookings("Toilet",LocalDateTime.of(2018, 5, 25, 8, 0),
                LocalDateTime.of(2018, 5, 25, 16, 0));

    }
}

class BadBookingException extends Exception
{
    public BadBookingException(String s)
    {
        super(s);
    }
}


class BookingRegister
{
    static HashMap<ClubManager.Facility,ArrayList<Booking>> bookregistry = new HashMap<>();

    public BookingRegister()
    {
    }

    public void removeBooking(Booking booking)
    {
        ClubManager.Facility myFac = booking.getBookFacility();
        ArrayList<Booking> mylist = getBooking(myFac,booking.getBooktime1(),booking.getBooktime2());
        Booking tempbook = null;
        if(mylist !=null)
        {
            for(Booking X: mylist)
            {
                if(X.getBooktime1() == booking.getBooktime1() && X.getBooktime2() == booking.getBooktime2())
                {
                    tempbook = X;
                }
            }
        }
        if(tempbook!=null)
        {
            mylist = bookregistry.get(myFac);
            mylist.remove(tempbook);
        }
    }

    public void addBooking(ClubManager.Facility facility, Member member, LocalDateTime startdate, LocalDateTime enddate)
    {
        boolean overlapflag = false;

        try{
            Booking tempbook = new Booking(member,facility,startdate,enddate);
            ArrayList GetList = bookregistry.get(facility);
            if(GetList == null)
            {
                ArrayList<Booking> Templist = new ArrayList<>();
                Templist.add(tempbook);
                bookregistry.put(facility,Templist);
            }
            else
            {
                Iterator<Booking> i = GetList.iterator();
                while(i.hasNext() & overlapflag == false)
                {
                    Booking book1 = i.next();
                    overlapflag = book1.overlaps(tempbook);
                }
                if(overlapflag == false) {
                    GetList.add(tempbook);
                }
                else
                {
                    throw new BadBookingException("Booking overlaps another entry");
                }

            }
        }
        catch(Exception e)
        {
            System.out.println(e);
            return;
        }

    }

    public ArrayList<Booking> getBooking(ClubManager.Facility facility, LocalDateTime startdate, LocalDateTime enddate)
    {

        ArrayList<Booking> bookingbook = new ArrayList<>();
        Member tempmem = new Member(000);


        try{
            Booking tempbook = new Booking(tempmem,facility,startdate,enddate);
            ArrayList GetList = bookregistry.get(facility);
            if(GetList == null)
            {
                return null;
            }
            else
            {
                Iterator<Booking> i = GetList.iterator();
                while(i.hasNext())
                {
                    Booking book1 = i.next();
                    if(book1.overlaps(tempbook))
                    {
                        bookingbook.add(book1);
                    }
                }
                return bookingbook;
            }
        }
        catch(Exception e)
        {
            System.out.println(e);
            return bookingbook;
        }
    }


}

class Booking
{
    Member bookMember;
    ClubManager.Facility bookFacility;
    LocalDateTime booktime1;
    LocalDateTime booktime2;


    public Booking(Member bookm, ClubManager.Facility bookf,
                   LocalDateTime t1, LocalDateTime t2) throws BadBookingException
    {
        try
        {
            if (bookm == null || bookf == null)
                throw new BadBookingException("Please include Member and Facility reference!");
            if (t1 == null || t2 == null)
                throw new BadBookingException("Please include start and end datetime!");
            if (t1.isAfter((t2)))
                throw new BadBookingException("Please ensure end datetime is later than start datetime");
        }
        catch(BadBookingException e)
        {
            System.out.println(e);
        }
        this.bookMember = bookm;
        this.bookFacility = bookf;
        this.booktime1 = t1;
        this.booktime2 = t2;
    }

    public ClubManager.Facility getBookFacility() {
        return bookFacility;
    }

    public Member getBookMember() {
        return bookMember;
    }

    public LocalDateTime getBooktime1() {
        return booktime1;
    }

    public LocalDateTime getBooktime2() {
        return booktime2;
    }

    public boolean overlaps(Booking booking)
    {

        boolean overlap = false;
        LocalDateTime T1Start=this.getBooktime1();
        LocalDateTime T1End=this.getBooktime2();
        LocalDateTime T2Start=booking.getBooktime1();
        LocalDateTime T2End=booking.getBooktime2();

        if(booking.bookFacility == this.bookFacility)
        {
            if (T1Start.isBefore(T2Start))
            {
                if(T1End.isAfter(T2Start))
                {
                    overlap=true;
                }
            }
            else
            {
                if(T2End.isAfter(T1Start))
                {
                    overlap=true;
                }
            }
        }
        return overlap;
    }

    public void Show()
    {
        System.out.println(this.toString());
    }

    public String toString()
    {
        String temp = bookMember.toString() + "\n" + bookFacility.FacilityName + "\n" +
                booktime1.toString() + "\n" + booktime2.toString();
        return temp;
    }
}

class Person {
    private String Surname;
    private String FirstName;
    private String SecondName;

    Person(String surname, String firstname, String secondname) {
        this.Surname = surname;
        this.FirstName = firstname;
        this.SecondName = secondname;
        if (this.SecondName == null) {
            this.SecondName = "";
        }
    }

    Person(String surname, String firstname) {
        this.Surname = surname;
        this.FirstName = firstname;
    }

    public String getSurname() {
        return Surname;
    }

    public String getFirstName() {
        return FirstName;
    }

    public String getSecondName() {
        return SecondName;
    }

    public void setFirstName(String firstName) {
        FirstName = firstName;
    }

    public void setSurname(String surname) {
        Surname = surname;
    }

    public void setSecondName(String secondName) {
        SecondName = secondName;
    }

    public void Show() {
    System.out.println(this.toString());
    }

    public String toString()
    {
        if (getSecondName() == null) {
            return String.format("%s %s", this.getSurname(), this.getFirstName());
        }
        return String.format("%s %s %s", this.getSurname(), this.getFirstName(), this.getSecondName());
    }
}


class Member extends Person
{
    int MemberNumber;

    public Member(int membernumber)
    {
        super("surname","firstname","");
        this.MemberNumber = membernumber;
    }

    public Member(int membernumber, Person person)
    {
        super(person.getSurname(),person.getFirstName(),person.getSecondName());
        this.MemberNumber = membernumber;
    }

    public int getMemberNumber() {
        return MemberNumber;
    }

    public String toString()
    {
        if (getSecondName() == null)
        {
            return String.format("%s %s : %d", this.getSurname(), this.getFirstName(), this.getMemberNumber());
        }
        return String.format("%s %s %s : %d", this.getSurname(), this.getFirstName(), this.getSecondName(), this.getMemberNumber());

    }
}

class Club
{

    int CurrentNumber = 1;
    ArrayList<Member> members = new ArrayList<>();
    private BookingRegister Bookhavana = new BookingRegister();

    public Club()
    {

    }

    public void showBookings(String facilityname, LocalDateTime startdate, LocalDateTime enddate)
    {
        ClubManager.Facility facility = ClubManager.Facility.getFacility(facilityname);
        ArrayList<Booking> mybook = Bookhavana.getBooking(facility,startdate,enddate);
        for (Booking X: mybook)
        {
            X.Show();
        }
    }


    public ArrayList<Booking> getBooking(String facilityname, LocalDateTime startdate, LocalDateTime enddate)
    {
        ClubManager.Facility facility = ClubManager.Facility.getFacility(facilityname);
        ArrayList<Booking> mybook = Bookhavana.getBooking(facility,startdate,enddate);
        return mybook;

    }

    public void addBooking(Member member, String facilityname, LocalDateTime startdate, LocalDateTime enddate)
    {
        ClubManager.Facility facility = ClubManager.Facility.getFacility(facilityname);
        Bookhavana.addBooking(facility,member,startdate,enddate);
    }

    public Member addMember(String surname, String firstname, String secondname)
    {
        Person temperson = new Person(surname,firstname,secondname);
        Member tempMember = new Member(this.CurrentNumber,temperson);
        members.add(tempMember);
        this.CurrentNumber += 1;
        return tempMember;
    }

    public Member addMember(Person person)
    {
        Member tempMember = new Member(this.CurrentNumber,person);
        members.add(tempMember);
        CurrentNumber += 1;
        return tempMember;
    }

    public void removeMember(int membershipnumber)
    {
        Member tempmem = new Member(123);
        boolean removal = false;
        for (Member x : members)
        {
            if(x.MemberNumber == membershipnumber)
            {
                tempmem = x;
                removal=true;
            }
        }
        if (removal)
        {
            members.remove(tempmem);
        }
    }

    public void showMember()
    {
        for (Member x : members)
        {
            System.out.println(x.toString());
        }
    }
}