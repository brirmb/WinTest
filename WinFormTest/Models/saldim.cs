namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saldim")]
    public partial class saldim
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string diid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string diprod { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string dipby { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal dinum { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(3)]
        public string didum { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal dilgth { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal diwdth { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal dihigh { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(3)]
        public string diwum { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal diunw { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal diugw { get; set; }
    }
}
