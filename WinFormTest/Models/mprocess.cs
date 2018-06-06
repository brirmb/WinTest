namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mprocess")]
    public partial class mprocess
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string mono { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int moseq { get; set; }

        [Required]
        [StringLength(40)]
        public string pono { get; set; }

        [StringLength(40)]
        public string poname { get; set; }

        public int? moqty { get; set; }

        [StringLength(40)]
        public string unit { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string procCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(40)]
        public string stationCode { get; set; }

        public int? FinishQty { get; set; }
    }
}
