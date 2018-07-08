using System;
using System.Collections;
using System.Text;

namespace ISSBank
{
    class UserMainMenu
    {
        public ArrayList AccountList { get; set; }
        public UserMainMenu(ArrayList accountlist) { AccountList = accountlist; }

        //public void Menutrigger(ArrayList AccountList)
        //{
        //    UserMainMenuScreen();
        //}
        public int UserMainMenuScreen(Customer customerA)
        {
            string userinput = "";
            int userinputint = 1;
            int count = 0;
            int[] arrayIndex = new int[10];
            do
            {
                do
                {
                    count = 0;
                    Console.Clear();
                    Console.WriteLine("********************************************************************************");
                    Console.WriteLine("Welcome to ISS Bank. How can we serve you today, {0}", customerA.NameCustomer);
                    Console.WriteLine("********************************************************************************");
                    Console.WriteLine("Please choose your account for your transaction.");
                    Console.WriteLine("********************************************************************************");


                    foreach (BankAccount accounts in AccountList)
                    {
                        if (accounts.AccountCustomerGet.NameCustomer == customerA.NameCustomer)
                        {
                            arrayIndex[count] = AccountList.IndexOf(accounts);
                            count++;
                            Console.WriteLine("Press {0} for {1} account \t: {2} \t: {3:c}", count, accounts.AccountTypeGet, accounts.AccountNumberGet, accounts.AccountValueGet);
                        }
                    }
                    Console.WriteLine("********************************************************************************");
                    userinput = Console.ReadKey(true).KeyChar.ToString();
                } while (int.TryParse(userinput, out userinputint) == false);
            } while (userinputint <= 0 || userinputint > count);
            return arrayIndex[userinputint-1];
        }
    }

    class UserSubMenu : UserMainMenu
    {
        
        public UserSubMenu(ArrayList accountlist) : base(accountlist) { }

        public int UserSubMenuScreen(Customer CustomerA, int ArrayIndex)
        {
            BankAccount BA = (BankAccount)AccountList[ArrayIndex];
            char Userinput = '5';

            do
            {
                Console.Clear();
                Console.WriteLine("********************************************************************************");
                Console.WriteLine("Welcome to ISS Bank. How can we serve you today, {0}", CustomerA.NameCustomer);
                Console.WriteLine("********************************************************************************");
                Console.WriteLine("Please choose your transaction for your {0} account.", BA.AccountTypeGet);
                Console.WriteLine("********************************************************************************");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdrawal");
                Console.WriteLine("3. Transfer");
                Console.WriteLine("4. Account Details");
                Console.WriteLine("5. Go back to choose another account.");
                Console.Write("\nPress 1 to 5 >>> ");
                Userinput = Console.ReadKey(true).KeyChar;
                Console.WriteLine();
            } while ((int)Userinput < 1 && (int)Userinput > 5);
            return Userinput;            
        }
    }
}
