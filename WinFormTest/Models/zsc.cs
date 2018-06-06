namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zsc")]
    public partial class zsc
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string zusr { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string zpwd { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string zdes { get; set; }
    }
}
