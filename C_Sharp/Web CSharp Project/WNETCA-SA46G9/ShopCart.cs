namespace WNETCA_SA46G9
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShopCart")]
    public partial class ShopCart
    {
        public int ShopCartID { get; set; }

        public int BookID { get; set; }

        [Required]
        [StringLength(50)]
        public string SessionUser { get; set; }

        public int Quantity { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public string BookTitle { get; set; }

        public double Price { get; set; }

        public double Discount { get; set; }

        public double Subtotal { get; set; }
    }
}
