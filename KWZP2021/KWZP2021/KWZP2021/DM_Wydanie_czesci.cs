//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP2021
{
    using System;
    using System.Collections.Generic;
    
    public partial class DM_Wydanie_czesci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_Wydanie_czesci()
        {
            this.DM_Szczegoly_wydania_czesci = new HashSet<DM_Szczegoly_wydania_czesci>();
        }
    
        public int Id_wydania_czesci { get; set; }
        public int Id_pracownik_pobierajacy { get; set; }
        public int Id_pracownik_wydajacy { get; set; }
        public System.DateTime data_i_godzina { get; set; }
        public string uwagi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Szczegoly_wydania_czesci> DM_Szczegoly_wydania_czesci { get; set; }
        public virtual DZ_Pracownik DZ_Pracownik { get; set; }
        public virtual DZ_Pracownik DZ_Pracownik1 { get; set; }
    }
}
