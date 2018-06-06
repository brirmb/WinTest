namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GSItem")]
    public partial class GSItem
    {
        [Key]
        [StringLength(10)]
        public string itemno { get; set; }

        [StringLength(20)]
        public string itemname { get; set; }

        [StringLength(20)]
        public string itemmaterial { get; set; }

        [StringLength(20)]
        public string itemspec { get; set; }

        public int? itemlevel { get; set; }
    }
}
