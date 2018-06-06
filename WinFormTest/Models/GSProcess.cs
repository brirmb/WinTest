namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GSProcess")]
    public partial class GSProcess
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string product { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string partno { get; set; }

        [StringLength(20)]
        public string partname { get; set; }

        [StringLength(20)]
        public string material { get; set; }

        [StringLength(10)]
        public string size { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string process { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int seq { get; set; }

        [StringLength(100)]
        public string processdetail { get; set; }

        public decimal? readytime { get; set; }

        public decimal? worktime { get; set; }
    }
}
