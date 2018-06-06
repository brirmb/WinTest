namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("securitycheck")]
    public partial class securitycheck
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string chkepno { get; set; }

        [StringLength(10)]
        public string chkuser { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string chkdate { get; set; }

        [StringLength(50)]
        public string chkremark { get; set; }
    }
}
