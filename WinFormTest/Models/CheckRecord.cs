namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckRecord")]
    public partial class CheckRecord
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string Repno { get; set; }

        [StringLength(10)]
        public string Roperator { get; set; }

        [StringLength(4)]
        public string Rmaintain { get; set; }

        [StringLength(4)]
        public string RClean { get; set; }

        [StringLength(4)]
        public string Rput { get; set; }

        [StringLength(100)]
        public string Radvise { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Rdate { get; set; }
    }
}
