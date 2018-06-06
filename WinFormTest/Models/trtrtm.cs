namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("trtrtm")]
    public partial class trtrtm
    {
        [StringLength(2)]
        public string rtid { get; set; }

        [StringLength(11)]
        public string rtrno { get; set; }

        public decimal? rtseq { get; set; }

        [StringLength(2)]
        public string rtsts { get; set; }

        [StringLength(2)]
        public string rttyp { get; set; }

        [StringLength(50)]
        public string rtprod { get; set; }

        [StringLength(2)]
        public string rtfac { get; set; }

        [StringLength(2)]
        public string rtwhs { get; set; }

        public double? rtloc { get; set; }

        [StringLength(15)]
        public string rtinv { get; set; }

        public decimal? rtprno { get; set; }

        [StringLength(20)]
        public string rtsono { get; set; }

        [StringLength(50)]
        public string rttno { get; set; }

        [StringLength(50)]
        public string rtproc { get; set; }

        [StringLength(7)]
        public string rtapnbr { get; set; }

        [StringLength(3)]
        public string rtplnc { get; set; }

        [StringLength(3)]
        public string rtbuyc { get; set; }

        public decimal? rtvend { get; set; }

        public decimal? rtqinv { get; set; }

        public decimal? rtqact { get; set; }

        public decimal? rtqpts { get; set; }

        public decimal? rtqscrp { get; set; }

        public decimal? rtqqty { get; set; }

        [StringLength(3)]
        public string rtcur { get; set; }

        public int? rtxrt { get; set; }

        public decimal? rtscst { get; set; }

        [StringLength(4)]
        public string rtiump { get; set; }

        [StringLength(60)]
        public string rtmark { get; set; }

        [StringLength(12)]
        public string rtcby { get; set; }

        [StringLength(12)]
        public string rtcdte { get; set; }

        [StringLength(15)]
        public string rtctm { get; set; }

        [StringLength(20)]
        public string rtpgm { get; set; }

        public decimal? rtprseq { get; set; }

        [Key]
        [StringLength(4)]
        public string rttcount { get; set; }

        public decimal? rtPerWeight { get; set; }

        public decimal? rtSumWeight { get; set; }
    }
}
