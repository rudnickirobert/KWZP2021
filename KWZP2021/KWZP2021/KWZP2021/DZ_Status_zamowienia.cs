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
    
    public partial class DZ_Status_zamowienia
    {
        public int Id_status_zam { get; set; }
        public int Id_zamowienia { get; set; }
        public int Id_rodzaj_statusu_zam { get; set; }
    
        public virtual DZ_Rodzaj_statusu_zamowienia DZ_Rodzaj_statusu_zamowienia { get; set; }
        public virtual DZ_Zamowienie_klienta DZ_Zamowienie_klienta { get; set; }
    }
}
