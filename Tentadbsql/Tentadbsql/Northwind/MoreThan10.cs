namespace Tentadbsql.Northwind
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MoreThan10
    {
        [Key]
        [StringLength(40)]
        public string ProductName { get; set; }

        public int? Expr1 { get; set; }
    }
}
