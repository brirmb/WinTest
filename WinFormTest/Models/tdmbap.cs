namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tdmbap")]
    public partial class tdmbap
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string baptyp { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime bapdat { get; set; }

        [StringLength(200)]
        public string bapres { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string bapmno { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal bapver { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(40)]
        public string bapwno { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(40)]
        public string bappro { get; set; }
    }
}
