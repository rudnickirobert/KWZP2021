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
    
    public partial class DP_Firma_serwisowa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DP_Firma_serwisowa()
        {
            this.DP_Serwis_zewnetrzny = new HashSet<DP_Serwis_zewnetrzny>();
        }
    
        public int Id_firma_serwisowa { get; set; }
        public string nazwa_firmy { get; set; }
        public string adres { get; set; }
        public string miasto { get; set; }
        public string kod_pocztowy { get; set; }
        public string nr_tel { get; set; }
        public string e_mail { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_Serwis_zewnetrzny> DP_Serwis_zewnetrzny { get; set; }
    }
}
