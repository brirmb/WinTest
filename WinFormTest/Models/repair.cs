namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("repair")]
    public partial class repair
    {
        [Key]
        [StringLength(8)]
        public string repno { get; set; }

        [StringLength(15)]
        public string repepno { get; set; }

        [StringLength(50)]
        public string repepname { get; set; }

        [StringLength(50)]
        public string repitem { get; set; }

        public decimal? repamt { get; set; }

        [StringLength(10)]
        public string repwho { get; set; }

        [StringLength(10)]
        public string repuser { get; set; }

        [StringLength(10)]
        public string repdate { get; set; }

        [StringLength(50)]
        public string repremark { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal serialno { get; set; }
    }
}
