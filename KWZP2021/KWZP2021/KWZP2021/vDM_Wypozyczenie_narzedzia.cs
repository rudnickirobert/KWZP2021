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
    
    public partial class vDM_Wypozyczenie_narzedzia
    {
        public int Identyfikator_wypozyczenia { get; set; }
        public string Nazwisko_pracownika_wypozyczajacego { get; set; }
        public string Nazwisko_pracownika_wydajacego { get; set; }
        public System.DateTime Data_i_godzina_wypozyczenia { get; set; }
        public Nullable<System.DateTime> C_Data_i_godzina_zwrotu { get; set; }
        public string C_Uwagi { get; set; }
    }
}
