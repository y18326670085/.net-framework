//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Orm2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student_DB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student_DB()
        {
            this.GainPoint_DB = new HashSet<GainPoint_DB>();
            this.Class_DB = new HashSet<Class_DB>();
        }
    
        public int Id { get; set; }
        public int Age { get; set; }
        public string Birthday { get; set; }
        public string From { get; set; }
        public string Grade { get; set; }
        public string No { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
        public string RelName { get; set; }
        public string Sex { get; set; }
        public string UserName { get; set; }
        public Nullable<int> departmentId { get; set; }
    
        public virtual Department_DB Department_DB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GainPoint_DB> GainPoint_DB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class_DB> Class_DB { get; set; }
    }
}
