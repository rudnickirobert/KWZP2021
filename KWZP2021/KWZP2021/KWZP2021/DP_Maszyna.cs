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
    
    public partial class DP_Maszyna
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DP_Maszyna()
        {
            this.DM_Sklad_dostawy_maszyn = new HashSet<DM_Sklad_dostawy_maszyn>();
            this.DP_prod_wydruk = new HashSet<DP_prod_wydruk>();
            this.DP_Serwis_zewnetrzny = new HashSet<DP_Serwis_zewnetrzny>();
            this.DP_Serwis_wewnetrzny_naprawa = new HashSet<DP_Serwis_wewnetrzny_naprawa>();
            this.DP_Serwis_wewnetrzny_obsluga = new HashSet<DP_Serwis_wewnetrzny_obsluga>();
            this.DP_Zuzyta_maszyna = new HashSet<DP_Zuzyta_maszyna>();
            this.DZ_Szczegoly_zam_maszyn = new HashSet<DZ_Szczegoly_zam_maszyn>();
            this.DP_Model_maszyny1 = new HashSet<DP_Model_maszyny>();
            this.DP_Po_proc_czynnosc = new HashSet<DP_Po_proc_czynnosc>();
            this.DP_Po_wydr_proc = new HashSet<DP_Po_wydr_proc>();
            this.DP_prod_czynnosc_dodatkowa = new HashSet<DP_prod_czynnosc_dodatkowa>();
        }
    
        public int Id_maszyny { get; set; }
        public Nullable<int> Id_rodzaj_maszyny { get; set; }
        public Nullable<int> Id_model_maszyny { get; set; }
        public string Nr_seryjny { get; set; }
        public System.DateTime Data_wprowadzenia { get; set; }
        public decimal Koszt_1rh { get; set; }
    
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
        public virtual ICollection<DP_Zuzyta_maszyna> DP_Zuzyta_maszyna { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DZ_Szczegoly_zam_maszyn> DZ_Szczegoly_zam_maszyn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_Model_maszyny> DP_Model_maszyny1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_Po_proc_czynnosc> DP_Po_proc_czynnosc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_Po_wydr_proc> DP_Po_wydr_proc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_prod_czynnosc_dodatkowa> DP_prod_czynnosc_dodatkowa { get; set; }
    }
}
