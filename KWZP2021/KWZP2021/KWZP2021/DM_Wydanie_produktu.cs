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
    
    public partial class DM_Wydanie_produktu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_Wydanie_produktu()
        {
            this.DM_Szczegoly_wydania_produktu = new HashSet<DM_Szczegoly_wydania_produktu>();
        }
    
        public int Id_wydania { get; set; }
        public int Id_magazyn_gotowych_produktow { get; set; }
        public Nullable<int> Id_pracownika { get; set; }
        public System.DateTime Data_i_godzina { get; set; }
        public string Uwagi { get; set; }
    
        public virtual DM_Magazyn_gotowych_produktow DM_Magazyn_gotowych_produktow { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Szczegoly_wydania_produktu> DM_Szczegoly_wydania_produktu { get; set; }
        public virtual DZ_Pracownik DZ_Pracownik { get; set; }
    }
}
