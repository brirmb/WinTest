namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zjplan")]
    public partial class zjplan
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string mono { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int seq { get; set; }

        [StringLength(40)]
        public string item { get; set; }

        public DateTime? date1 { get; set; }

        public DateTime? date2 { get; set; }

        public DateTime? date3 { get; set; }

        [StringLength(40)]
        public string person { get; set; }

        [StringLength(200)]
        public string remark { get; set; }
    }
}
