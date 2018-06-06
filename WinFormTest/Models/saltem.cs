namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saltem")]
    public partial class saltem
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string teid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string term { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string tdesc { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tdays { get; set; }
    }
}
