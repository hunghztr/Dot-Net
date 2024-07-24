namespace GUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STUDENT")]
    public partial class STUDENT
    {
        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(30)]
        public string CCCD { get; set; }

        [StringLength(30)]
        public string FULLNAME { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BIRTH { get; set; }

        [StringLength(30)]
        public string ADDRESSS { get; set; }

        [StringLength(10)]
        public string PHONE { get; set; }

        [StringLength(30)]
        public string SCHOOLYEAR { get; set; }

        [StringLength(10)]
        public string COURSEID { get; set; }

        public virtual COURSE COURSE { get; set; }

        public virtual GRADELIST GRADELIST { get; set; }
    }
}
