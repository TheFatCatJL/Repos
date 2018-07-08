using System;
using System.Collections.Generic;
using System.Text;

namespace ISSBank
{
    class Withdrawal
    {
        public Withdrawal() { }

        public void WithdrawalScreen(BankAccount useracc)
        {
            string userinput = "";
            int userinputint = 0;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("* Withdrawal                                *");
                    Console.WriteLine("*********************************************");
                    Console.Write("Please choose the amount to withdraw >>>");
                    userinput = Console.ReadLine();
                } while (int.TryParse(userinput, out userinputint) == false);
            } while (userinputint <= 0);
            useracc.Withdraw(userinputint);
            Console.WriteLine("Account Name   : {0}", useracc.AccountCustomerGet.NameCustomer);
            Console.WriteLine("Account Number : {0}", useracc.AccountNumberGet);
            Console.WriteLine("Account Type   : {0}", useracc.AccountTypeGet);
            Console.WriteLine("Account Value  : {0:c}", useracc.AccountValueGet);
            
        }
    }
}
