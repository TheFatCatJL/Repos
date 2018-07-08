using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WNETCA_SA46G9.Owner
{
    public partial class BookCRUD : System.Web.UI.Page
    {
        myDB bookcontrol = new myDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            //List<Book> booklist = bookcontrol.Books.ToList<Book>();
            //GridView1.DataSource = booklist;
            //GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs("D:\\Repos\\WNETCA-SA46G9\\WNETCA-SA46G9\\images\\" + FileUpload1.FileName);
            }
        }
    }
}