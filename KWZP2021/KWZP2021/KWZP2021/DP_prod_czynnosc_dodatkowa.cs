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
    
    public partial class DP_prod_czynnosc_dodatkowa
    {
        public int Id_prod_czynnosci_dodatkowe { get; set; }
        public Nullable<int> Id_proces_produkcyjny { get; set; }
        public Nullable<int> Id_rodzaj_czynnosci { get; set; }
        public Nullable<int> Czas_pracy { get; set; }
    
        public virtual DP_Proces_produkcyjny DP_Proces_produkcyjny { get; set; }
        public virtual DP_Rodzaj_czynnosci DP_Rodzaj_czynnosci { get; set; }
    }
}
