namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tsfcbom2
    {
        [StringLength(1)]
        public string bomflg { get; set; }

        public decimal? bomseq { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string bomwno { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string bommno { get; set; }

        [StringLength(12)]
        public string bomitm { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string bompno { get; set; }

        public decimal? bomreq { get; set; }

        public decimal? bomisu { get; set; }

        [StringLength(1)]
        public string bompry { get; set; }

        public decimal? bomrdt { get; set; }

        public decimal? bomqua { get; set; }

        [StringLength(2)]
        public string bomwhs { get; set; }

        [StringLength(2)]
        public string bomfac { get; set; }

        [StringLength(2)]
        public string bomsts { get; set; }

        [StringLength(4)]
        public string bomloc { get; set; }

        public DateTime? bomdte { get; set; }

        public decimal? bomtme { get; set; }

        [StringLength(7)]
        public string bompro { get; set; }

        public decimal? bomver { get; set; }

        public decimal? bompre { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string bommat { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string bomspc { get; set; }

        public decimal? bomser { get; set; }

        [StringLength(40)]
        public string bomdra { get; set; }

        public DateTime? bomdt1 { get; set; }

        [StringLength(50)]
        public string bomnam { get; set; }

        [StringLength(1)]
        public string bomtype { get; set; }

        [StringLength(50)]
        public string bomuit { get; set; }
    }
}
