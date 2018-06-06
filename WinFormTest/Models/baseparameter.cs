namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("baseparameter")]
    public partial class baseparameter
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string type { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string code { get; set; }

        [StringLength(50)]
        public string description { get; set; }
    }
}
