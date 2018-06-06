namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shiping")]
    public partial class shiping
    {
        [Key]
        [StringLength(9)]
        public string shipno { get; set; }

        public int? shipseq { get; set; }

        [StringLength(20)]
        public string shipso { get; set; }

        [StringLength(20)]
        public string shipsono { get; set; }

        [StringLength(30)]
        public string shipmno { get; set; }

        public int? shipcustno { get; set; }

        [StringLength(50)]
        public string shipcustname { get; set; }

        [StringLength(50)]
        public string shipname { get; set; }

        [StringLength(4)]
        public string shipunit { get; set; }

        public decimal? shipqreq { get; set; }

        public decimal? shipqplan { get; set; }

        public decimal? shipqact { get; set; }

        public decimal? shipdate { get; set; }

        public int? shipstatus { get; set; }
    }
}
