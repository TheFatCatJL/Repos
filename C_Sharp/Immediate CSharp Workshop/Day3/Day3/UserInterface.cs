using System;
using Account;
using CustomerRecord;

namespace UserInterface
{
    public class MainScreen
    {
        public int PINScreen()
        {
            string userinput;
            int a;
            bool breakflag = false;
            int[] passwords = new int[] { 111111, 222222, 333333, 999999 };
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* Welcome to the bank of ISS                                          *");
            Console.WriteLine("***********************************************************************");
            do
            {
                do
                {
                    Console.Write("Please enter your six digit PIN >>> ");
                    userinput = Console.ReadLine();
                    Console.WriteLine();
                } while (int.TryParse(userinput, out a) == false);
                foreach (int password in passwords)
                {
                    if (a == password)
                    {
                        breakflag = true;
                    }
                }
            } while (breakflag == false);
            return a;
        }

        public int SuperUserMenu()
        {
            int userinput;
            do
            {
                Console.WriteLine("Welcome, Admin. Please choose transaction to perform.");
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("* Press only 1 - 2                                                    *");
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("* 1. Calculate and deposit interest                                   *");
                Console.WriteLine("* 2. Show all accounts                                                *");
                Console.WriteLine("***********************************************************************");
                userinput = (int)Console.ReadKey(true).Key - 48;
            } while (userinput < 1 || userinput > 2);
            return userinput;
        }
        public int UserMenuScreen(Customer customerAcc)
        {
            int userinput;
            do
            {
                Console.WriteLine("Welcome, {0}. Please make your banking selection.", customerAcc.getCustomerName);
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("* Press only 1 - 6                                                    *");
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("* 1. Deposit                                                          *");
                Console.WriteLine("* 2. Withdrawal                                                       *");
                Console.WriteLine("* 3. Transfer                                                         *");
                Console.WriteLine("* 4. Show balance                                                     *");
                Console.WriteLine("* 5. Show my potential interest for this year                         *");
                Console.WriteLine("* 6. Show my records                                                  *");
                Console.WriteLine("***********************************************************************");
                userinput = (int)Console.ReadKey(true).Key - 48;
            } while (userinput < 1 || userinput > 6);
            return userinput;
        }
        public void DepoScreen(BankAccount customerAcc)
        {
            string userinput;
            int b;

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* Deposits                                                            *");
            Console.WriteLine("***********************************************************************");
            do
            {
                do
                {
                    Console.Write("Please enter the deposit amount >>> ");
                    userinput = Console.ReadLine();
                    Console.WriteLine();
                } while (int.TryParse(userinput, out b) == false);
            } while (b < 0);
            customerAcc.Deposit(b);
            Console.WriteLine("Deposit Transaction of ${0} Successful",b);
            Console.WriteLine(customerAcc.Show());
        }

        public void WithdrawScreen(BankAccount customerAcc)
        {
            string userinput;
            int c;
            bool success;

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* Withdrawals                                                         *");
            Console.WriteLine("***********************************************************************");
            do
            {
                do
                {
                    Console.Write("Please enter the withdrawal amount >>> ");
                    userinput = Console.ReadLine();
                    Console.WriteLine();
                } while (int.TryParse(userinput, out c) == false);
            } while (c < 0);
            success = customerAcc.Withdraw(c);
            if (success == true)
            {
                Console.WriteLine("Withdrawal Transaction of {0} Successful",c);
                Console.WriteLine(customerAcc.Show());
            }
            else
            {
                Console.WriteLine("Withdrawal Transaction Failed. Please check your balance.");
                Console.WriteLine(customerAcc.Show());
            }
        }

        public string TransferScreen1(BankAccount userAcc)
        {
            string userinput2;
            bool outflag = false;
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* Transfers                                                           *");
            Console.WriteLine("***********************************************************************");
            
            do
            {
                Console.Write("Please enter the acc number to transfer to >>> ");
                userinput2 = Console.ReadLine();
                Console.WriteLine();
                if (userinput2 == "001-001-001" || userinput2 == "001-001-002" || userinput2 == "001-001-003")
                {
                    outflag = true;
                }
            } while (outflag==false);

            return userinput2;   
        }
        public void TransferScreen2(BankAccount a, BankAccount b)
        {
            string userinput;
            int d;
            do
            {
                do
                {
                    Console.Write("Please enter the amount to transfer >>> ");
                    userinput = Console.ReadLine();
                    Console.WriteLine();
                } while (int.TryParse(userinput, out d) == false);
            } while (d < 0);

            bool transferstatus = a.TransferTo(d, a, b);
            if (transferstatus == true)
            {
                Console.WriteLine("Transfer Transaction Successful");
                Console.WriteLine(a.Show());
                //Console.WriteLine(b.Show());
            }
            else
            {
                Console.WriteLine("Transfer Transaction Failed. Please check your balance.");
                Console.WriteLine(a.Show());
            }
        }

        public void ShowBalanceScreen(BankAccount bankA, Customer cusA)
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("Welcome, {0}", cusA.getCustomerName);
            Console.WriteLine("****************************************************");
            Console.WriteLine("Account Number : {0}",bankA.getAccountNum);
            Console.WriteLine("Account type   : {0}", bankA.getAccountType);
            Console.WriteLine("Account Value  : ${0}", bankA.getAccountValue);
            Console.WriteLine("****************************************************");
        }

        public void PotentialInterest(BankAccount bankA, Customer cusA)
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("Welcome, {0}", cusA.getCustomerName);
            Console.WriteLine("****************************************************");
            Console.WriteLine("Account Number : {0}", bankA.getAccountNum);
            Console.WriteLine("Account type   : {0}", bankA.getAccountType);
            Console.WriteLine("Account Value  : ${0}", bankA.getAccountValue);
            Console.WriteLine("****************************************************");
            double tempinterestrate = bankA.getInterestRate(bankA.getAccountType,bankA);
            double tempinterest = bankA.CalculateInterest(bankA);
            if (bankA.getAccountValue >= 0)
            {
                Console.WriteLine($"Based on the interest rates of {tempinterestrate:P2}, you will earn {tempinterest:c} based on your deposit of {bankA.getAccountValue:c}.");
            }
            {
                Console.WriteLine($"Based on the interest rates of {tempinterestrate:P2}, you will incur interest charges of {tempinterest:c} based on your balance of {bankA.getAccountValue:c}.");
            }
        }

        public void ShowMyDetails(BankAccount bankA, Customer cusA)
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("Welcome, {0}", cusA.getCustomerName);
            Console.WriteLine("****************************************************");
            Console.WriteLine("Account Details");
            Console.WriteLine("Account Number : {0}", bankA.getAccountNum);
            Console.WriteLine("Account type   : {0}", bankA.getAccountType);
            Console.WriteLine("Account Value  : ${0}", bankA.getAccountValue);
            Console.WriteLine("Personal Details");
            Console.WriteLine("Account Name   : {0}", cusA.getCustomerName);
            Console.WriteLine("Address        : {0}", cusA.getCustomerAdd);
            Console.WriteLine("ID             : {0}", cusA.getCustomerID);
            Console.WriteLine("Age            : {0}", cusA.getCustomerAge);
            Console.WriteLine("****************************************************");
        }
    }
}

