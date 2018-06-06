namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class salsys
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string saidpa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string sapkey { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string sadata { get; set; }
    }
}
