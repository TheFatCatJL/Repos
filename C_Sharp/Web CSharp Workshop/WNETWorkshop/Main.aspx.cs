using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WNETWorkshop
{
    public partial class Main : System.Web.UI.Page
    {
        Transaction CurrentTransaction = new Transaction();
        string SaltOption = "";
        string ChiliOption = "";
        string PepperOption = "";
        string SizeOption = "";
        WNETWSEntities context = new WNETWSEntities();


        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void DropDownListName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Customer X in context.Customers)
            {
                if (X.CustomerName == DropDownListName.Text)
                {
                    CurrentTransaction.CustomerID = X.CustomerID;
                }
            }
        }

        protected void RadioButtonListFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (FoodMenu X in context.FoodMenus)
            {
                if (X.FoodName == RadioButtonListFood.SelectedValue)
                {
                    CurrentTransaction.FoodID = X.FoodID;
                }
            }
        }

        protected void RadioButtonListSalt_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaltOption = RadioButtonListSalt.SelectedValue;
        }

        protected void RadioButtonListChili_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChiliOption = RadioButtonListChili.SelectedValue;
        }

        protected void CheckBoxListPepper_SelectedIndexChanged(object sender, EventArgs e)
        {
            PepperOption = CheckBoxListPepper.SelectedValue;
        }

        protected void RadioButtonListSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            SizeOption = RadioButtonListSize.SelectedValue;
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            CurrentTransaction.OrderOptions = SaltOption + "\n" + ChiliOption + "\n" + PepperOption;
            CurrentTransaction.OrderSize = SizeOption;
            CurrentTransaction.OrderDate = DateTime.Now;
            context.Transactions.AddObject(CurrentTransaction);
            context.SaveChanges();
        }

        protected void DropDownListName_Load(object sender, EventArgs e)
        {
            foreach (Customer X in context.Customers)
            {
                if (X.CustomerName == DropDownListName.Text)
                {
                    CurrentTransaction.CustomerID = X.CustomerID;
                }
            }
        }
    }
}