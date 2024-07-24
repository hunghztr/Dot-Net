namespace GUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GRADELIST")]
    public partial class GRADELIST
    {
        [StringLength(10)]
        public string ID { get; set; }

        public decimal? MATH { get; set; }

        public decimal? LITERATURE { get; set; }

        public decimal? ENGLISH { get; set; }

        public decimal? PHYSICAL { get; set; }

        public decimal? CHEMISTRY { get; set; }

        public decimal? HISTORY { get; set; }

        public decimal? GEOGRAPHYY { get; set; }

        public decimal? AVGGRADE { get; set; }

        public virtual STUDENT STUDENT { get; set; }
    }
}
