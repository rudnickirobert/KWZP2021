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
    
    public partial class DZ_Nieobecnosc
    {
        public int Id_nieobecnosci { get; set; }
        public Nullable<int> Id_pracownika { get; set; }
        public Nullable<int> Id_rodzaj_nieobecnosci { get; set; }
        public System.DateTime data_rozpoczecia { get; set; }
        public System.DateTime data_zakonczenia { get; set; }
    
        public virtual DZ_Pracownik DZ_Pracownik { get; set; }
        public virtual DZ_Rodzaj_nieobecnosci DZ_Rodzaj_nieobecnosci { get; set; }
    }
}
