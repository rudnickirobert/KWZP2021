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
    
    public partial class DP_Serwis_wewnetrzny_naprawa
    {
        public int Id_serwis_wewnetrzny_naprawa { get; set; }
        public Nullable<int> Id_maszyny { get; set; }
        public Nullable<int> Id_pracownik { get; set; }
        public System.DateTime data_rozpoczecia { get; set; }
        public Nullable<System.DateTime> data_zakonczenia { get; set; }
        public string uwagi { get; set; }
    
        public virtual DP_Maszyny DP_Maszyny { get; set; }
        public virtual DZ_Pracownik DZ_Pracownik { get; set; }
    }
}
