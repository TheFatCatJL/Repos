using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WNETCA_SA46G9.Owner
{
   
    public partial class DiscountCRUD : System.Web.UI.Page
    {
        myDB DiscountTable = new myDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            //List<Discount> discountable = DiscountTable.Discounts.ToList<Discount>();
            //GridView1.DataSource = discountable;
            //GridView1.DataBind();
        }
    }
}