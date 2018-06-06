namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("salmin")]
    public partial class salmin
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string miid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string miprod { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal mipric { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mieff { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int midis { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(3)]
        public string micur { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(2)]
        public string mifac { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int micust { get; set; }
    }
}
