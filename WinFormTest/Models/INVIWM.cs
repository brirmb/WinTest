namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVIWM")]
    public partial class INVIWM
    {
        [StringLength(40)]
        public string WMID { get; set; }

        [Key]
        [StringLength(40)]
        public string WMwhs { get; set; }

        [StringLength(40)]
        public string wmdes { get; set; }

        [StringLength(40)]
        public string wmarea { get; set; }

        [StringLength(40)]
        public string wmprov { get; set; }

        [StringLength(40)]
        public string wmcoty { get; set; }

        [StringLength(40)]
        public string wmadr1 { get; set; }

        [StringLength(40)]
        public string wmadr2 { get; set; }

        [StringLength(40)]
        public string wmadr3 { get; set; }

        [StringLength(40)]
        public string wmpon1 { get; set; }

        [StringLength(40)]
        public string wmpon2 { get; set; }

        [StringLength(40)]
        public string wmpon3 { get; set; }

        [StringLength(40)]
        public string wmfax1 { get; set; }

        [StringLength(40)]
        public string wmfax2 { get; set; }

        [StringLength(40)]
        public string wmmal1 { get; set; }

        [StringLength(40)]
        public string wmmal2 { get; set; }

        [StringLength(40)]
        public string wmctat { get; set; }

        [StringLength(40)]
        public string wmtyp { get; set; }

        [StringLength(40)]
        public string wmranh { get; set; }
    }
}
