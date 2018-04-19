using System;

namespace Day3
{
    public class Customer
    {
        string CustomerName;
        string CustomerAddress;
        string CustomerID;
        string AccountType;
        int CustomerAge;

        public Customer() : this("No name", "no address", "No ID", "Savings", DateTime.Now) { }
        public Customer(string name, string address, string identification, string accounttype, DateTime dob)
        {
            CustomerName = name;
            CustomerAddress = address;
            CustomerID = identification;
            AccountType = accounttype;
            CustomerAge = DateTime.Now.Year - dob.Year;
        }

        public string getCustomerName
        {
            get { return CustomerName; }
        }

        public string getAccountType { get { return AccountType; } }

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
    public class BankAccount
    {
        string accountname;
        string accountnumber;
        double accountvalue;
        Customer accountCustomer;

        public BankAccount() : this("000-000-000", "No Name", 0) { }

        public BankAccount(string acc, string name, double cash)
        {
            accountnumber = acc;
            accountname = name;
            accountvalue = cash;
        }

        public BankAccount(string acc, Customer customerA, double cash)
        {
            accountnumber = acc;
            accountCustomer = customerA;
            accountvalue = cash;
        }


        public string Show()
        {
            string returnstr = $"\nAccount Name     : {accountCustomer.getCustomerName}" + $"\nAccount Number   : {accountnumber}\nCash Balance     : ${accountvalue}\nAccount Type     : {accountCustomer.getAccountType}\n";
            return returnstr;
        }
        public void Deposit(double depoCash)
        {
            accountvalue += depoCash;
            Console.WriteLine("Deposit Transaction Successful.");
        }
        public bool Withdraw(double withCash)
        {
            if (accountvalue - withCash < 0)
            {
                Console.WriteLine("Withdraw amount exceed bank balance. Transaction failed.");
                return false;
            }
            else
            {
                accountvalue -= withCash;
                Console.WriteLine("Withdrawal Transaction Successful.");
                return true;
            }
        }

        public void TransferTo(double transCash, BankAccount b)
        {
            bool transStatus = Withdraw(transCash);
            if (transStatus == true)
            {
                b.Deposit(transCash);
                Console.WriteLine("Transfer Transaction Successful.");
            }
            else
            {
                Console.WriteLine("Transfer Transaction failed.");
            }
        }
    }

    public class BankTest
    {
        static void Main(string[] args)
        {
            Customer y = new Customer("Tan Ah Kow", "20, Seaside Road", "XXX20", "Savings", new DateTime(1989, 10, 11));
            Customer z = new Customer("Kim Lee Keng", "2, Rich View", "XXX9F", "Current", new DateTime(1993, 4, 25));
            Customer x = new Customer("Robert To", "15, Ocean View", "XXX5C", "Overdraft", new DateTime(1975, 5, 15));
            BankAccount a = new BankAccount("001-001-001", y, 2000);
            BankAccount b = new BankAccount("001-001-002", z, 5000);
            BankAccount c = new BankAccount("001-001-003", x, 15000);
            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
            Console.WriteLine(c.Show());
        }
    }

}

