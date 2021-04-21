namespace WaxStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Order_detail = new HashSet<Order_detail>();
        }

        [StringLength(10)]
        public string id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public string description { get; set; }

        public double? price { get; set; }

        public double? rate { get; set; }

        public int? quantity { get; set; }

        [StringLength(50)]
        public string image { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        [StringLength(10)]
        public string category_id { get; set; }

        [StringLength(10)]
        public string company_id { get; set; }

        public virtual Category Category { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_detail> Order_detail { get; set; }
    }
}
