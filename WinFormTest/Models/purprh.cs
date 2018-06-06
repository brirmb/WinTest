namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("purprh")]
    public partial class purprh
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string prhid { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal prhno { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string prhsord { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string prhmno { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string prhtyp { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(2)]
        public string prhstat { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(3)]
        public string prhcur { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(12)]
        public string prhcby { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal prhcdte { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal prhctm { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(12)]
        public string prhapby { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal prhapdte { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal prhaptm { get; set; }

        [StringLength(20)]
        public string prhpgm { get; set; }
    }
}
