namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mplan")]
    public partial class mplan
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string Mono { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string month { get; set; }

        [StringLength(40)]
        public string Model { get; set; }

        [StringLength(40)]
        public string Spec { get; set; }

        public int? contratQty { get; set; }

        public int? FinishQty { get; set; }

        [StringLength(4)]
        public string Unit { get; set; }

        public DateTime? duedate { get; set; }

        public int? PlanQty { get; set; }

        public string Memo { get; set; }
    }
}
