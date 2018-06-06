namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tdmbom")]
    public partial class tdmbom
    {
        public int? tdmseq { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string bomnam { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string bompno { get; set; }

        [StringLength(50)]
        public string bomsiz { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal bomqua { get; set; }

        [StringLength(50)]
        public string bomhrc { get; set; }

        [StringLength(40)]
        public string bomitm { get; set; }

        [StringLength(200)]
        public string bommem { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal bomver { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(40)]
        public string bomdra { get; set; }

        [StringLength(50)]
        public string bommat { get; set; }

        [StringLength(50)]
        public string bomsup { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string bomflg { get; set; }

        [StringLength(40)]
        public string bompro { get; set; }

        public DateTime? bompdt { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(40)]
        public string bommno { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(40)]
        public string bomwno { get; set; }

        [StringLength(1)]
        public string bomapy { get; set; }

        [StringLength(4)]
        public string bomrmk { get; set; }

        public decimal? bomser { get; set; }

        public decimal? bompre { get; set; }

        public DateTime? bomdte { get; set; }

        [StringLength(40)]
        public string bompur { get; set; }

        [StringLength(4)]
        public string bomgno { get; set; }

        [StringLength(40)]
        public string bomSpc { get; set; }

        public decimal? bomWeight { get; set; }

        public decimal? bomSumWeight { get; set; }

        [StringLength(40)]
        public string bomType { get; set; }

        [StringLength(40)]
        public string bomUnit { get; set; }
    }
}
