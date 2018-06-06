namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zxa")]
    public partial class zxa
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string zfun { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string zdes { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string zusr { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string zflg { get; set; }
    }
}
