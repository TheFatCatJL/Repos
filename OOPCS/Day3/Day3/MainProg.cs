using System;
using UserInterface;
using Account;
using CustomerRecord;

namespace MainProg
{
    public class Day3
    {
        static void Main(string[] args)
        {
            MainScreen newuser = new MainScreen();
            int menuselection;
            Customer x = new Customer("Robert To", "15, Ocean View", "XXX5C", new DateTime(1975, 5, 15));
            Customer y = new Customer("Tan Ah Kow", "20, Seaside Road", "XXX20", new DateTime(1989, 10, 11));
            Customer z = new Customer("Kim Lee Keng", "2, Rich View", "XXX9F", new DateTime(1993, 4, 25));
            Customer adminCU = new Customer("Bank Admin", "1 Bank Street", "SUPERADMIN", new DateTime(1990, 1, 1));
            Customer tempCus = new Customer();

            BankAccount adminBA = new BankAccount("000-000-000", adminCU , "Savings", 1000000);

            BankAccount a = new BankAccount("001-001-001", y, "Savings", 2000);
            BankAccount b = new BankAccount("001-001-002", z, "Current", 5000);
            BankAccount c = new BankAccount("001-001-003", x, "Overdraft", -15000);
            BankAccount tempBA = new BankAccount();
            BankAccount tempBATrans = new BankAccount();

            int userpass = newuser.PINScreen();
            if (userpass == 111111)
            {
                tempCus = y;
                tempBA = a;
            }
            else if (userpass == 222222)
            {
                tempCus = z;
                tempBA = b;
            }
            else if (userpass == 333333)
            {
                tempCus = x;
                tempBA = c;
            }
            else if (userpass == 999999)
            {
                tempCus = adminCU;
                tempBA = adminBA;
            }

            int superuserselection;
            char superuserretry;
            bool superflag = false;
            if (userpass == 999999)
            {
                do
                {
                    superuserselection = newuser.SuperUserMenu();
                    if (superuserselection == 1)
                    {
                        a.CreditInterest(a);
                        b.CreditInterest(b);
                        c.CreditInterest(c);
                    }
                    else
                    {
                        Console.WriteLine(a.Show());
                        Console.WriteLine(b.Show());
                        Console.WriteLine(c.Show());
                    }

                    Console.WriteLine("Continue? Press y, any other key to exit");
                    superuserretry = Console.ReadKey(true).KeyChar;
                    if (superuserretry == 'y' || superuserretry == 'Y')
                    {
                        superflag = true;
                    }
                    else
                    {
                        superflag = false;
                        Environment.Exit(0);
                    }

                } while (superflag == true);
            }
            bool exitflag = true;
            char userchoice = 'y';
            do
            {
                menuselection = newuser.UserMenuScreen(tempCus);

                string accounttempholder;
                switch (menuselection)
                {
                    case 1:
                        newuser.DepoScreen(tempBA);
                        break;
                    case 2:
                        newuser.WithdrawScreen(tempBA);
                        break;
                    case 3:
                        accounttempholder = newuser.TransferScreen1(tempBA);
                        if (accounttempholder == "001-001-001")
                        {
                            if (tempBA.getAccountNum == accounttempholder)
                            {
                                Console.WriteLine("Cannot transfer to own account!");
                                break;
                            }
                            else
                            {
                                tempBATrans = a;
                            }
                        }
                        else if (accounttempholder == "001-001-002")
                        {
                            if (tempBA.getAccountNum == accounttempholder)
                            {
                                Console.WriteLine("Cannot transfer to own account!");
                                break;
                            }
                            else
                            {
                                tempBATrans = b;
                            }
                        }
                        else if (accounttempholder == "001-001-003")
                        {
                            if (tempBA.getAccountNum == accounttempholder)
                            {
                                Console.WriteLine("Cannot transfer to own account!");
                                break;
                            }
                            else
                            {
                                tempBATrans = c;
                            }
                        }
                        newuser.TransferScreen2(tempBA, tempBATrans);
                        break;
                    case 4:
                        newuser.ShowBalanceScreen(tempBA, tempCus);
                        break;
                    case 5:
                        newuser.PotentialInterest(tempBA, tempCus);
                        break;
                    case 6:
                        newuser.ShowMyDetails(tempBA, tempCus);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\nDo you want to perform another transaction? Press Y, or any other key to exit");
                userchoice = Console.ReadKey(true).KeyChar;
                Console.WriteLine();
                if (userchoice == 'y' || userchoice == 'Y')
                {
                    exitflag = false;
                }
                else
                {
                    exitflag = true;
                }
            } while (exitflag == false);
        }
    }

}

