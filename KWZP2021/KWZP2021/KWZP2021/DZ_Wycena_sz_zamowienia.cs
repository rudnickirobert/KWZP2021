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
    
    public partial class DZ_Wycena_sz_zamowienia
    {
        public int Id_wycena_sz_zamowienia { get; set; }
        public Nullable<int> Id_szczegoly_zam_klienta { get; set; }
        public Nullable<int> Id_pliku { get; set; }
        public double koszt { get; set; }
        public int czas_wykonania { get; set; }
    
        public virtual DZ_Plik DZ_Plik { get; set; }
        public virtual DZ_Szczegoly_zamowienia_klienta DZ_Szczegoly_zamowienia_klienta { get; set; }
    }
}
