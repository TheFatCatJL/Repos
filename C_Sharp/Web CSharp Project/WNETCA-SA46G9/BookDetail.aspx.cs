using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WNETCA_SA46G9
{
    public partial class BookDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Book> GetProduct([QueryString("book_id")] int? book_id)
        {
            var _db = new BModel();
            IQueryable<Book> query = _db.Books;

            if (book_id.HasValue && book_id > 0)
            {
                query = query.Where(p => p.BookID == book_id);
            }
            else
            {
                query = null;
            }
            return query;
        }

        protected void bookDetail_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {
            Response.Redirect("~/index.aspx");
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/index.aspx");
        }
    }
}