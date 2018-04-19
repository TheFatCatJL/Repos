using System;
using System.Collections;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ISSBank
{
    
    class ObjInitial
    {
        public ArrayList CustomerInitial(int CustomerAcc, SqlConnection mysqlconnection)
        {
            Customer MyCustomer = new Customer();
            BankAccount myBankAccount1 = new BankAccount();
            BankAccount myBankAccount2 = new BankAccount();
            BankAccount myBankAccount3 = new BankAccount();
            ArrayList MyArray = new ArrayList();
            int recordcounter = 0;

            string CustomerAccStr = Convert.ToString(CustomerAcc);
            CustomerAccStr = "SELECT * FROM Table WHERE BankAccountID = " + CustomerAccStr + "\"";
            SqlCommand cmd = new SqlCommand(CustomerAccStr, mysqlconnection);
            if (mysqlconnection.State.ToString() != "Open") mysqlconnection.Open();
            SqlDataReader MyReader = cmd.ExecuteReader();
            if (mysqlconnection.State.ToString() != "Close") mysqlconnection.Close();
            while (MyReader.Read())
            {
                recordcounter++;
            }

            
        }
    }
}
