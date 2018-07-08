using System;
using System.Collections;
using System.Text;
using System.Data.SqlClient;

namespace ISSBank
{
    class SecurityConsole
    {
        ArrayList userlogin = new ArrayList();
        static int loginfail = 0;

        public int Loginfail { get { return loginfail; } }
        public int CustomerAcc { get; set; }


        public ArrayList SecurityMainManu()
        {
            userlogin.Clear();
            Console.Clear();
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Welcome to ISS Bank.");
            Console.WriteLine("*********************************************************");
            Console.Write("Please enter your username >>> ");
            userlogin.Add(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter your password >>> ");
            userlogin.Add(Console.ReadLine());
            Console.WriteLine();
            return userlogin;
        }

        public bool UserLoginStatus(ArrayList logindetails, SqlConnection mysql)
        {
            bool logincheck=false;
            int result=0;

            SqlCommand cmd = new SqlCommand("SELECT BankAccountID FROM UserNamePIN WHERE BankUserName=@cname AND BankPassword =@pass", mysql);
            cmd.Parameters.AddWithValue("@cname", logindetails[0]);
            cmd.Parameters.AddWithValue("@pass", logindetails[1]);
            if (mysql.State.ToString() != "Open") mysql.Open();
            if (cmd.ExecuteScalar() is null) result = -1;
            else result = (int)cmd.ExecuteScalar();

            if (result < 0)
            {
                loginfail++;
                logincheck = false;
                Console.WriteLine("Login Failed. Please check your username and password.");
                Console.WriteLine("You have {0} attempt(s) left.", 3 - loginfail);
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
            }
            else if (result > 0)
            {
                logincheck = true;
                Console.WriteLine("Login Success.");
                CustomerAcc = result;                
            }
            if (mysql.State.ToString() != "Closed") mysql.Close();
            return logincheck;
        }

        public void ValidUserCheck(SqlConnection mysql)
        {
            bool loginstatus = false;
            do
            {
                loginstatus = UserLoginStatus(SecurityMainManu(), mysql);
            } while (loginstatus == false && loginfail < 3);
            if (loginfail >= 3)
            {
                Environment.Exit(0);
            }
        }
    }
}
