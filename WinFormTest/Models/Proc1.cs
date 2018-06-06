namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Proc1
    {
        [Key]
        [StringLength(40)]
        public string Code { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(200)]
        public string StationSeq { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }
    }
}
