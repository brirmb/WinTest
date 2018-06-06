namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zxo")]
    public partial class zxo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string zmod { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string zfun { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string zdes { get; set; }
    }
}
