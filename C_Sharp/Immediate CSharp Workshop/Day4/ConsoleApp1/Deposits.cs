using System;
using System.Collections.Generic;
using System.Text;

namespace ISSBank
{
    class Deposit
    {
        public Deposit() { }
        public void DepositScreen(BankAccount useracc)
        {
            string userinput = "";
            int userinputint = 0;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("* Deposit                                   *");
                    Console.WriteLine("*********************************************");
                    Console.Write("Please choose the amount to deposit >>>");
                    userinput = Console.ReadLine();
                } while (int.TryParse(userinput, out userinputint) == false);
            } while (userinputint <= 0);
            useracc.Deposit(userinputint);
            Console.WriteLine("Deposit Transaction of {0:c} is successful.", userinputint);
            Console.WriteLine("Account Name   : {0}", useracc.AccountCustomerGet.NameCustomer);
            Console.WriteLine("Account Number : {0}", useracc.AccountNumberGet);
            Console.WriteLine("Account Type   : {0}", useracc.AccountTypeGet);
            Console.WriteLine("Account Value  : {0:c}", useracc.AccountValueGet);

        }

    }
}
