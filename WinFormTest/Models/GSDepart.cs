namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GSDepart")]
    public partial class GSDepart
    {
        [Key]
        [StringLength(20)]
        public string depart { get; set; }
    }
}
