//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _7_2_New
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task_CRUD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Task_CRUD()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int Id { get; set; }
        public string farst_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public Nullable<int> Phone { get; set; }
        public Nullable<int> Age { get; set; }
        public string Job_Title { get; set; }
        public Nullable<bool> Gender { get; set; }
        public string image { get; set; }
        public string CV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
