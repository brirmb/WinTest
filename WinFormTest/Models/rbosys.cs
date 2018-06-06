namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rbosys
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string sid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string category { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string val1 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string val2 { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string val3 { get; set; }

        [Required]
        [StringLength(20)]
        public string val4 { get; set; }

        [StringLength(30)]
        public string desc { get; set; }
    }
}
