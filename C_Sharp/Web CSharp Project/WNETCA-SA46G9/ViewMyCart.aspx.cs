using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WNETCA_SA46G9
{
    public partial class ViewMyCart : System.Web.UI.Page
    {
        double discounts = 0;
        double grandtotal = 0;
        myDB db2 = new myDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }
        private void BindGrid()
        {
            string UserN = User.Identity.Name;
            string role="normal";
            List<ShopCart> myshopcart = new List<ShopCart>();
            foreach (ShopCart sc in db2.ShopCarts)
            {
                if (sc.SessionUser == UserN)
                { myshopcart.Add(sc); }
            }            
            grandtotal = 0;
            discounts = 0;
            foreach (ShopCart x in myshopcart)
            {
                grandtotal += x.Subtotal;
                double temp = Math.Round((x.Discount / 100 * x.Quantity * x.Price), 2);
                discounts += temp;
            }
            if (myshopcart.Count() > 0)
            {
                GridView1.DataSource = myshopcart;
                GridView1.DataBind();
            }
            try
            {
                role = System.Web.Security.Roles.GetRolesForUser().Single();
                role = role.ToString().Trim();
            }
            catch
            {
                role = "normal";
            }
            double discountamt = 0;
            foreach (Discount d in db2.Discounts)
            {
                if(d.MembershipCategory.Trim() == role)
                {
                    discountamt = d.DiscountAmt;
                }
            }
            if (grandtotal != 0)
            {
                Label3.Text = String.Format("Dear {0}, being a {1} member entitles you to additional {2}% discount",UserN,role,discountamt);
                Label2.Text = "Total Savings : " + discounts.ToString();
                Label1.Text = "Grand Total : " + grandtotal.ToString();
            }
            else
            {
                Label1.Text = "";
                Label2.Text = "";
                Label3.Text = "";
            }
        }

        public void DeleteOrder(int index)
        {

            string UserN = User.Identity.Name;
            List<ShopCart> myshopcart = new List<ShopCart>();
            foreach (ShopCart sc in db2.ShopCarts)
            {
                if (sc.SessionUser == UserN)
                { myshopcart.Add(sc); }
            }
            ShopCart cartitem = myshopcart[index];
            db2.ShopCarts.Remove(cartitem);
            db2.SaveChanges();                
            
            myshopcart = db2.ShopCarts.ToList<ShopCart>();
            grandtotal = 0;
            foreach (ShopCart x in myshopcart)
            {
                grandtotal += x.Subtotal;
                double temp = Math.Round((x.Discount / 100 * x.Quantity * x.Price), 2);
                discounts += temp;
            }
            Label2.Text = "Total Savings : $" + discounts.ToString();
            Label1.Text = "Grand Total : $" + grandtotal.ToString();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DeleteCart")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                DeleteOrder(index);
            }
            BindGrid();
            updatepanel1.Update();
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {

        }
        //public static void UpdateOrder(int transactionID, int quantity)
        //{
        //    using (BModel entities = new BModel())
        //    {
        //        Transaction transaction = entities.Transactions.Where(p => p.TransactionID == transactionID).First<Transaction>();

        //        transaction.Quantity = quantity;
        //        entities.SaveChanges();
        //    }
        //}
        //protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        //{
        //    GridViewRow row = GridView1.Rows[e.RowIndex];
        //    int quantity = Convert.ToInt16((row.FindControl("txtQuantity") as TextBox).Text);
        //    int transactionID = Convert.ToInt16((row.FindControl("lbltransactionID") as Label).Text);
        //    UpdateOrder(transactionID, quantity);
        //    GridView1.EditIndex = -1;
        //    BindGrid();
        //}


    }
}