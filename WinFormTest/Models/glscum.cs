namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("glscum")]
    public partial class glscum
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string gcmatv { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string gcmcurr { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gcmdec { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string gcmdesc { get; set; }
    }
}
