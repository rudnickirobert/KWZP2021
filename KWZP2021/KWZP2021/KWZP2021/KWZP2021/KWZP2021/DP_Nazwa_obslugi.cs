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
    
    public partial class DP_Nazwa_obslugi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DP_Nazwa_obslugi()
        {
            this.DP_Czynnosci_w_ramach_obslugi_serw_wew = new HashSet<DP_Czynnosci_w_ramach_obslugi_serw_wew>();
            this.DP_Obsluga = new HashSet<DP_Obsluga>();
        }
    
        public int Id_nazwa_obslugi { get; set; }
        public string nazwa_obslugi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_Czynnosci_w_ramach_obslugi_serw_wew> DP_Czynnosci_w_ramach_obslugi_serw_wew { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_Obsluga> DP_Obsluga { get; set; }
    }
}