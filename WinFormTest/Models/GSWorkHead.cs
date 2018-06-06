namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GSWorkHead")]
    public partial class GSWorkHead
    {
        [StringLength(1)]
        public string type { get; set; }

        [Key]
        [StringLength(10)]
        public string workhno { get; set; }

        [StringLength(10)]
        public string empid { get; set; }

        [StringLength(10)]
        public string empname { get; set; }

        public decimal? worktime { get; set; }

        [StringLength(10)]
        public string declaredate { get; set; }

        [StringLength(10)]
        public string head { get; set; }
    }
}
