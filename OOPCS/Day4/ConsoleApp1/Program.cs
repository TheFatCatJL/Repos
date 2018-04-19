using System;
using System.Collections;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;

namespace ISSBank
{

    
    class Program
    {
        

        static void Main(string[] args)
        {
            SecurityConsole UserLoginScr = new SecurityConsole();
            string constring2 = "Server =localhost;DATABASE = BankCustomers; Integrated Security=SSPI;";
            SqlConnection cbDatabaseConnection = new SqlConnection(constring2);
            UserLoginScr.ValidUserCheck(cbDatabaseConnection);
            //UserLoginScr.CustomerAcc;


            Customer A = new Customer("Allan", "1 Ocean Drive", "X1122", new DateTime(1990, 1, 1));
            BankAccount B = new SavingsAccount("001001001", 5000,0.01, A);
            BankAccount B2 = new CurrentAccount("001001002", 15000, 0.0025, A);
            BankAccount B3 = new OverdraftAccount("001001003", -50000, 0.0025, A);
            Customer A2 = new Customer("John", "2 Ocean Drive", "X1123", new DateTime(1990, 1, 1));
            BankAccount B4 = new SavingsAccount("001001004", 15000, 0.01, A2);
            BankAccount B5 = new CurrentAccount("001001005", 25000, 0.0025, A2);
            BankAccount B6 = new OverdraftAccount("001001006", -10000, 0.0025, A2);
            Customer A3 = new Customer("Mary", "3 Ocean Drive", "X1124", new DateTime(1990, 1, 1));
            BankAccount B7 = new SavingsAccount("001001007", 50000, 0.01, A3);
            BankAccount B8 = new CurrentAccount("001001008", 20000, 0.0025, A3);
            BankAccount B9 = new OverdraftAccount("001001009", 5000, 0.0025, A3);

            ArrayList AR = new ArrayList();
            BankBranch C = new BankBranch(AR);
            C.AddAccount(B);
            C.AddAccount(B2);
            C.AddAccount(B3);
            C.AddAccount(B4);
            C.AddAccount(B5);
            C.AddAccount(B6);
            C.AddAccount(B7);
            C.AddAccount(B8);
            C.AddAccount(B9);
            //Deposit D = new Deposit();
            //D.DepositScreen(B6);
            //C.PrintCustomers();
            //Withdrawal W = new Withdrawal();
            //W.WithdrawalInterface(B8);
            //C.PrintCustomers();
            //Transfer T = new Transfer();
            //T.TransferInterface(B7, B8);
            //C.PrintCustomers();
            //B9.CreditInterest();
            //B6.CreditInterest();
            //C.PrintCustomers();
            //UserMainMenu UMM = new UserMainMenu(AR);
            //UMM.UserMainMenuScreen(A);
            //UserSubMenu USM = new UserSubMenu(AR);
            //USM.UserSubMenuScreen(A, 0);


            //Customer CustA = new Customer();
            //Console.WriteLine(CustA.AddressCustomer);
            //string cus = CustA.NameCustomer;
            //Console.WriteLine(cus);
        }
    }
}
