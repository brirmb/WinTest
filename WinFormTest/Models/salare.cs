namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("salare")]
    public partial class salare
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string sarea { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string sades { get; set; }
    }
}
