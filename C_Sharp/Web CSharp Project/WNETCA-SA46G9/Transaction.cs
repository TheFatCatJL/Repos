namespace WNETCA_SA46G9
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transaction
    {
        public int TransactionID { get; set; }

        public int MemberID { get; set; }

        public int BookID { get; set; }

        public int DiscountID { get; set; }

        public bool ApplyMembership { get; set; }

        public int Quantity { get; set; }

        [Required]
        [StringLength(50)]
        public string PaymentMode { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime TransactionDateTime { get; set; }

        public virtual Book Book { get; set; }

        public virtual Discount Discount { get; set; }

        public virtual Member Member { get; set; }
    }
}
