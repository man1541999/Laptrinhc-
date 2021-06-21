namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? UnitCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}
