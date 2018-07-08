using System;
using System.Collections.Generic;
using System.Text;

namespace ISSBank
{
    class BankAccount
    {
        int AccountNumber;
        double AccountValue;
        string AccountType;
        double AccountInterest;
        Customer AccountCustomer;

        public BankAccount() : this(-1, 0,0, new Customer()){ }
        public BankAccount(int accountnumber, double accountvalue, double accountinterest, Customer accountcustomer)
        {
            AccountNumber = accountnumber;
            AccountValue = accountvalue;
            AccountCustomer = accountcustomer;
            AccountInterest = accountinterest;
            AccountType = "Savings";
        }

        public int AccountNumberGet { get { return AccountNumber; } }
        public double AccountValueGet { get { return AccountValue; } }
        public double AccountValueSet { set { AccountValue = value; } }
        public virtual string AccountTypeGet { get { return AccountType; } }

        public virtual double AccountInterestGet { get { return AccountInterest; } }
        public Customer AccountCustomerGet { get { return AccountCustomer; } }
        public void Deposit(double amount)
        {
            AccountValue += amount;
        }
        public void Withdraw(double amount)
        {
            if (AccountValue < amount && AccountType != "Overdraft")
            {
                Console.WriteLine("Insufficient funds. Please check your balance.");
            }
            else
            {
                AccountValue -= amount;
                Console.WriteLine("Withdrawal Transaction of {0:c} is successful.", amount);
            }
        }
        public void TransferTo(double amount, BankAccount acc2)
        {
            if (AccountValue < amount && AccountType != "Overdraft")
            {
                Console.WriteLine("Insufficient funds. Please check your balance.");
            }
            else
            {
                AccountValue -= amount;
                acc2.AccountValue += amount;
                Console.WriteLine("Transfer Transaction of {0:c} is successful.", amount);
            }
        }
        public double CalculateInterest()
        {
            return AccountValue * AccountInterestGet;
        }
        public void CreditInterest()
        {
            AccountValue += CalculateInterest();
        }
    }

    class SavingsAccount : BankAccount
    {
        double interest = 0.01;
        public SavingsAccount(int accountnumber, int accountvalue, double accountinterest, Customer accountcustomer) : base(accountnumber, accountvalue, accountinterest, accountcustomer) { }
        public override string AccountTypeGet { get { return "Savings"; } }
        public override double AccountInterestGet { get { return interest; } }
    }
    class CurrentAccount : BankAccount
    {
        double interest = 0.0025;
        public CurrentAccount(int accountnumber, int accountvalue, double accountinterest, Customer accountcustomer) : base(accountnumber, accountvalue, accountinterest, accountcustomer) { }
        public override string AccountTypeGet { get { return "Current"; } }
        public override double AccountInterestGet { get { return interest; } }
    }
    class OverdraftAccount : BankAccount
    {
        double interest = 0.0025;
        double interest2 = 0.06;
        public OverdraftAccount(int accountnumber, int accountvalue, double accountinterest, Customer accountcustomer) : base(accountnumber, accountvalue, accountinterest, accountcustomer) { }
        public override string AccountTypeGet { get { return "Overdraft"; } }
        
        public override double AccountInterestGet
        {
            get
            {
                if (AccountValueGet < 0) return interest2;
                else return interest;
            }
        }
    }

    
}
