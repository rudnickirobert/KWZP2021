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
    
    public partial class DM_Wlasciwosc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_Wlasciwosc()
        {
            this.DM_Parametr_czesci = new HashSet<DM_Parametr_czesci>();
            this.DM_Parametr_narzedzia = new HashSet<DM_Parametr_narzedzia>();
            this.DM_Wlasciwosc_materialu = new HashSet<DM_Wlasciwosc_materialu>();
            this.DZ_Szczegoly_zam_czesci = new HashSet<DZ_Szczegoly_zam_czesci>();
            this.DZ_Szczegoly_zam_narzedzi = new HashSet<DZ_Szczegoly_zam_narzedzi>();
            this.DZ_Szczegoly_zam_materialu = new HashSet<DZ_Szczegoly_zam_materialu>();
        }
    
        public int Id_wlasciwosc { get; set; }
        public string Nazwa_wlasciwosci { get; set; }
        public string Jednostka_pomiarowa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Parametr_czesci> DM_Parametr_czesci { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Parametr_narzedzia> DM_Parametr_narzedzia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Wlasciwosc_materialu> DM_Wlasciwosc_materialu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DZ_Szczegoly_zam_czesci> DZ_Szczegoly_zam_czesci { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DZ_Szczegoly_zam_narzedzi> DZ_Szczegoly_zam_narzedzi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DZ_Szczegoly_zam_materialu> DZ_Szczegoly_zam_materialu { get; set; }
    }
}
