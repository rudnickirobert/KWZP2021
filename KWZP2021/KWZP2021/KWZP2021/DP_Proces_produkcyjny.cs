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
    
    public partial class DP_Proces_produkcyjny
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DP_Proces_produkcyjny()
        {
            this.DP_prod_czynnosc_dodatkowa = new HashSet<DP_prod_czynnosc_dodatkowa>();
            this.DP_prod_material = new HashSet<DP_prod_material>();
            this.DP_prod_wydruk = new HashSet<DP_prod_wydruk>();
        }
    
        public int Id_proces_produkcyjny { get; set; }
        public int Id_proces_technologiczny { get; set; }
        public Nullable<System.DateTime> Data_realizacji { get; set; }
    
        public virtual DP_Proces_technologiczny DP_Proces_technologiczny { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_prod_czynnosc_dodatkowa> DP_prod_czynnosc_dodatkowa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_prod_material> DP_prod_material { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_prod_wydruk> DP_prod_wydruk { get; set; }
    }
}
