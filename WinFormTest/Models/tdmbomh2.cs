namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tdmbomh2
    {
        [StringLength(1)]
        public string bomhsts { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string bomhmno { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string bomhwno { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal bomhver { get; set; }

        [StringLength(100)]
        public string bomhcus { get; set; }

        [StringLength(100)]
        public string bomhnam { get; set; }

        [StringLength(40)]
        public string bomhtyp { get; set; }

        public decimal? bomhrat { get; set; }

        [StringLength(100)]
        public string bomhmat { get; set; }

        [StringLength(100)]
        public string bomhsiz { get; set; }

        public decimal? bomhnot { get; set; }

        public DateTime? bomhdte { get; set; }

        [StringLength(40)]
        public string bomhunit { get; set; }
    }
}
