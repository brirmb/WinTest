namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GSClass")]
    public partial class GSClass
    {
        [Key]
        [Column("class")]
        [StringLength(20)]
        public string _class { get; set; }
    }
}
