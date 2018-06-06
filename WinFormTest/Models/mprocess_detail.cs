namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mprocess_detail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string mono { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mlseq { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string pono { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(40)]
        public string poname { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(40)]
        public string procCode { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(40)]
        public string stationCode { get; set; }

        public DateTime? FinishDate { get; set; }

        public DateTime? FinishTime { get; set; }

        public int? FinishQty { get; set; }
    }
}
