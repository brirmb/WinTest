namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("salhed")]
    public partial class salhed
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string edid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ednam { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string edadr1 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string edadr2 { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string edadr3 { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string edpon { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string edfax { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(20)]
        public string edacct { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string edbank { get; set; }
    }
}
