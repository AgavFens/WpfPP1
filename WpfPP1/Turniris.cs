//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfPP1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Turniris
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Turniris()
        {
            this.KomandiTurniri = new HashSet<KomandiTurniri>();
        }
    
        public int ID_Turnir { get; set; }
        public string TurnirName { get; set; }
        public string Janr { get; set; }
        public string Igra { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KomandiTurniri> KomandiTurniri { get; set; }
    }
}