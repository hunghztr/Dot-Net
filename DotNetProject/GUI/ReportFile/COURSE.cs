namespace GUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COURSE")]
    public partial class COURSE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COURSE()
        {
            STUDENTs = new HashSet<STUDENT>();
        }

        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(30)]
        public string COURSENAME { get; set; }

        [StringLength(10)]
        public string HOMEROOMTEACHERID { get; set; }

        public virtual TEACHER TEACHER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STUDENT> STUDENTs { get; set; }
    }
}
