using System;
using System.Collections;
using System.Text;

namespace ISSBank
{
    class BankBranch
    {
        string BranchName;
        string BranchManager;
        ArrayList AccountList;
        
        public BankBranch(ArrayList accountlist, string branchname = "Bukit Timah", string branchmanager = "Robert Tao")
        { 
            AccountList = accountlist;
            BranchName = branchname;
            BranchManager = branchmanager;
        }
        public void AddAccount(BankAccount bankacc)
        {
            AccountList.Add(bankacc);
        }

        //total deposits

        public double TotalDeposits()
        {
            double total= 0;

            foreach (BankAccount accounts in AccountList)
            {
                Console.WriteLine("Account {0} : {1:c}",accounts.AccountNumberGet,accounts.AccountValueGet);
                total += accounts.AccountValueGet;
            }
            return total;
        }
        public void PrintCustomers()
        {
            int count = 1;
            foreach (BankAccount accounts in AccountList)
            {
                Console.WriteLine("Account {0}", count);
                Console.WriteLine("Customer Name  : {0}",accounts.AccountCustomerGet.NameCustomer);
                Console.WriteLine("Account Number : {0}", accounts.AccountNumberGet);
                Console.WriteLine("Account Type   : {0}", accounts.AccountTypeGet);
                Console.WriteLine("Account Value  : {0:c}", accounts.AccountValueGet);
                if (accounts.AccountValueGet >= 0) Console.WriteLine("Interest Rate  : {0}", accounts.AccountInterestGet);
                else Console.WriteLine("Charging Rate  : {0}", accounts.AccountInterestGet);
                Console.WriteLine();
                count++;
            }
        }
        
        public double TotalInterestPaid()
        {
            double total2=0;
            foreach (BankAccount accounts in AccountList)
            {
                if (accounts.AccountValueGet >= 0)
                {
                    Console.WriteLine("Account {0} : {1:c}", accounts.AccountNumberGet, accounts.AccountInterestGet * accounts.AccountValueGet);
                    total2 += accounts.AccountInterestGet * accounts.AccountValueGet;
                }
            }
            return total2;
        }

        public double TotalInterestEarned()
        {
            double total3 = 0;
            foreach (BankAccount accounts in AccountList)
            {
                if (accounts.AccountValueGet < 0)
                {
                    Console.WriteLine("Account {0} : {1:c}", accounts.AccountNumberGet, accounts.AccountInterestGet * -accounts.AccountValueGet);
                    total3 += accounts.AccountInterestGet * -accounts.AccountValueGet;
                }
            }
            return total3;
        }
    }
}
