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
    
    public partial class DP_Po_proc_czynnosc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DP_Po_proc_czynnosc()
        {
            this.DP_Po_material_czynnosc = new HashSet<DP_Po_material_czynnosc>();
            this.DP_Maszyna = new HashSet<DP_Maszyna>();
            this.DM_Narzedzie = new HashSet<DM_Narzedzie>();
            this.DZ_Pracownik = new HashSet<DZ_Pracownik>();
        }
    
        public int Id_po_proc_czynnosci { get; set; }
        public int Id_rodzaj_czynnosci { get; set; }
        public int Id_proces_technologiczny { get; set; }
        public System.DateTime Czas_zamierzony { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_Po_material_czynnosc> DP_Po_material_czynnosc { get; set; }
        public virtual DP_Proces_technologiczny DP_Proces_technologiczny { get; set; }
        public virtual DP_Rodzaj_czynnosci DP_Rodzaj_czynnosci { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_Maszyna> DP_Maszyna { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Narzedzie> DM_Narzedzie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DZ_Pracownik> DZ_Pracownik { get; set; }
    }
}
