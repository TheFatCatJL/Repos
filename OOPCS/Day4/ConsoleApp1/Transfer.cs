using System;
using System.Collections.Generic;
using System.Text;

namespace ISSBank
{
    class Transfer
    {

        public Transfer() { }
        
        public void TransferScreen(BankAccount useracc1, BankAccount useracc2)
        {
            //useracc1 is transferor, useracc2 is tranferee.
            string userinput = "";
            int userinputint = 0;

            if (useracc1 == useracc2)
            {
                Console.WriteLine("Cannot transfer to the same account.");
                return;
            }
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("* Transfer                                  *");
                    Console.WriteLine("*********************************************");
                    Console.Write("Please choose the amount to transfer >>>");
                    userinput = Console.ReadLine();
                } while (int.TryParse(userinput, out userinputint) == false);
            } while (userinputint <= 0);
            useracc1.TransferTo(userinputint, useracc2);
            Console.WriteLine("Account Name   : {0}", useracc1.AccountCustomerGet.NameCustomer);
            Console.WriteLine("Account Number : {0}", useracc1.AccountNumberGet);
            Console.WriteLine("Account Type   : {0}", useracc1.AccountTypeGet);
            Console.WriteLine("Account Value  : {0:c}", useracc1.AccountValueGet);

        }

    }
}
