namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GSEmployee")]
    public partial class GSEmployee
    {
        [Key]
        [StringLength(10)]
        public string empid { get; set; }

        [StringLength(10)]
        public string empname { get; set; }

        [StringLength(10)]
        public string empclass { get; set; }

        [StringLength(50)]
        public string empdepart { get; set; }
    }
}
