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
    
    public partial class DM_Szczegoly_wydania_produktu
    {
        public int Id_szczegoly_wydania_produktu { get; set; }
        public int Id_wydania { get; set; }
        public int Id_produkt { get; set; }
        public int Ilosc { get; set; }
    
        public virtual DP_Produkt DP_Produkt { get; set; }
        public virtual DM_Wydanie_produktu DM_Wydanie_produktu { get; set; }
    }
}
