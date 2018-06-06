namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GSWorkDetail")]
    public partial class GSWorkDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string worklno { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int workseq { get; set; }

        [StringLength(10)]
        public string product { get; set; }

        [StringLength(30)]
        public string itemno { get; set; }

        [StringLength(20)]
        public string itemname { get; set; }

        [StringLength(20)]
        public string material { get; set; }

        [StringLength(10)]
        public string size { get; set; }

        [StringLength(4)]
        public string process { get; set; }

        public int? seq { get; set; }

        [StringLength(100)]
        public string processdetail { get; set; }

        public decimal? readytime { get; set; }

        public decimal? operatetime { get; set; }

        public int? workqty { get; set; }

        public decimal? subHours { get; set; }

        [StringLength(50)]
        public string machine { get; set; }

        public decimal? machineHours { get; set; }

        [StringLength(10)]
        public string workdate { get; set; }

        [StringLength(100)]
        public string remark { get; set; }
    }
}
