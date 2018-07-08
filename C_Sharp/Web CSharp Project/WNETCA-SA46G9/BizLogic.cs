using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WNETCA_SA46G9
{
    public class BizLogic
    {
        public static List<Category> ListCat()
        {
            using (myDB entities = new myDB())
            {
                return entities.Categories.ToList<Category>();
            }
        }

    }
}