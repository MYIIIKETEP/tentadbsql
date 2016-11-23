namespace Tentadbsql.Northwind
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CategoryProducts
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string CategoryName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string ProductName { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }
    }
}
