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
    
    public partial class DM_Wypozyczenie_narzedzia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_Wypozyczenie_narzedzia()
        {
            this.DM_Szczegoly_wypozyczenia_narzedzia = new HashSet<DM_Szczegoly_wypozyczenia_narzedzia>();
            this.DM_Zuzyte_narzedzia = new HashSet<DM_Zuzyte_narzedzia>();
        }
    
        public int Id_wypozyczenia_narzedzia { get; set; }
        public int Id_pracownika_wypozyczajacego { get; set; }
        public int Id_pracownika_wydajacego { get; set; }
        public Nullable<System.DateTime> data_i_godzina_wypozyczenia { get; set; }
        public Nullable<System.DateTime> data_i_godzina_zwrotu { get; set; }
        public string uwagi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Szczegoly_wypozyczenia_narzedzia> DM_Szczegoly_wypozyczenia_narzedzia { get; set; }
        public virtual DZ_Pracownik DZ_Pracownik { get; set; }
        public virtual DZ_Pracownik DZ_Pracownik1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Zuzyte_narzedzia> DM_Zuzyte_narzedzia { get; set; }
    }
}
