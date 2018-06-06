namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("salest")]
    public partial class salest
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string stid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int stcust { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int stspt { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string stnam { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(6)]
        public string starea { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string stprov { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(10)]
        public string stcoty { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string stadr1 { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string stadr2 { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string stadr3 { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(20)]
        public string stpon1 { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(20)]
        public string stpon2 { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(20)]
        public string stpon3 { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(20)]
        public string stfax1 { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(20)]
        public string stfax2 { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(30)]
        public string stemai1 { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(30)]
        public string stemai2 { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(10)]
        public string stctat { get; set; }
    }
}
