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
    
    public partial class DP_Maszyny
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DP_Maszyny()
        {
            this.DM_Sklad_dostawy_maszyn = new HashSet<DM_Sklad_dostawy_maszyn>();
            this.DP_prod_wydruk = new HashSet<DP_prod_wydruk>();
            this.DP_Serwis_zewnetrzny = new HashSet<DP_Serwis_zewnetrzny>();
            this.DP_Serwis_wewnetrzny_naprawa = new HashSet<DP_Serwis_wewnetrzny_naprawa>();
            this.DP_Serwis_wewnetrzny_obsluga = new HashSet<DP_Serwis_wewnetrzny_obsluga>();
            this.DP_Zuzute_maszyny = new HashSet<DP_Zuzute_maszyny>();
            this.DZ_Szczegoly_zam_maszyn = new HashSet<DZ_Szczegoly_zam_maszyn>();
        }
    
        public int Id_maszyny { get; set; }
        public Nullable<int> Id_rodzaj_maszyny { get; set; }
        public Nullable<int> Id_model_maszyny { get; set; }
        public string nr_seryjny { get; set; }
        public System.DateTime data_wprowadzenia { get; set; }
        public decimal koszt_1rh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Sklad_dostawy_maszyn> DM_Sklad_dostawy_maszyn { get; set; }
        public virtual DP_Model_maszyny DP_Model_maszyny { get; set; }
        public virtual DP_Rodzaj_maszyny DP_Rodzaj_maszyny { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_prod_wydruk> DP_prod_wydruk { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_Serwis_zewnetrzny> DP_Serwis_zewnetrzny { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_Serwis_wewnetrzny_naprawa> DP_Serwis_wewnetrzny_naprawa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_Serwis_wewnetrzny_obsluga> DP_Serwis_wewnetrzny_obsluga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_Zuzute_maszyny> DP_Zuzute_maszyny { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DZ_Szczegoly_zam_maszyn> DZ_Szczegoly_zam_maszyn { get; set; }
    }
}