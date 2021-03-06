namespace Tentadbsql.Northwind
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupplierProductView")]
    public partial class SupplierProductView
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string ProductName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string CategoryName { get; set; }

        public short? UnitsInStock { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryID { get; set; }
    }
}
