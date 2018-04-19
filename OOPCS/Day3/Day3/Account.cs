using System;
using CustomerRecord;

namespace Account
{
    public class BankAccount
    {
        string accountnumber;
        double accountvalue;
        string accountType;
        Customer accountCustomer;
        
        public BankAccount() : this("000-000-000", new Customer(), "Savings", 0) { }
        
        public BankAccount(string acc, Customer customerA, string accountType, double cash)
        {
            accountnumber = acc;
            accountCustomer = customerA;
            this.accountType = accountType;
            accountvalue = cash;
        }

        public string getAccountNum { get { return accountnumber; } }
        public string getAccountType { get { return accountType; } }
        public double getAccountValue { get { return accountvalue; } }

        public string getAccHolderName { get { return accountCustomer.getCustomerName; } }

        public double getInterestRate(string accountType, BankAccount bankaccount1)
        {
            if (accountType == "Savings") return 0.01;
            else if (accountType == "Current") return 0.0025;
            else if (accountType == "Overdraft" && bankaccount1.getAccountValue >= 0) return 0.0025;
            else return 0.06;
        }

        public double CalculateInterest(BankAccount bankaccount1)
        {
            double interest;
            if (bankaccount1.accountType == "Overdraft" && bankaccount1.accountvalue < 0)
            {
                return interest = -bankaccount1.accountvalue * 0.06;

            }
            else
            {
                return interest = bankaccount1.accountvalue * getInterestRate(bankaccount1.accountType, bankaccount1);
            }
        }
        public void CreditInterest(BankAccount bankaccount1)
        {
            if (bankaccount1.accountType == "Overdraft" && bankaccount1.accountvalue < 0)
            {
                bankaccount1.accountvalue -= CalculateInterest(bankaccount1);
            }
            else
            {
                bankaccount1.accountvalue += CalculateInterest(bankaccount1);
            }
        }
        public string Show()
        {
            string returnstr = $"\nAccount Name     : {accountCustomer.getCustomerName}" + $"\nAccount Number   : {accountnumber}\nCash Balance     : ${accountvalue:c}\nAccount Type     : {accountType}\n";
            return returnstr;
        }
        public void Deposit(double depoCash)
        {
            accountvalue += depoCash;
        }
        public bool Withdraw(double withCash)
        {
            if (accountvalue - withCash < 0 && accountType != "Overdraft")
            {
                return false;
            }
            else
            {
                accountvalue -= withCash;
                return true;
            }
        }

        public bool TransferTo(double transCash, BankAccount a, BankAccount b)
        {
            bool transStatus = a.Withdraw(transCash);
            if (transStatus == true)
            {
                b.Deposit(transCash);
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }   

}

