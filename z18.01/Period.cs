//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace z18._01
{
    using System;
    using System.Collections.Generic;
    
    public partial class Period
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Period()
        {
            this.Oplatas = new HashSet<Oplata>();
        }
    
        public int id_perioda { get; set; }
        public string nazvanie_period { get; set; }
        public Nullable<System.DateTime> nachalo_per { get; set; }
        public Nullable<System.DateTime> konec_per { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oplata> Oplatas { get; set; }
    }
}
