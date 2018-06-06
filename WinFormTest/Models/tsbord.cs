namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tsbord")]
    public partial class tsbord
    {
        [StringLength(2)]
        public string sid { get; set; }

        [StringLength(15)]
        public string ordno { get; set; }

        public decimal? ordso { get; set; }

        [StringLength(15)]
        public string ordms { get; set; }

        [StringLength(50)]
        public string ordcust { get; set; }

        [StringLength(25)]
        public string ordcont { get; set; }

        [StringLength(15)]
        public string ordwtyp { get; set; }

        [StringLength(10)]
        public string ordcout { get; set; }

        [StringLength(20)]
        public string ordmodel { get; set; }

        [StringLength(30)]
        public string ordptyp1 { get; set; }

        [StringLength(30)]
        public string ordptyp2 { get; set; }

        [StringLength(15)]
        public string ordts { get; set; }

        [StringLength(15)]
        public string ordt1 { get; set; }

        [StringLength(15)]
        public string ordtn { get; set; }

        [StringLength(20)]
        public string ordvno { get; set; }

        public decimal? ordxnum { get; set; }

        [StringLength(50)]
        public string ordpno { get; set; }

        [StringLength(30)]
        public string ordmat { get; set; }

        [StringLength(20)]
        public string ordmjcz { get; set; }

        [StringLength(20)]
        public string ordmjgg { get; set; }

        [StringLength(20)]
        public string ordgmcz { get; set; }

        [StringLength(20)]
        public string ordmmcz { get; set; }

        [StringLength(20)]
        public string ordmjjg { get; set; }

        [StringLength(20)]
        public string ordjdlx { get; set; }

        [StringLength(10)]
        public string ordgzgs { get; set; }

        [StringLength(20)]
        public string ordjdcp { get; set; }

        [StringLength(10)]
        public string ordhkgs { get; set; }

        [StringLength(10)]
        public string ordxxgs { get; set; }

        [StringLength(10)]
        public string ordmjsm { get; set; }

        [StringLength(15)]
        public string ordxtme { get; set; }

        [StringLength(200)]
        public string ordspec { get; set; }

        [StringLength(300)]
        public string ordsnot { get; set; }

        [StringLength(200)]
        public string ordpnot { get; set; }

        [StringLength(10)]
        public string ordmod { get; set; }

        [StringLength(30)]
        public string ordcitem { get; set; }

        [StringLength(100)]
        public string ordprod { get; set; }

        [StringLength(20)]
        public string ordman { get; set; }

        [StringLength(300)]
        public string ordnote { get; set; }

        [StringLength(10)]
        public string orduser { get; set; }

        public decimal? orddte { get; set; }

        public decimal? ordrat { get; set; }

        [StringLength(50)]
        public string ordsiz { get; set; }

        [StringLength(5)]
        public string ordrlg { get; set; }

        public decimal? ordsch { get; set; }

        [Key]
        [Column(Order = 0)]
        public decimal ordstat { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ordpric { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal ordvso { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal ordvstat { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(12)]
        public string ordftyp { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(15)]
        public string ordctm { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(15)]
        public string orddept { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(10)]
        public string ordmadd { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(30)]
        public string ordptyp3 { get; set; }
    }
}
