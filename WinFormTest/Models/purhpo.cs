namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("purhpo")]
    public partial class purhpo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string pdid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pdord { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pdvend { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pdline { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(15)]
        public string pdprod { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string pddes { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(2)]
        public string pdfac { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal pdqord { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal pdqrec { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal pdqiqc { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pdudte { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal pdpric { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(3)]
        public string pdcur { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pdso { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pdedte { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pddte { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pdtim { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(10)]
        public string pdusr { get; set; }
    }
}
