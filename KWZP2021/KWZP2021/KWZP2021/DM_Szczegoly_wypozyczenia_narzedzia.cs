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
    
    public partial class DM_Szczegoly_wypozyczenia_narzedzia
    {
        public int Id_wypozyczenia_narz { get; set; }
        public int Id_wypozyczenia_narzedzia { get; set; }
        public int Id_narzedzia { get; set; }
        public int Ilosc { get; set; }
    
        public virtual DM_Narzedzie DM_Narzedzie { get; set; }
        public virtual DM_Wypozyczenie_narzedzia DM_Wypozyczenie_narzedzia { get; set; }
    }
}
