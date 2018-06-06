namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("purhph")]
    public partial class purhph
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string pmid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pmord { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pmvend { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string pmrevn { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string pmwhs { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(4)]
        public string pmloc { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string pmsvia { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(2)]
        public string pmterm { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(3)]
        public string pmtrc { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(10)]
        public string pmbuy { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pmedte { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pmdte { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pmtim { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(10)]
        public string pmusr { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(1)]
        public string pmpst { get; set; }
    }
}
