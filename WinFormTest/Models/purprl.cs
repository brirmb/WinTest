namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("purprl")]
    public partial class purprl
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string prlid { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal prlno { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal prlseq { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(15)]
        public string prlprod { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal prlqty { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal prlpacst { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal prlpdte { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal prldue { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal prlrdte { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(2)]
        public string prlfac { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(100)]
        public string prlwhs { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(3)]
        public string prlcur { get; set; }

        public int? prlvnd { get; set; }

        [StringLength(100)]
        public string prlvndm { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(3)]
        public string prlplnc { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal prlpono { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(20)]
        public string prlsord { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(50)]
        public string prlmno { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(30)]
        public string prltno { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(50)]
        public string prlstation { get; set; }

        [Key]
        [Column(Order = 18)]
        public decimal prlplnh { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(60)]
        public string prlrule { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(1)]
        public string prlpmt { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(1)]
        public string prlapr { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(1)]
        public string prlnedm { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(20)]
        public string prlum { get; set; }

        [Key]
        [Column(Order = 24)]
        [StringLength(12)]
        public string prlcby { get; set; }

        [Key]
        [Column(Order = 25)]
        public decimal prlcdte { get; set; }

        [Key]
        [Column(Order = 26)]
        public decimal prlctm { get; set; }

        [Key]
        [Column(Order = 27)]
        [StringLength(12)]
        public string prlapby { get; set; }

        [Key]
        [Column(Order = 28)]
        public decimal prlapdte { get; set; }

        [Key]
        [Column(Order = 29)]
        public decimal prlaptm { get; set; }

        [Key]
        [Column(Order = 30)]
        [StringLength(100)]
        public string prlpgm { get; set; }

        [Key]
        [Column(Order = 31)]
        public decimal prlqcqty { get; set; }

        [Key]
        [Column(Order = 32)]
        public decimal prlrtq { get; set; }

        [Key]
        [Column(Order = 33)]
        public decimal prlsoseq { get; set; }

        [Key]
        [Column(Order = 34)]
        [StringLength(60)]
        public string prlmrk { get; set; }

        [Key]
        [Column(Order = 35)]
        [StringLength(12)]
        public string prloutno { get; set; }

        [Key]
        [Column(Order = 36)]
        [StringLength(12)]
        public string prlpicno { get; set; }
    }
}
