namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ephead")]
    public partial class ephead
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string epid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string epno { get; set; }

        [StringLength(50)]
        public string epname { get; set; }

        [StringLength(50)]
        public string epsize { get; set; }

        [StringLength(10)]
        public string epoutno { get; set; }

        [StringLength(50)]
        public string eprule { get; set; }

        [StringLength(10)]
        public string eppurdate { get; set; }

        public int? epshelflife { get; set; }

        [StringLength(50)]
        public string epstore { get; set; }

        [StringLength(5)]
        public string epkeepercode { get; set; }

        public int? epvend { get; set; }
    }
}
