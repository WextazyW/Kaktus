//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class kaktusi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public kaktusi()
        {
            this.collection = new HashSet<collection>();
        }
    
        public int id_kaktus { get; set; }
        public string Vid { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Age { get; set; }
        public string Proishojdenie { get; set; }
        public string Instrukciya { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<collection> collection { get; set; }
    }
}