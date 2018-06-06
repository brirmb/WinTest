namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("morder")]
    public partial class morder
    {
        [Key]
        [StringLength(40)]
        public string Mono { get; set; }

        [StringLength(100)]
        public string Custname { get; set; }

        public decimal? Moqty { get; set; }

        [StringLength(40)]
        public string Model { get; set; }

        [StringLength(40)]
        public string Material1 { get; set; }

        [StringLength(40)]
        public string Material2 { get; set; }

        [StringLength(40)]
        public string Material3 { get; set; }

        [StringLength(40)]
        public string Material4 { get; set; }

        [StringLength(40)]
        public string Material5 { get; set; }

        [StringLength(10)]
        public string Material6 { get; set; }

        [StringLength(40)]
        public string Material7 { get; set; }

        [StringLength(40)]
        public string Material8 { get; set; }

        [StringLength(2)]
        public string Mway { get; set; }

        public DateTime? MordDate { get; set; }

        public DateTime? Mdate { get; set; }

        [Column(TypeName = "image")]
        public byte[] WaterImage { get; set; }

        [StringLength(200)]
        public string Material9 { get; set; }

        public string Memo { get; set; }
    }
}
