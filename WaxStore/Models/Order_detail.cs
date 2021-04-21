namespace WaxStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order_detail
    {
        [StringLength(10)]
        public string id { get; set; }

        [StringLength(10)]
        public string order_id { get; set; }

        [StringLength(10)]
        public string product_id { get; set; }

        [StringLength(50)]
        public string product_name { get; set; }

        public double? product_price { get; set; }

        [StringLength(50)]
        public string product_image { get; set; }

        public int? quantity { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
