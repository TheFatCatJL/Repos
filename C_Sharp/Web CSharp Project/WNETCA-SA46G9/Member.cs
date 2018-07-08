namespace WNETCA_SA46G9
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int MemberID { get; set; }

        [Required]
        [StringLength(10)]
        public string MembershipCategory { get; set; }

        [Required]
        [StringLength(100)]
        public string MemberName { get; set; }

        [Required]
        [StringLength(50)]
        public string MemberContact { get; set; }

        [Required]
        [StringLength(50)]
        public string MemberEmail { get; set; }

        public string AvatarPhoto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
