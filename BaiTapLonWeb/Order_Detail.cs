namespace BaiTapLonWeb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order_Detail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? order_id { get; set; }

        public int? product_id { get; set; }

        [StringLength(50)]
        public string product_name { get; set; }

        public double? product_price { get; set; }

        public string product_image { get; set; }

        public int? quantity { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
