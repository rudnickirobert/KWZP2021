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
        public System.DateTime Data_rozpoczecia { get; set; }
        public Nullable<System.DateTime> Data_zakonczenia { get; set; }
        public string Uwagi { get; set; }
    
        public virtual DP_Maszyna DP_Maszyna { get; set; }
        public virtual DZ_Pracownik DZ_Pracownik { get; set; }
    }
}