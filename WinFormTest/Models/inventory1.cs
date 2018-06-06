namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class inventory1
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string WHCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string Pono { get; set; }

        [StringLength(40)]
        public string Mono { get; set; }

        [StringLength(40)]
        public string ProcCode { get; set; }

        [StringLength(40)]
        public string PoName { get; set; }

        public decimal? Qty { get; set; }

        [StringLength(40)]
        public string Unit { get; set; }
    }
}
