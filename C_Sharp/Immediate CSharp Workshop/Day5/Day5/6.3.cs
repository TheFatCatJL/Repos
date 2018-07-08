using System;

namespace Testing
{
    
    class Customer : IComparable
    {
        private string name;
        private string address;
        private double balance;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
        }
        public Customer(string n, string a, double b)
        {
            name = n;
            address = a;
            balance = b;
        }
              

        public int CompareTo(object obj)
        {
            Customer cus = (Customer)obj;
            if (Balance < cus.Balance)
            {
                return Balance.CompareTo(cus.Balance);
            }
            return -1;
        }

        // overloading operators
        public static bool operator <(Customer a, Customer b)
        {
            return (a.CompareTo(b) < 0);
        }

        public static bool operator >(Customer a, Customer b)
        {
            return (a.CompareTo(b) > 0);
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Customer c = new Customer("Tan Ah Kow", "4 Short Street", 2000);
            Customer d = new Customer("Tan Ah Lian", "81 Berry Road", 1500);
            int n = 65;
            int m = 231;
            Console.WriteLine(n < m);
            Console.WriteLine(c < d);
        }
    }
}