namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vendor")]
    public partial class vendor
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string vid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int vend { get; set; }

        [Required]
        [StringLength(50)]
        public string vname { get; set; }

        [StringLength(10)]
        public string vprov { get; set; }

        [StringLength(10)]
        public string vcoty { get; set; }

        [StringLength(150)]
        public string vadr { get; set; }

        [StringLength(15)]
        public string vphone { get; set; }

        [StringLength(15)]
        public string vfax { get; set; }

        [StringLength(70)]
        public string vemail { get; set; }

        [StringLength(15)]
        public string vcontract { get; set; }

        [StringLength(50)]
        public string vterm { get; set; }

        [StringLength(3)]
        public string vcurr { get; set; }

        [StringLength(50)]
        public string vbank { get; set; }

        [StringLength(20)]
        public string vacct { get; set; }

        public int? vtax { get; set; }

        [StringLength(100)]
        public string vremark { get; set; }
    }
}
