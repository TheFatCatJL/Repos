namespace WNETCA_SA46G9
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int BookID { get; set; }

        [Required]
        [StringLength(120)]
        public string Title { get; set; }

        public int CategoryID { get; set; }

        [Required]
        [StringLength(22)]
        public string ISBN { get; set; }

        [Required]
        [StringLength(64)]
        public string Author { get; set; }

        public int Stock { get; set; }

        public decimal Price { get; set; }

        public double BookDiscount { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
