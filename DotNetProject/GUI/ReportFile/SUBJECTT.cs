namespace GUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUBJECTT")]
    public partial class SUBJECTT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUBJECTT()
        {
            TEACHERs = new HashSet<TEACHER>();
        }

        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(30)]
        public string SUBJECTNAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEACHER> TEACHERs { get; set; }
    }
}
