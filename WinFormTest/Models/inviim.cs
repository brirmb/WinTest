namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("inviim")]
    public partial class inviim
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string imid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string improd { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string imdes { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string imname { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string imfac { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string immode { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string imvnam { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(3)]
        public string imium { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(3)]
        public string impum { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(3)]
        public string imcvr { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(1)]
        public string imtyp { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal imukg { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal imusiz { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal immax { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal immin { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal imsct { get; set; }

        [Key]
        [Column(Order = 16)]
        public decimal imact { get; set; }

        [Key]
        [Column(Order = 17)]
        public decimal imnct { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(1)]
        public string imabc { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(2)]
        public string imbpc { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(3)]
        public string imkpc { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int imltm { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int imllc { get; set; }

        [Key]
        [Column(Order = 23)]
        public DateTime imdte { get; set; }

        [Key]
        [Column(Order = 24)]
        public DateTime imtim { get; set; }

        [Key]
        [Column(Order = 25)]
        [StringLength(10)]
        public string imusr { get; set; }
    }
}
