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
        public int Id_po_proc_czynnosci { get; set; }
        public Nullable<int> Id_rodzaj_czynnosci { get; set; }
        public Nullable<int> Id_proces_technologiczny { get; set; }
        public System.DateTime Czas_zamierzony { get; set; }
    
        public virtual DP_Proces_technologiczny DP_Proces_technologiczny { get; set; }
        public virtual DP_Rodzaj_czynnosci DP_Rodzaj_czynnosci { get; set; }
    }
}
