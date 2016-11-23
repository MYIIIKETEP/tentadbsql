namespace Tentadbsql.Northwind
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomerOrderDetails
    {
        [Key]
        [StringLength(40)]
        public string CompanyName { get; set; }

        public DateTime? OrderDate { get; set; }

        public int? OrderDetailCount { get; set; }
    }
}
