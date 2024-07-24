namespace GUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TEACHER")]
    public partial class TEACHER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TEACHER()
        {
            COURSEs = new HashSet<COURSE>();
        }

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

        public int? SALARY { get; set; }

        [StringLength(10)]
        public string SUBJECTID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COURSE> COURSEs { get; set; }

        public virtual SUBJECTT SUBJECTT { get; set; }
    }
}
