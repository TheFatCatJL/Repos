using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WNETCA_SA46G9
{
    public partial class index : System.Web.UI.Page
    {
        BModel _db = new BModel();
        myDB db2 = new myDB();
        protected void Page_Load(object sender, EventArgs e)
        { 
            if(User.IsInRole("Owner"))
            {
                Response.Redirect("~/Owner/BookCRUD.aspx");
            }
            ShowList();
            if (!IsPostBack)
            {

                ddl_cat.DataSource = BizLogic.ListCat();
                ddl_cat.DataTextField = "Name";
                ddl_cat.DataValueField = "CategoryID";
                SearchBook(txt_search.Text);
                ddl_cat.DataBind();
                LoadBook();
            }
            if(User.Identity.IsAuthenticated == false)
            {
                this.Page.Title = "Welcome to ISS Bookstore, Guest";
            }
            else
            {
                this.Page.Title = "Welcome to ISS Bookstore, " + User.Identity.Name;
            }

        }
        private void LoadBook()
        {

            var _book = (from b in db2.Books.AsEnumerable()
                         join c in db2.Categories on b.CategoryID equals c.CategoryID
                         select new
                         {
                             book_id = b.BookID,
                             Title = b.Title,
                             ISBN = b.ISBN,
                             Author = b.Author,
                             Price = b.Price,
                             Category = c.Name,
                             Stock = b.Stock,
                             BookDiscount = b.BookDiscount
                         }
                           ).ToList();

            if (_book.Count() > 0)
            {
                this.lvbook.DataSource = _book.ToList();
                this.lvbook.DataBind();
            }
        }

        protected void lvbook_PreRender(object sender, EventArgs e)
        {
            //LoadBook();
        }

        protected void ddl_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadByCategory();
        }
        private void LoadByCategory()
        {

            var _book = (from b in db2.Books.AsEnumerable()
                         join c in db2.Categories on b.CategoryID equals c.CategoryID
                         where ddl_cat.SelectedIndex == c.CategoryID
                         select new
                         {
                             book_id = b.BookID,
                             Title = b.Title,
                             ISBN = b.ISBN,
                             Author = b.Author,
                             Price = b.Price,
                             Category = c.Name,
                             Stock = b.Stock,
                             BookDiscount = b.BookDiscount
                         }
                           ).ToList();

            if (_book.Count() > 0)
            {
                this.lvbook.DataSource = _book.ToList();
                this.lvbook.DataBind();
            }
        }


        private void ShowList()
        {
            if (ddl_cat.SelectedItem.Text == "Please choose by category")
            {
                LoadBook();
            }
            else
            {
                LoadByCategory();
            }
        }

        public void SearchBook(string value)
        {
            value = txt_search.Text.ToString();

            var booklist = (from b in _db.Books.AsEnumerable()
                            join c in db2.Categories on b.CategoryID equals c.CategoryID
                            where b.Title.Contains(value) || b.Author.Contains(value) || b.ISBN.Contains(value)

                            select new
                            {
                                book_id = b.BookID,
                                Title = b.Title,
                                ISBN = b.ISBN,
                                Author = b.Author,
                                Price = b.Price,
                                Category = c.Name,
                                Stock = b.Stock,
                                BookDiscount = b.BookDiscount
                            }
                           ).ToList();

           
            this.lvbook.DataSource = booklist.ToList();
            this.lvbook.DataBind();
        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            SearchBook(txt_search.Text);
        }
        public IQueryable<Book> GetProduct([QueryString("book_id")] int? book_id)
        {
            var _db = new myDB();
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

        protected void BuyCheck(object sender, CommandEventArgs e)
        {
            int discountcode = 0;
            if (User.Identity.IsAuthenticated == false)
            {
                Response.Redirect("~/Login.aspx");
            }
            else
            {
                ShopCart mycart = new ShopCart();
                mycart.BookID = Convert.ToInt32(e.CommandArgument);
                mycart.SessionUser = User.Identity.Name;
                foreach(Book x in db2.Books)
                {
                    if(x.BookID == mycart.BookID)
                    {
                        mycart.ISBN = x.ISBN;
                        mycart.BookTitle = x.Title;
                        mycart.Price = Math.Round((double)x.Price,2);
                        mycart.Discount = x.BookDiscount;
                    }
                }
                if(User.IsInRole("Silver"))
                {
                    discountcode = 2;                    
                }
                else if (User.IsInRole("Gold"))
                {
                    discountcode = 3;
                }
                else if(User.IsInRole("Platinium"))
                {
                    discountcode = 5;
                }
                foreach (Discount d in db2.Discounts)
                {
                    if (d.DiscountID == discountcode)
                    {
                        mycart.Discount += d.DiscountAmt;
                    }
                }
                foreach (ShopCart y in db2.ShopCarts)
                {
                    if(y.BookID==mycart.BookID)
                    {
                        y.Quantity++;
                        y.Subtotal = y.Quantity * y.Price * (100-y.Discount)/100;
                        y.Subtotal = Math.Round(y.Subtotal, 2);
                        db2.SaveChanges();
                        return;
                    }
                }
                mycart.Quantity = 1;
                mycart.Subtotal = mycart.Price * mycart.Quantity * (100 - mycart.Discount)/100;
                mycart.Subtotal = Math.Round(mycart.Subtotal, 2);
                db2.ShopCarts.Add(mycart);
                db2.SaveChanges();
            }
        }

        protected void lvbook_DataBound(object sender, EventArgs e)
        {

        }

    }
}