namespace Tentadbsql.Northwind
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetailCount")]
    public partial class OrderDetailCount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        public DateTime? OrderDate { get; set; }

        public int? DetailCount { get; set; }
    }
}
