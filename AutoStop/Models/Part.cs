namespace AutoStop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Part")]
    public partial class Part
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(250)]
        public string Number { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        public int? Qty { get; set; }

        public decimal? Price { get; set; }

        public int? Qty1 { get; set; }

        public int? Qty2 { get; set; }

        public string Brand { get; set; }
    }
}
