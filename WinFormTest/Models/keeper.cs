namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("keeper")]
    public partial class keeper
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string kpid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string kpcode { get; set; }

        [StringLength(10)]
        public string kpname { get; set; }

        [StringLength(20)]
        public string kpdept { get; set; }

        [StringLength(15)]
        public string kpphone { get; set; }

        [StringLength(30)]
        public string kpemail { get; set; }
    }
}
