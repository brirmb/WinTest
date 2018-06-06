namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GSMachine")]
    public partial class GSMachine
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string machine { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string machineName { get; set; }
    }
}
