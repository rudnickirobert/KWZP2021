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
    
    public partial class DZ_Szczegoly_zam_czesci
    {
        public int Id_szczegoly_zam_czesci { get; set; }
        public Nullable<int> Id_zamowienia_zewn { get; set; }
        public Nullable<int> Id_czesci { get; set; }
        public double Koszt_jednostkowy_oferta { get; set; }
        public Nullable<int> Id_wlasciwosc { get; set; }
        public int Ilosc { get; set; }
    
        public virtual DM_Czesc DM_Czesc { get; set; }
        public virtual DM_Wlasciwosc DM_Wlasciwosc { get; set; }
        public virtual DZ_Zamowienie_zewn DZ_Zamowienie_zewn { get; set; }
    }
}
