using System;

namespace Day6
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
        public void Withdraw(double withCash)
        {
            char userinput = 'y';
            bool successflag = false;
            try
            {
                if (accountvalue < withCash)
                {
                    throw new Exception("Withdraw exceeds balance!");
                }
                accountvalue -= withCash;
                Console.WriteLine("Withdrawal Transaction Successful.");
                successflag = true;
            }
            catch (Exception)
            {
                Console.WriteLine("Withdraw exceeds balance!");
                return;
            }
            finally
            {
                if (accountvalue != 0 && successflag !=true)
                {
                    Console.Write("Withdraw a smaller amount? Press Y if yes. Any other input to exit.");
                    userinput = Console.ReadKey(true).KeyChar;
                    if (userinput == 'y' || userinput == 'Y') SmallerAmountWithdrawal();                    
                }
            }
        }

        public void SmallerAmountWithdrawal()
        {
            int userinputint;
            string userinput;
            do
            {
                do
                {
                    Console.WriteLine();
                    Console.Write("Please enter withdrawal amount >>> ");
                    userinput = Console.ReadLine();
                    Console.WriteLine();
                } while (int.TryParse(userinput, out userinputint) == false);
            } while (userinputint > 0 && userinputint > accountvalue);
            Withdraw(userinputint);
        }

        public void TransferTo(double transCash, BankAccount b)
        {
            bool transStatus = (accountvalue >= transCash);
            if (transStatus == true)
            {
                Withdraw(transCash);
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
            //Console.WriteLine(a.Show());
            //Console.WriteLine(b.Show());
            //Console.WriteLine(c.Show());
            a.Withdraw(5000);
        }
    }

}

