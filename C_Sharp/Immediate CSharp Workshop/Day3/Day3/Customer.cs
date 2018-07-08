using System;

namespace CustomerRecord
{
    public class Customer
    {
        string CustomerName;
        string CustomerAddress;
        string CustomerID;
        int CustomerAge;

        public Customer() : this("No name", "no address", "No ID", DateTime.Now) { }
        public Customer(string name, string address, string identification, DateTime dob)
        {
            CustomerName = name;
            CustomerAddress = address;
            CustomerID = identification;
            CustomerAge = DateTime.Now.Year - dob.Year;
        }

        
        public string getCustomerName  { get { return CustomerName; } }
        public string getCustomerAdd { get { return CustomerAddress; } }
        public string getCustomerID { get { return CustomerID; } }
        public int getCustomerAge { get { return CustomerAge; } }

        public string Show()
        {
            string returnstr =
                $"Customer Name    : {CustomerName}\n" +
                $"Customer Address : {CustomerAddress}\n" +
                $"Customer ID      : {CustomerID}\n" +
                $"Customer Age     : {CustomerAge}";
            return returnstr;
        }
    }
}